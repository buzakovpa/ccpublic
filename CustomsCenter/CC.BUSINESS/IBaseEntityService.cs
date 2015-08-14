using System.Collections.Generic;

namespace CC.BUSINESS
{

    public interface IBaseEntityService<TModel>
    {
        List<TModel> GetAll( );

        TModel Find(int id);
        TModel Create(TModel newEntity);
        TModel Update(TModel entity);

        void Remove(int id);
    }

}