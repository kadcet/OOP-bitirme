using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
   [ToolboxItem(true)]
    
    public class MyPictureEdit:PictureEdit,IStatusBarKisaYol
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            // resim olmadığında ekranda yazı yazsın o yazının rengi
            Properties.Appearance.ForeColor = Color.Maroon;
            // resim silindiği zaman ne yazsın
            Properties.NullText = "Resim Yok";
            // resmşin size modunu ayarlıycaz
            Properties.SizeMode = PictureSizeMode.Stretch;
            // resmin üzerine ağ tıklayınca menü geliyor. Gelmesin.gizleyelim
            Properties.ShowMenu = false;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; }

        public string StatusBarAciklama { get; set; }
    }
}
