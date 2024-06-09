using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Models
{
    internal class Historial
    {
           public ObservableCollection<Compra> Compras { get; set; } = new ObservableCollection<Compra>();
           /*public Compra() =>
               LoadNotes();

           public void LoadNotes()
           {
               Compras.Clear();

               // Get the folder where the notes are stored.
               string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            IEnumerable<Compra> notes = Directory

                                        // Select the file names from the directory
                                        .EnumerateFiles(appDataPath, "*.notes.txt")

                                        // Each file name is used to create a new Note
                                        .Select(filename => new Compra()
                                        {
                                            Title = filename,
                                            TotalPrice = filename

                                        });

                                          

               // Add each note into the ObservableCollection
               foreach (Compra note in notes)
                   Compras.Add(note);
           }

       }*/
    }
}
