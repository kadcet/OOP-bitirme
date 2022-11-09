using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MySimpleButton:SimpleButton,IStatusBarAciklama
    {
        public MySimpleButton()
        {
            // yazı tipi rengi standart
            Appearance.ForeColor = Color.Maroon;

        }

        public string StatusBarAciklama { get ; set; }
    }
}
