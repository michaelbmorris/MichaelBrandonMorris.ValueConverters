using System;
using System.Globalization;
using System.Windows.Data;

namespace MichaelBrandonMorris.ValueConverters
{
    /// <summary>
    ///     Class InverseBooleanConverter.
    /// </summary>
    /// <seealso cref="IValueConverter" />
    /// TODO Edit XML Comment Template for InverseBooleanConverter
    public class InverseBooleanConverter : IValueConverter
    {
        /// <summary>
        ///     Converts a value.
        /// </summary>
        /// <param name="value">
        ///     The value produced by the binding
        ///     source.
        /// </param>
        /// <param name="targetType">
        ///     The type of the binding target
        ///     property.
        /// </param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        ///     A converted value. If the method returns null, the
        ///     valid null value is used.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        ///     The target must
        ///     be a bool.
        /// </exception>
        /// TODO Edit XML Comment Template for Convert
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

            return value != null && !(bool) value;
        }

        /// <summary>
        ///     Converts a value.
        /// </summary>
        /// <param name="value">
        ///     The value that is produced by the
        ///     binding target.
        /// </param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        ///     A converted value. If the method returns null, the
        ///     valid null value is used.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        ///     The target must
        ///     be a bool.
        /// </exception>
        /// TODO Edit XML Comment Template for ConvertBack
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

            return value != null && !(bool) value;
        }
    }
}