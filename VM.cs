using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using Avalonia.Data.Converters;
using Avalonia.Diagnostics.ViewModels;

namespace AvaloniaSandbox
{
    class CC : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class VM : ViewModelBase
    {
        public int Foo { get; } = 42;

        public VM()
        {

        }

    }
}
