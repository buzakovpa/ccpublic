using Ninject.Modules;

namespace CC.BUSINESS
{

    public class BusinessNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUiElementService>().To<UiElementService>();
        }
    }

}