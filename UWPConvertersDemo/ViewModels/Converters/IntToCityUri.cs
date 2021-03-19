using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPConvertersDemo.ViewModels.Converters
{
    class IntToCityUri: IValueConverter
    {
        public List<string> Assets { get; } = new List<string> { "Amsterdam", "Bergen", "Budapest", "Copenhagen", "Dubrovnik", "Edinburgh", "London", "NewYork", "Paris", "Prague", "Rome", "StPetersburg", "Vienna" };

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is int)
            {
                int cislo = ((int)value) % Assets.Count;
                return new System.Uri("ms-appx:///Assets/Photos/" + Assets[cislo] + ".jpg");
            }
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is string && targetType == typeof(int))
            {
                int found = Assets.IndexOf(value as string);
                if (found >= 0)
                    return found;
            }
            return value.ToString();
        }
    }
}
