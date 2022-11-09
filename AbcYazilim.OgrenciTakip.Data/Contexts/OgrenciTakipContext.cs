using AbcYazilim.OgrenciTakip.Data.OgrenciTakipMigration;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AbcYazilim.OgrenciTakip.Data.Contexts
// data class library e ADO.NET entity Data Model diye proje ekledik.empty code first model i se�tik.
// Yap�c� metodun base sine context ismini g�nderdi.�smi otomatik olarak verdi�imiz ismi ald�
// app.confing dosyas�n� siliyoruz. Win projesinden okuyacak.
// 
// biz bunu kendimizin olu�turaca�� basedbcontext en implemente edicez.basedbcontex i dbcontext ten imp edicez
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
            // tablo isimleri �o�ulla�t�rmas�n� istemiyoruz

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); 
            // bire �ok ili�kili tablolar�n birinde bi�ey silinirse. yani il silinirse ba�l� olan il�eler silinir. bunu engelliyoruz
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            // �oka �ok ili�ki i�in. engelliyoruz.
        }

        public DbSet<Il> Il { get; set; }

        public DbSet<Ilce> Ilce { get; set; }

        public DbSet<Okul> Okul { get; set; }
    }

}