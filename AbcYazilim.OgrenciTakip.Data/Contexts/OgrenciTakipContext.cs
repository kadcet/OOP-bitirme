using AbcYazilim.OgrenciTakip.Data.OgrenciTakipMigration;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AbcYazilim.OgrenciTakip.Data.Contexts
// data class library e ADO.NET entity Data Model diye proje ekledik.empty code first model i seçtik.
// Yapýcý metodun base sine context ismini gönderdi.Ýsmi otomatik olarak verdiðimiz ismi aldý
// app.confing dosyasýný siliyoruz. Win projesinden okuyacak.
// 
// biz bunu kendimizin oluþturacaðý basedbcontext en implemente edicez.basedbcontex i dbcontext ten imp edicez
{
    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext, Configuration>
    {
        public OgrenciTakipContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public OgrenciTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            // tablo isimleri çoðullaþtýrmasýný istemiyoruz

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); 
            // bire çok iliþkili tablolarýn birinde biþey silinirse. yani il silinirse baðlý olan ilçeler silinir. bunu engelliyoruz
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            // çoka çok iliþki için. engelliyoruz.
        }

        public DbSet<Il> Il { get; set; }

        public DbSet<Ilce> Ilce { get; set; }

        public DbSet<Okul> Okul { get; set; }
    }

}