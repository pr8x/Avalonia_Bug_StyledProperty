using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaSandbox
{
    public class App : Application
    {

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
