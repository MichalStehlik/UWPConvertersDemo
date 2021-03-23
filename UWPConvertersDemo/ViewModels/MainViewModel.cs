using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UWPConvertersDemo.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private int _cityIndex = 0;
        // názvy obrázků vložených mezi Assety
        public List<string> Assets { get; } = new List<string> { "Amsterdam", "Bergen", "Budapest", "Copenhagen", "Dubrovnik", "Edinburgh", "London", "NewYork", "Paris", "Prague", "Rome", "StPetersburg", "Vienna" };
        // názvy měst
        public List<string> Names { get; } = new List<string> { "Amsterdam", "Bergen", "Budapešť", "Kodaň", "Dubrovnik", "Edinburgh", "Londýn", "New York", "Paříž", "Praha", "Řím", "Petrohrad", "Vídeň" };
        public int CityIndex
        {
            get
            {
                return _cityIndex;
            }
            set
            {
                _cityIndex = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
