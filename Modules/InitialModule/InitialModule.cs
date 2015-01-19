using GengrAdmin.Common.Constants;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialModule
{
    public class InitialModule: IModule
    {
        IUnityContainer m_container;
        IRegionManager m_regionManager;

        public InitialModule(IUnityContainer container, IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            m_container = container;
            m_regionManager = regionManager;
        }

        
        public void Initialize()
        {
            m_regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof(ToolbarView));
            m_regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ContentView));
        }
    }
}
