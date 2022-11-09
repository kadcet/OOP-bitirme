using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    
    [ToolboxItem(true)]

    public class MySpinEdit:SpinEdit,IStatusBarAciklama
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            // alanın boş geçilmesini istemiyoruz
            Properties.AllowNullInput = DefaultBoolean.False;

            // girilen değeri basamaklanmasını istemiyoruz. noktalı ve kuruşlu gelmesin
            Properties.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
