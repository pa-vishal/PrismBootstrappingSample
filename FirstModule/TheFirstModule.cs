using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace FirstModule
{
    public class TheFirstModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IServiceLocator _serviceLocator;

        public TheFirstModule(IRegionManager regionManager, IServiceLocator serviceLocator)
        {
            _regionManager = regionManager;
            _serviceLocator = serviceLocator;
       }
        #region IModule Members

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", () => _serviceLocator.GetInstance<FillMainRegion>());            
        }

        #endregion
    }
}
