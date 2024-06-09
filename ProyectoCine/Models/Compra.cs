using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Models
{
    public class Compra:Pelicula, INotifyPropertyChanged
    {
        private int _ticketCount;
        public int TicketCount
        {
            get => _ticketCount;
            set
            {
                if (_ticketCount != value)
                {
                    _ticketCount = value;
                    OnPropertyChanged(nameof(TicketCount));
                    OnPropertyChanged(nameof(TotalPrice)); // También actualiza el precio total
                }
            }
        }

        private decimal _ticketPrice;
        public decimal TicketPrice
        {
            get => _ticketPrice;
            set
            {
                if (_ticketPrice != value)
                {
                    _ticketPrice = value;
                    OnPropertyChanged(nameof(TicketPrice));
                    OnPropertyChanged(nameof(TotalPrice)); // También actualiza el precio total
                }
            }
        }

        public decimal TotalPrice => TicketCount * TicketPrice;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}