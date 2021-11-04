using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace MemeMaker.Convertidores
{
    public class CheckBoxABorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? cheked = value as bool?;
            Brush resultado = Brushes.Transparent;

            if (cheked == true)
            {
                resultado = Brushes.Black;
            }

            return resultado;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
