using Prism.Ioc;
using Prism.Modularity;


namespace Xap.Data
{
    public class DataModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
           // containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
