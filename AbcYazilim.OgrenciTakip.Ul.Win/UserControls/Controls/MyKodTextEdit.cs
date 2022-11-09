using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyKodTextEdit:MyTextEdit
    {
        public MyKodTextEdit()
        {
            // sabit backcolor vericez
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            // kodların texbox ın ortasında yazılması
            Properties.Appearance.TextOptions.HAlignment =HorzAlignment.Center;
            // kod alanlarını 20 karakterle sınırlandırıcaz
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod Giriniz";
        }
    }
}
