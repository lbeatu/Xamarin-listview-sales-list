using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppObject.Data
{
    public class ImageSourceConverter : IValueConverter

    {/*
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {//attıgımız resimleri portable klasörunden okumamızı saglar.
            return ImageSource.FromResource("AppObject.images."+(value ?? ""));//ilk calscak method
        }
        */
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource("AppObject.images." + (value ?? ""));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException(); // ikinci method
        }
    }
}

/*
 * 
 * 
         public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource("Ders3.images." + (value ?? ""));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        */
