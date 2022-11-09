using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyTcKimlikNoTextEdit:MyTextEdit
    {
        public MyTcKimlikNoTextEdit()
        {
            //maskeleme yapıcaz.textedit in ortasına yazılsın
            Properties.Appearance.TextOptions.HAlignment =HorzAlignment.Center;
            //kendi ayarlamamızı yapıcaz o yüzden regular yaptık
            Properties.Mask.MaskType = MaskType.Regular;
            // maskemizi tanımlıycaaz
            Properties.Mask.EditMask = @"\d?\d?\d? \d?\d?\d? \d?\d?\d? \d?\d?";

            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Tc Kimlik No Giriniz.";
        }
    }
}
