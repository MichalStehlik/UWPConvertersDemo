using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPConvertersDemo.ViewModels.Converters
{
    class IntToCityName : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is int @int && targetType == typeof(string))
            {
                int cislo = @int % Names.Count;
                return Names[cislo];
            }
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is string && targetType == typeof(int))
            {
                int found = Names.IndexOf(value as string);
                if (found >= 0)
                    return found;
            }
            return value.ToString();
        }

        public Binding Data { get; set; }

        public List<string> Names { get; set; } = new List<string> { "Amsterdam", "Bergen", "Budapest", "Kodaň", "Dubrovnik", "Edinburgh", "Londýn", "New York", "Paris", "Prague", "Rome", "St. Petersburg", "Vienna" };
    }
}
