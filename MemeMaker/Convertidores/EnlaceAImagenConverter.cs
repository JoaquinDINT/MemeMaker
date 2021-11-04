using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MemeMaker.Convertidores
{
    public class EnlaceAImagenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string enlaceString = value.ToString();
            BitmapImage source = new BitmapImage(new Uri("assets/2560.jpg", UriKind.Relative));

            if (Uri.TryCreate(enlaceString, UriKind.Absolute, out Uri enlaceUri))
            {
                source = new BitmapImage(enlaceUri);
            }

            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
