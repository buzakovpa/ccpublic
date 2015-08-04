using System;
using CC.EF;

namespace CC.BUSINESS
{

    public abstract class BaseEntityService : IDisposable
    {
        protected AppContext Context;

        protected BaseEntityService(AppContext context)
        {
            Context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) {
                if (Context != null) {
                    Context.Dispose();
                    Context = null;
                }
            }
        }
    }

}