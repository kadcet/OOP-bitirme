using System.Data.Entity;
using System.Data.Entity.Migrations;

#region BaseDbContext aşaması
// bunu dbcontext ten implemente ediyoruz
// birden fazla context te implemente edileceği için generic tip yapıyoruz.
// 2 parametre veriyoruz. birincisi TContext => ogrencitakipcontext yada ogrencitakipgenelcontext
// ikincisi yapacağımız migration işlemlerindeki configuration ayarlarını takip edeceğimiz TConfiguration
// where ile tiplerini belirliyoruz. TContext dbcontext tir ve TConfiguration bir DbMigrationsConfiguration dır. aynı zamanda bu bir Tcontext istiyor. Ve DbMigrationsConfiguration new le insınsını alman lazım
#endregion

namespace AbcYazilim.OgrenciTakip.Data.Contexts
{
    public class BaseDbContext<TContext, TConfiguration> : DbContext where TContext : DbContext where TConfiguration : DbMigrationsConfiguration<TContext>, new()
    {
        private static string _nameOrConnectionString = typeof(TContext).Name;

        #region Not connectionstring
        // default ctor oluşturduk. Base sine connectionstring imizi göndermemiz lazım.
        // _nameOrConnectionString diye bir parametre göndermemiz lazım
        // private string yapıcaz ctor üstünde. Null olmaması lazım.default değer atamamız lazım.
        // burdan connection string in name sini gönderiyoruz.
        // bunu yönetim modülünde database oluşturuken ve silerken 2 kere  kullanıcaz.başka bi yerde kullanmıcaz.diğer tüm işlerde aşşağıdaki ctor u kullanıcaz
        #endregion
        public BaseDbContext() : base(_nameOrConnectionString) { }

        // bizim ağırlıklı kullanacağımız ctor burası olacak. burda Connectionstring in kendisini göndericez
        public BaseDbContext(string connectionString):base(connectionString)
        {
            // karşılaştırma yapacak.değişiklik varsa tabloyu şu context yoluyla şu konfigürasyonla güncelle
            // MigrateDatabaseToLatestVersion  databaseyi en son sürüme versiyon yap demek
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext, TConfiguration>());
            _nameOrConnectionString = connectionString;
        }
    }
}
