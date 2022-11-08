namespace Cdr.Presentation.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // bu kod rantime yani çalýþma zamanýnda çalýþacak. þuan biþey deðiþmedi
            label1.Text = "Kod tarafýnda deðiþtirdim.";
        }

       

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = $"butona {count} kez týklandý";
        }
    }
}