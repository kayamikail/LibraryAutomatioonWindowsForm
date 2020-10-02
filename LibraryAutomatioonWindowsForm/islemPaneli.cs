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
    public partial class islemPaneli : Form
    {
       
        public islemPaneli()
        {
            InitializeComponent();
        }
        LibraryAutomationEntities db = new LibraryAutomationEntities();
        private void islemPaneli_Load(object sender, EventArgs e)
        {
            btnEkle.Visible = false;
            btnGuncelle.Visible = false;
            btnSil.Visible = false;
        }

        private void btnKulanicilar_Click(object sender, EventArgs e)
        {
            if (btnEkle.Visible == false)
            {
                btnEkle.Visible = true;
                btnGuncelle.Visible = true;
                btnSil.Visible = true;
            }
            else
            {
                btnEkle.Visible = false;
                btnGuncelle.Visible = false;
                btnSil.Visible = false;
            }
           
        }
        
    }
}
