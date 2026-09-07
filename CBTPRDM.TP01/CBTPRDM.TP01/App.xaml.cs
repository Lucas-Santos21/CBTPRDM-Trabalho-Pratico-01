//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

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