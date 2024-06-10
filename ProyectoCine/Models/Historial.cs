using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Models
{
    public class Historial
    {
        public ObservableCollection<Compra> Compras { get; set; } = new ObservableCollection<Compra>();

        public Historial()
        {
            LoadPurchases();
        }

        public void LoadPurchases()
        {
            Compras.Clear();

            string appDataPath = FileSystem.AppDataDirectory;


            IEnumerable<Compra> purchases = Directory
                .EnumerateFiles(appDataPath, "*.compra.txt")
                .Select(filename =>
                {
                    string[] lines = File.ReadAllLines(filename);
                    return new Compra
                    {
                        Filename = filename,
                        Title = lines[0],
                        TicketCount = int.Parse(lines[1]),
                        TicketPrice = decimal.Parse(lines[2])
                    };
                });


            foreach (Compra purchase in purchases)
            {
                Compras.Add(purchase);
            }
        }

    }
}
