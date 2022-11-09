using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils;
using System.Drawing;
using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyDateEdit:DateEdit,IStatusBarKisaYol
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            // Tarih alanında null değer olmaması lazım.En kötü günün tarihi olması lazım
            Properties.AllowNullInput = DefaultBoolean.False;
            // tarih alanlarında textlerin ortada yazılması
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            // günü yazınca ay kısmına,ay kısmını yazınca otomatik yıl kısmına geçmesi için
            Properties.Mask.MaskType =MaskType.DateTimeAdvancingCaret;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; } = "Tarih Seç";

        public string StatusBarAciklama { get; set; }
    }
}
