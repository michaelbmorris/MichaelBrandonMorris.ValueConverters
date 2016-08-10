using System;
using System.Globalization;
using System.Windows.Data;

namespace MichaelBrandonMorris.ValueConverters
{
    /// <summary>
    ///     Inverts a Boolean value.
    /// </summary>
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(
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

            return !(bool) value;
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

            return !(bool) value;
        }
    }
}