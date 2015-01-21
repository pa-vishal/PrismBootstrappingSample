using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Configuration;


namespace PrismSample
{
    public class TheBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var moduleCatelog = new DirectoryModuleCatalog();
            moduleCatelog.ModulePath = ConfigurationManager.AppSettings["PathToModules"];
            
            return moduleCatelog;
        }
    }
}
