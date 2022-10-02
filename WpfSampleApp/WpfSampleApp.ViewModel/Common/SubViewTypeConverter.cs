using System.Globalization;
using System.Windows;
using System.Windows.Data;
using WpfSampleApp.Interface.Main;

namespace WpfSampleApp.ViewModel.Common
{
    public class SubViewTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SubViewType type = (SubViewType)value;
            return type.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string? strValue = value as string;
            SubViewType type;
            if (SubViewType.TryParse(strValue, out type))
            {
                return type;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
