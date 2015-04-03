using System.Windows;

namespace Caliburn.Micro.Hello
{
    public class HelloBootstrapper : BootstrapperBase
    {
        public HelloBootstrapper()
        {
            //This call is required.
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
