using ProyectoCine.Models;

namespace ProyectoCine.Views;

public partial class HistorialPage : ContentPage
{
	public HistorialPage()
	{
		InitializeComponent();
		BindingContext = new Models.Historial();
	}
   
}