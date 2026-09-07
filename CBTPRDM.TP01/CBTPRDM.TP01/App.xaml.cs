using Microsoft.Extensions.DependencyInjection;

namespace CBTPRDM.TP01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            window.Width = 450;
            window.Height = 844;

            return window;
        }
    }
}