using Caliburn.Micro;
using FrameApplication.ViewModels;
using System.Windows;

namespace FrameApplication.Views
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}