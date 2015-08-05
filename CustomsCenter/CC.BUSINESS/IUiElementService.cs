using System;
using CC.MODELS;

namespace CC.BUSINESS
{

    public interface IUiElementService : IBaseEntityService<UiElement>, IDisposable
    {
        UiElement Find(UiElement.Aliass alias);
        
    }

}