using MHRSSistemi.UI.Models;

namespace MHRSSistemi.UI
{
    public partial class Form2 : Form
    {
        private Bolum[] bolumDizisi;
        public Form2(Bolum[] bolumDizisi)
        {
            InitializeComponent();
            this.bolumDizisi = bolumDizisi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbBolumler.DataSource = bolumDizisi;
        }

        
    }
}
