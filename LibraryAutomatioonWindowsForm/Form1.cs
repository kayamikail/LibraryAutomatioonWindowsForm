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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string loginAd = txtAd.Text;
            string loginSifre = txtSifre.Text;

            if (loginAd.Equals("Admin") && loginSifre.Equals("123"))
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı veya şifre hatalı!!!");
            }
        }
    }
}
