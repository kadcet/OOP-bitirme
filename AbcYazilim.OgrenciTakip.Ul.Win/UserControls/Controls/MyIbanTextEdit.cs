using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyIbanTextEdit:MyTextEdit
    {
        public MyIbanTextEdit()
        {
            Properties.Mask.MaskType =MaskType.Regular;
            // maske tanımlıycaz
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            // bu şekilde bırakırsak  yazmaya başlayınca bütün rakamlara sıfır yazıyo. Devredışı bırakıcaz
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Iban No Giriniz.";
        }
    }
}
