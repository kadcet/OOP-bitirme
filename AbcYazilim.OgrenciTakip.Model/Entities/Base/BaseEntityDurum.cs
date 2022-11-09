namespace AbcYazilim.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntityDurum:BaseEntity
    {

        //  aktif pasif butonu olanlarda bunu kullanıcaz. olmayanlarda baseentity i kullanıcaz
        
        public bool Durum { get; set; } = true;
    }
}
