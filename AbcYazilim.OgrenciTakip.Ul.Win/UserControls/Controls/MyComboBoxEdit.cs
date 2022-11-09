using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyComboBoxEdit:ComboBoxEdit,IStatusBarKisaYol
    {
        public MyComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            // üzerine yazı yazılmasın
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; }

        public string StatusBarAciklama { get; set; }
    }
}
