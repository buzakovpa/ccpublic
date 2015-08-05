using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS
{

    internal class UiElementService : BaseEntityService<UiElement>, IUiElementService
    {
        public UiElementService(AppContext context) : base(context)
        {
        }

        public UiElement Find(UiElement.Aliass alias)
        {
            return DbSet.AsNoTracking().FirstOrDefault(a => a.Alias == (int) alias && a.Show);
        }

        public List<UiElement> GetAll()
        {
            return DbSet.ToList();
        }
    }

}