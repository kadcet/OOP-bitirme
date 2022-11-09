using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Ilce:BaseEntityDurum
    {
        public string IlceAdi { get; set; }

        public long IlId { get; set; }  // ilçenin ile bağlı olduğunu söyledik burda
        // Il ile Ilce birleştirip Il e bağlıyo. ismin sonunada Id ekliyor.onu burda biz yaptık

        public string Aciklama { get; set; }


        public Il Il { get; set; }    /// ilçe ile bağlı
    }
}
