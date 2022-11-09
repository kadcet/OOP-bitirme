using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    // parasal ve rakamsal değerlerin girileceği bi kontrol tanımlaması olacak
    
    [ToolboxItem(true)]
    public class MyCalcEdit : CalcEdit,IStatusBarKisaYol
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            // alan null olmayacak sıfır yada sıfırdan büyük veya küçük rakam olacak
            Properties.AllowNullInput = DefaultBoolean.False;
            // rakamı maskelememeiz lazım. nokta ve kuruşta virgül
            // n2 tutarda 3 rakamda nokta,kuruşta 2 hane
            Properties.EditMask = "n2";
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinesi";

        public string StatusBarAciklama { get; set; }
    }
}
