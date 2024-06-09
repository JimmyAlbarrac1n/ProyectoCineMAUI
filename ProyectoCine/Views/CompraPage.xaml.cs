using ProyectoCine.Models;

namespace ProyectoCine.Views;

public partial class CompraPage : ContentPage
{
	public CompraPage(Compra compra)
	{
		InitializeComponent();
        BindingContext = compra;
    }

    private void CompraButton_Clicked(object sender, EventArgs e)
    {

    }
}