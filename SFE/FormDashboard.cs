using MySql.Data.MySqlClient;
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
    public partial class FormDashboard : UserControl
    {
        MySqlConnection connexion = new MySqlConnection("Server=localhost;Port=3306;Database=technitar;Uid=root;");
        MySqlCommand cmd;
        public FormDashboard()
        {
            InitializeComponent();
            CountCertf1();
            CountCertf2();
            CountUser();
            //panel2.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            //panel3.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            //panel4.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            //panel5.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            TestChart();

        }
        public void TestChart()
        {
            connexion.Open();
            string nombr = "SELECT count(*)+1 FROM `tests_et_controles` WHERE `Essais_Satisfaisants` = 'Oui'";
            cmd = new MySqlCommand(nombr, connexion);
            string n1 = cmd.ExecuteScalar().ToString();
            //------------
            string nombr2 = "SELECT count(*) FROM tests_et_controles WHERE Essais_Satisfaisants = 'Non'";
            MySqlCommand cmd2 = new MySqlCommand(nombr2, connexion);
            string n2 = cmd2.ExecuteScalar().ToString();
            chart1.Series["s1"].Points.AddXY("Essai Satisfait", n1);
            chart1.Series["s1"].Points.AddXY("Essai Non Satisfait", n2);
            //------------------------------------------
            string nombr3 = "SELECT Count(*) FROM `conditions_service_c2` WHERE `Essais_S` = 'Oui'";
            MySqlCommand cmd3 = new MySqlCommand(nombr3, connexion);
            string n3 = cmd3.ExecuteScalar().ToString();
            string nombr4 = "SELECT Count(*) FROM `conditions_service_c2` WHERE `Essais_S` = 'Non'";
            MySqlCommand cmd4 = new MySqlCommand(nombr4, connexion);
            string n4 = cmd4.ExecuteScalar().ToString();
            chart2.Series["s2"].Points.AddXY("Essai Satisfait", n3);
            chart2.Series["s2"].Points.AddXY("Essai Non Satisfait", n4);
            connexion.Close();
        }
        public void CountCertf1()
        {
            connexion.Open();
            string nombr = "SELECT COUNT(*) FROM certificatdessai";
            cmd = new MySqlCommand(nombr, connexion);
            Numbr.Text = cmd.ExecuteScalar().ToString();
            connexion.Close();
        }
        public void CountCertf2()
        {
            connexion.Open();
            string nombr = "SELECT COUNT(*) FROM certificat_robinet";
            cmd = new MySqlCommand(nombr, connexion);
            Numbr2.Text = cmd.ExecuteScalar().ToString();
            connexion.Close();
        }
        public void CountUser()
        {
            connexion.Open();
            string nombr = "SELECT COUNT(*) FROM personnels";
            cmd = new MySqlCommand(nombr, connexion);
            UserNombr.Text = cmd.ExecuteScalar().ToString();
            connexion.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RapportForm rapportForm = new RapportForm();
            rapportForm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RapportsCertf2 rapportsCertf2 = new RapportsCertf2();
            rapportsCertf2.ShowDialog();
        }
    }
}
