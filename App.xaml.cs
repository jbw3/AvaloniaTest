using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaMVVMTest
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}