using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;

namespace AbcYazilim.OgrenciTakip.Model.Entities.Base

    // Okulkartından yapılan girişlerin entity leri burası  OkulAdı,İl,İlçe vb
{
    public class BaseEntity:IBaseEntity
    {
        // neden long yaptık. burdaki ıd yi kendimiz oluşturup databaseye göndericez
        public long Id { get; set; }

        public string Kod { get; set; }
    }
}
