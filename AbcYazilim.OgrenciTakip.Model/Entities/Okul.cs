using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Okul:BaseEntityDurum  // durum (aktif-pasif)) olduğu için burdan implemente ettik
    {
        public string OkulAdi { get; set; }

        public long IlId { get; set; }

        public long IlceId { get; set; }

        public string Aciklama { get; set; }

        public Il Il { get; set; }

        public Ilce Ilce { get; set; }
    }
}
