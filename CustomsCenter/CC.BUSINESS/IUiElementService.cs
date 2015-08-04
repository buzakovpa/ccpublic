using System;
using System.Collections.Generic;
using CC.MODELS;

namespace CC.BUSINESS
{

    public interface IUiElementService : IDisposable
    {
        UiElement Find(int id);
        UiElement Find(UiElement.Aliass alias);
        List<UiElement> GetAll();

        UiElement Create(UiElement element);
        UiElement Update(UiElement element);
        void Remove(int id);
    }

}