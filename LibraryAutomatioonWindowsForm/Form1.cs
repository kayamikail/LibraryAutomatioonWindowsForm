using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomatioonWindowsForm
{
    public partial class Form1 : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string loginAd = txtAd.Text;
            string loginSifre = txtSifre.Text;

            var personel = db.PERSONELLER.Where(x => x.PERSONELAD.Equals(loginAd) && x.PERSONELSIFRE.Equals(loginSifre)).FirstOrDefault();

            if (personel == null)
            {
                MessageBox.Show("Kullanıcı veya şifre hatalı!!!");
            }
            else
            {
               // MessageBox.Show("Başarılı");
                islemPaneli panel = new islemPaneli();
                panel.Show();
                this.Hide();
            }

           

            
        }

       
    }
}
