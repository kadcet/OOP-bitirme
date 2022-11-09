using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyCheckEdit:CheckEdit,IStatusBarAciklama
    {
        public MyCheckEdit()
        {
            // formun rengi neyse o kalmasını istiyoruz
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}
