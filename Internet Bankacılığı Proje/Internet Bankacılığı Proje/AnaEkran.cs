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

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesabımıGüncelle hesabımıGüncelle = new HesabımıGüncelle();
            hesabımıGüncelle.MdiParent = this;
            hesabımıGüncelle.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(hesabımıGüncelle);
            hesabımıGüncelle.Show();
        }

        private void vadeliHesapBaşvuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VadeliHesapBaşvuru vadeliHesapBaşvuru = new VadeliHesapBaşvuru();
            vadeliHesapBaşvuru.MdiParent = this;
            vadeliHesapBaşvuru.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(vadeliHesapBaşvuru);
            vadeliHesapBaşvuru.Show();
        }

        private void vadesizHesaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VadesizHesaplar vadesizHesaplar = new VadesizHesaplar();
            vadesizHesaplar.MdiParent = this;
            vadesizHesaplar.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(vadesizHesaplar);
            vadesizHesaplar.Show();
        }

        private void vadeliHesaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VadeliHesaplar vadeliHesaplar = new VadeliHesaplar();
            vadeliHesaplar.MdiParent = this;
            vadeliHesaplar.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(vadeliHesaplar);
            vadeliHesaplar.Show();
        }

        private void krediKartıBorçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediKartıBorç krediKartıBorç = new KrediKartıBorç();
            krediKartıBorç.MdiParent = this;
            krediKartıBorç.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(krediKartıBorç);
            krediKartıBorç.Show();
        }

        private void krediKartıÖdemesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediKartıÖdemesi krediKartıÖdemesi = new KrediKartıÖdemesi();
            krediKartıÖdemesi.MdiParent = this;
            krediKartıÖdemesi.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(krediKartıÖdemesi);
            krediKartıÖdemesi.Show();
        }

        private void krediHesaplarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediHesaplarım krediHesaplarım = new KrediHesaplarım();
            krediHesaplarım.MdiParent = this;
            krediHesaplarım.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(krediHesaplarım);
            krediHesaplarım.Show();
        }

        private void krediFiyatVeOranlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediFiyatVeOranlar krediFiyatVeOranlar = new KrediFiyatVeOranlar();
            krediFiyatVeOranlar.MdiParent = this;
            krediFiyatVeOranlar.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(krediFiyatVeOranlar);
            krediFiyatVeOranlar.Show();
        }

        private void hesaplarArasıParaTransferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesaplarArasıParaTransferi hesaplarArasıParaTransferi = new HesaplarArasıParaTransferi();
            hesaplarArasıParaTransferi.MdiParent = this;
            hesaplarArasıParaTransferi.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(hesaplarArasıParaTransferi);
            hesaplarArasıParaTransferi.Show();
        }

        private void başkaHesabaHavaleEFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaşkaHesabaHavaleEFT başkaHesabaHavaleEFT = new BaşkaHesabaHavaleEFT();
            başkaHesabaHavaleEFT.MdiParent = this;
            başkaHesabaHavaleEFT.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(başkaHesabaHavaleEFT);
            başkaHesabaHavaleEFT.Show();
        }

        private void krediKartıGöstermeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void krediKartıBorçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KrediKartlarımKrediBorç krediKartlarımKrediBorç = new KrediKartlarımKrediBorç();
            krediKartlarımKrediBorç.MdiParent = this;
            krediKartlarımKrediBorç.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(krediKartlarımKrediBorç);
            krediKartlarımKrediBorç.Show();
        }

        private void krediKartıLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediKartlarımKrediLimit krediKartlarımKrediLimit = new KrediKartlarımKrediLimit();
            krediKartlarımKrediLimit.MdiParent = this;
            krediKartlarımKrediLimit.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(krediKartlarımKrediLimit);
            krediKartlarımKrediLimit.Show();
        }

        private void bankaKartıGöstermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankaKartlarGösterme bankaKartlarGösterme = new BankaKartlarGösterme();
            bankaKartlarGösterme.MdiParent = this;
            bankaKartlarGösterme.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(bankaKartlarGösterme);
            bankaKartlarGösterme.Show();
        }

        private void bankaKartıBakyieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankaKartlarGösterme bankaKartlarGösterme = new BankaKartlarGösterme();
            bankaKartlarGösterme.MdiParent = this;
            bankaKartlarGösterme.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(bankaKartlarGösterme);
            bankaKartlarGösterme.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Şifreİşlemleri şifreİşlemleri = new Şifreİşlemleri();
            şifreİşlemleri.MdiParent = this;
            şifreİşlemleri.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(şifreİşlemleri);
            şifreİşlemleri.Show();
        }
    }
}
