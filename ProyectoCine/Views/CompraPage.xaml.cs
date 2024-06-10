using ProyectoCine.Models;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace ProyectoCine.Views;

[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class CompraPage : ContentPage
{
    public string ItemId
    {
        set { LoadPurchase(value); }
    }
    public CompraPage(Compra compra)
    {
        InitializeComponent();
        BindingContext = compra;
    }
    private void LoadPurchase(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        var compra = new Compra
        {
            Filename = fileName,
            Title = lines[0],
            TicketCount = int.Parse(lines[1]),
            TicketPrice = decimal.Parse(lines[2])
        };

        BindingContext = compra;
    }
    private async void SavePurchase(Compra compra)
    {
        string appDataPath = FileSystem.AppDataDirectory;
        string fileName = Path.Combine(appDataPath, $"{Path.GetRandomFileName()}.compra.txt");

        string[] lines = new string[]
        {
                compra.Title,
                compra.TicketCount.ToString(),
                compra.TicketPrice.ToString()
        };

        File.WriteAllLines(fileName, lines);
        await DisplayAlert("Guardado", "La compra ha sido guardada.", "OK");
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is Compra compra)
            SavePurchase(compra);
        await Shell.Current.GoToAsync("..");
    }
    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is Compra compra)
        {
            if (File.Exists(compra.Filename))
                File.Delete(compra.Filename);
            await DisplayAlert("Eliminado", "La compra ha sido eliminada.", "OK");
            await Shell.Current.GoToAsync("..");
        }
    }
}s