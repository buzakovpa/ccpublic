using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS
{

    internal class UiElementService : BaseEntityService, IUiElementService
    {
        public UiElementService(AppContext context) : base(context)
        {
        }

        public UiElement Find(int id)
        {
            return Context.UiElements.Find(id);
        }

        public UiElement Find(UiElement.Aliass alias)
        {
            return Context.UiElements.AsNoTracking().FirstOrDefault(a => a.Alias == (int)alias && a.Show);
        }

        public List<UiElement> GetAll()
        {
            return Context.UiElements.ToList();
        }

        public UiElement Create(UiElement element)
        {
            var entity = Context.UiElements.Add(element);
            Context.SaveChanges();

            return entity;
        }

        public UiElement Update(UiElement element)
        {
            var entity = Context.UiElements.Find(element.UiElementId);
            if (entity == null) {
                throw new ObjectNotFoundException();
            }

            entity.Value = element.Value;
            entity.Show = element.Show;

            Context.SaveChanges();

            return entity;
        }

        public void Remove(int id)
        {
            var entity = Context.UiElements.Find(id);
            if (entity == null) {
                throw new ObjectNotFoundException();
            }

            Context.UiElements.Remove(entity);
            Context.SaveChanges();
        }

    }

}