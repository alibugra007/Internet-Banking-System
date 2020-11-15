using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Bankacılığı_Proje
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aadamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            YeniHesapAc yeniHesapAc = new YeniHesapAc();
            yeniHesapAc.MdiParent = this;
            yeniHesapAc.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(yeniHesapAc);
            yeniHesapAc.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void değilsnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesabiSil hesabiSil = new HesabiSil();
            hesabiSil.MdiParent = this;
            hesabiSil.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(hesabiSil);
            hesabiSil.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
