using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = false;
            personnels1.Hide();
            certificatEssai1.Hide();
            certificatRobinet1.Hide();
            formDashboard1.BringToFront();
            formDashboard1.Show();
        }


        private void Certificats_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                Bitmap bitmap2 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\collapse_arrow_32px.png");
                Certificats.Iconimage_right = bitmap2;
                panel5.Visible = true;
            }
            else
            {
                Bitmap bitmap1 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\expand_arrow_32px.png");
                Certificats.Iconimage_right = bitmap1;
                panel5.Visible = false;
            }
        }

        private void Rapports_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == false)
            {
                Bitmap bitmap3 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\collapse_arrow_32px1.png");
                Rapports.Iconimage_right = bitmap3;
                panel6.Visible = true;
            }
            else
            {
                Bitmap bitmap4 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\expand_arrow_32px1.png");
                Rapports.Iconimage_right = bitmap4;
                panel6.Visible = false;
            }
        }

        private void Certificat_Essai_Click(object sender, EventArgs e)
        {
            certificatRobinet1.Hide();
            personnels1.Hide();
            formDashboard1.Hide();
            certificatEssai1.BringToFront();
            certificatEssai1.Show();
        }

        private void Certificat_Robinet_Click(object sender, EventArgs e)
        {
            personnels1.Hide();
            formDashboard1.Hide();
            certificatEssai1.Hide();
            certificatRobinet1.BringToFront();
            certificatRobinet1.Show();
        }

        private void Personnels_Click(object sender, EventArgs e)
        {
            certificatEssai1.Hide();
            certificatRobinet1.Hide();
            formDashboard1.Hide();
            personnels1.BringToFront();
            personnels1.Show();
            personnels1.user1.Text = user.Text;
            if (user.Text == "Admin")
            {
                personnels1.Ajouter.Enabled = true;
            }
            else
            {
                personnels1.Ajouter.Enabled = false;
            }
        }

        private void DashboardForm_Click(object sender, EventArgs e)
        {
            certificatEssai1.Hide();
            certificatRobinet1.Hide();
            formDashboard1.Hide();
            personnels1.Hide();
            formDashboard1.BringToFront();
            formDashboard1.Show();

        }
        // ALL DATA CERTF 1
        private void Certificat_Essai_R_Click(object sender, EventArgs e)
        {
            RapportForm rapportForm = new RapportForm();
            rapportForm.ShowDialog();

        }

        private void Certificat_Robinet_R_Click(object sender, EventArgs e)
        {
            RapportsCertf2 rapportsCertf2 = new RapportsCertf2();
            rapportsCertf2.ShowDialog();
        }

        public void DéconnecterApp_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
            WindowState = FormWindowState.Maximized;

        }

        private void QuiterMainForm_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void MinimizedMainForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

    }
}
