using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GengrAdmin.Common.Base
{
    public class BaseModule:IModule
    {
        #region Private Members
        IUnityContainer m_container;
        IEventAggregator m_eventAggregator;
        IRegionManager m_regionManager;
        #endregion

        public BaseModule()
        {
            //m_container = U
            //m_regionManager = regionManager;
            //m_eventAggregator = eventAggregator;
        }     

        #region Properties
        public IUnityContainer Container
        {
            get { return m_container; }
        }
        public IRegionManager RegionManager
        {
            get { return m_regionManager; }
        }
        public IEventAggregator EventAggregator
        {
            get { return m_eventAggregator; }
        }
        #endregion
           
        public virtual void Initialize()
        { 
        }
    }
}
