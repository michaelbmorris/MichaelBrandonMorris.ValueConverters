using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MichaelBrandonMorris.ValueConverters
{
    /// <summary>
    ///     Unlike the built-in <see cref="BooleanToVisibilityConverter" />, 
    ///     which uses <see cref="Visibility.Collapsed" /> as the value for 
    ///     false, this converter uses <see cref="Visibility.Hidden" />.
    /// </summary>
    public class BooleanToVisibilityHiddenConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (targetType != typeof(Visibility))
            {
                throw new InvalidOperationException(
                    "The target must be a visibility");
            }

            var isVisible = (bool) value;
            return isVisible ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (targetType != typeof(bool))
            {
                throw new InvalidOperationException(
                    "The target must be a bool.");
            }

            var visibility = (Visibility) value;
            return visibility == Visibility.Visible;
        }
    }
}