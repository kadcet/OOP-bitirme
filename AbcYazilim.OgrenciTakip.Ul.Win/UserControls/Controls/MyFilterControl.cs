using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyFilterControl:FilterControl,IStatusBarAciklama
    {
        public MyFilterControl()
        {
            // gruplama yaparken ıcon resmi
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
