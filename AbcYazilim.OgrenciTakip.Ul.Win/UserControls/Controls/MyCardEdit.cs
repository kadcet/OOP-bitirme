using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    // kredi kartı numarası formatı yapıcaz

    public class MyCardEdit:MyTextEdit
    {
        
        [ToolboxItem(true)]

        public MyCardEdit()
        {
            //kart nosu textin ortasında yazsın
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;

            // kart no formatı 4 er haneli 4 alan 16 haneli toplam aralara - atacak
            // önce maske tipi belirlenecek
            Properties.Mask.MaskType = MaskType.Regular;

            //maske tanımlanacak  d rakamı ? o rakamın boş girilebileceğini temsil ediyo
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";
            // girilmeyen rakamı herhangi bişeye tamamlama ne girildiyse o
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Kart No Giriniz.";
            
        }
    }
}
