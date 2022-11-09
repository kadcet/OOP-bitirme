using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyTelefonNoTextEdit:MyTextEdit
    {
        public MyTelefonNoTextEdit()
        {
            // ortalansın
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"(\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Telefon No Giriniz";

        }
    }
}
