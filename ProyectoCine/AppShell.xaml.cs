namespace ProyectoCine
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.CompraPage), typeof(Views.CompraPage));
        }
    }
}
