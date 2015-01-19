using Microsoft.Practices.Prism.UnityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;

namespace GengrAdmin
{
    public class GengrAdminBootstrapper: UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            Type initialModule = typeof(InitialModule.InitialModule);
            ModuleCatalog.AddModule(new ModuleInfo() 
            {
                ModuleName= initialModule.Name,
                ModuleType=initialModule.AssemblyQualifiedName,
                InitializationMode=InitializationMode.WhenAvailable
            });
        }
    }
}
