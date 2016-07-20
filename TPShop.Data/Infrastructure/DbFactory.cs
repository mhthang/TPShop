using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPShop.Data.Infrastructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        TPShopDbContext dbcontext;
        public TPShopDbContext Init()
        {
            return dbcontext ?? (dbcontext = new TPShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbcontext!=null)
            {
                dbcontext.Dispose();
            }
        }
    }
}
