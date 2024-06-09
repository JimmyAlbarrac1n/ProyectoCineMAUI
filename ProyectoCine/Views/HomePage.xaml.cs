using ProyectoCine.Models;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoCine.Views;

public partial class HomePage : ContentPage
{
    public ObservableCollection<Pelicula> Peliculas { get; set; }


    public Command<Pelicula> PeliculaTappedCommand { get; }
    public HomePage()
	{
		InitializeComponent();
        Peliculas = new ObservableCollection<Pelicula>
            {
                new Pelicula { Title = "Intensamente 2", Poster = "intensamente2.jpg", Synopsis = "Sinopsis de Intensamente 2" },
                new Pelicula { Title = "Bad Boys 4", Poster = "badboys4.jpg", Synopsis = "Sinopsis de Bad Boys 4" },
                new Pelicula { Title = "Interestelar", Poster = "interestelar.jpg", Synopsis = "Sinopsis de interestelar" },
                new Pelicula { Title = "Titanic", Poster = "titanic.jpg", Synopsis = "Sinopsis de titanic" },
            };
        

        PeliculaTappedCommand = new Command<Pelicula>(OnMovieTapped);

        BindingContext = this;
    }
    /*private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var peliculas = new ObservableCollection<Pelicula>(Pelicula.Search(((SearchBar)sender).Text));
    }*/
    
    async void OnMovieTapped(Pelicula pelicula)
    {
        if (pelicula == null)
            return;
        var compra = new Compra
        {
            Title = pelicula.Title,
            Poster = pelicula.Poster,
            Synopsis = pelicula.Synopsis,
            TicketCount = 1,
            TicketPrice = 10.0m // Precio fijo por entrada
        };

        // Navegar a la página de compra
        await Navigation.PushAsync(new CompraPage(compra));
    }
}
