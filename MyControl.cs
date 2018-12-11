using System;
using System.Collections.Generic;
using System.Text;
using Avalonia;
using Avalonia.Controls.Primitives;

namespace AvaloniaSandbox
{
    public class MyControl : TemplatedControl
    {

        public static readonly StyledProperty<string> MyPropertyProperty
            = AvaloniaProperty.Register<MyControl, string>(nameof(MyProperty));

        public string MyProperty
        {
            get => GetValue(MyPropertyProperty);
            set => SetValue(MyPropertyProperty, value);
        }

    }
}
