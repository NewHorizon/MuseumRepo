using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Modules.SpecimentsInfoModule
{
    class SpecimentsInfoModule
    {

    }

    /*/// <summary>
    /// Модуль для работы с абитуриентами и информацией о них
    /// </summary>
    [ModuleExport(typeof(AbiturientsInfoModule))]
    public class AbiturientsInfoModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        public void Initialize()
        {
            this.RegionManager.RegisterViewWithRegion(RegionNames.MainContentRegion, typeof(TableView));
            this.RegionManager.RegisterViewWithRegion(RegionNames.MainContentRegion, typeof(AnketaView));
            //this.RegionManager.RegisterViewWithRegion(RegionNames.MainContentRegion, typeof(IKonkursRowTable));                                     
        }
    }*/
}
