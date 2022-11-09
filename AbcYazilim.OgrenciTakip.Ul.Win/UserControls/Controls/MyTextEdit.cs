using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    
    [ToolboxItem(true)]
    public class MyTextEdit:TextEdit,IStatusBarAciklama
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            // girilen karakter sayısını 50 ile sınırlandırılacak
            Properties.MaxLength = 50;
                        
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get ; set ; }
    }
}
