using AbcYazilim.OgrenciTakip.Ul.Win.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;

namespace AbcYazilim.OgrenciTakip.Ul.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyButtonEdit : ButtonEdit, IStatusBarKisaYol
    {
        

        public MyButtonEdit()
        {
            // yazılabilir olmaması lazım.Sadece seçilen gelmesi lazım
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

            // focuslanma olunca arka plan rengi değişecek
            Properties.AppearanceFocused.BackColor = Color.LightCyan;


        }

        // entere basınca bir sonraki kontrole index sırasına göre fokuslanacak
        public override bool EnterMoveNextControl { get; set; } = true;

        // kontroler arası dolaştığımızda altta açıklamalar geliyor.button lu bişeyde de ayrıca açıklama geliyor
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; }


        #region Events

        private long? _id;

        [Browsable(false)]

        public long? Id
        {
            get => _id;
            set
            {
                var oldValue = _id;
                var newValue = value;

                if (newValue == oldValue) return;

                _id = value;

                IdChanged(this, new IdChangedeventArgs(oldValue, newValue));
            }
        }


        public event EventHandler<IdChangedeventArgs> IdChanged = delegate { }; 
        #endregion
    }

    public class IdChangedeventArgs : EventArgs
    {
        public IdChangedeventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }
        public long? NewValue { get; }
    }
}
