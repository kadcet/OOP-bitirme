using AbcYazilim.OgrenciTakip.Data.Contexts;
using System.Data.Entity.Migrations;

namespace AbcYazilim.OgrenciTakip.Data.OgrenciTakipMigration
{
    public class Configuration:DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            // migration işlemlerini otomatik yap
            AutomaticMigrationsEnabled = true;

            // migration yaparken  veri kaybı olacaksa buna izin veriyoruz.            
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
