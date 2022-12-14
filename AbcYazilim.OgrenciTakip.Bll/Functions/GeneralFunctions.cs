using AbcYazilim.Dal.Base;
using AbcYazilim.Dal.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.OgrenciTakip.Bll.Functions
{
    public class GeneralFunctions
    {
        public static string GetConnectionString()
        {
            return
                ConfigurationManager.ConnectionStrings["OgrenciTakipContext"].ConnectionString;
        }
        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }
        public static void CreateUnitOfWork<T,TContext>(ref IUnitOfWork<T> uow) where T:class,IBaseEntity where TContext:DbContext
        {
            uow?.Dispose();
            uow = new UnitOfWork<T>(CreateContext<TContext>());
        }
    }
}
