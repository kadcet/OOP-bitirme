namespace Cdr.Presentation.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // bu kod rantime yani �al��ma zaman�nda �al��acak. �uan bi�ey de�i�medi
            label1.Text = "Kod taraf�nda de�i�tirdim.";
        }

       

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = $"butona {count} kez t�kland�";
        }
    }
}