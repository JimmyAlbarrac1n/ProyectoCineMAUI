using ProyectoCine.Models;
using System.Collections.ObjectModel;

namespace ProyectoCine.Views;

public partial class HistorialPage : ContentPage
{

    public HistorialPage()
    {
        InitializeComponent();
        BindingContext =new Historial();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((Historial)BindingContext).LoadPurchases();
    }

    private async void PurchasesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var purchase = (Compra)e.CurrentSelection[0];
            await Shell.Current.GoToAsync($"{nameof(CompraPage)}?{nameof(CompraPage.ItemId)}={purchase.Filename}");
            purchasesCollection.SelectedItem = null;
        }
    }
    
}


