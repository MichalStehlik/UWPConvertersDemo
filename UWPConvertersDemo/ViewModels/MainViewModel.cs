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
        //private string _cityName;

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
                //CityName = _names[_cityIndex];
            }
        }
        /*
        public string CityName
        {
            get
            {
                return _cityName;
            }
            set
            {
                _cityName = value;
                NotifyPropertyChanged("CityName");
            }
        }
        */

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
