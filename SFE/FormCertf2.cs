using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SFE
{
    public partial class FormCertf2 : RibbonForm
    {
        MySqlConnection connexion = new MySqlConnection("Server=localhost;Port=3306;Database=technitar;Uid=root;");
        MySqlCommand cmd;
        public FormCertf2()
        {
            InitializeComponent();
            RemplirCombobox();
        }
        public void RemplirCombobox()
        {
            //------------------Remplire Combobox ------------------------------------
            string CommandText = "SELECT DISTINCT Client FROM certificat_robinet WHERE Client IS NOT NULL ";
            //open connexion
            connexion.Open();
            MySqlCommand cmd = new MySqlCommand(CommandText, connexion);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Client.Items.Add(dr["Client"].ToString());
            }
            connexion.Close();
            //-----------------------------------------------------------------------
            string CommandText2 = "SELECT DISTINCT Marque FROM appareil WHERE Marque IS NOT NULL";
            connexion.Open();
            MySqlCommand cmd2 = new MySqlCommand(CommandText2, connexion);
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                Marque.Items.Add(dr2["Marque"].ToString());
            }
            connexion.Close();
            //-----------------------------------------------------------------------
            string CommandText3 = "SELECT DISTINCT Type FROM appareil WHERE Type IS NOT NULL";
            connexion.Open();
            MySqlCommand cmd3 = new MySqlCommand(CommandText3, connexion);
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                Type.Items.Add(dr3["Type"].ToString());
            }
            connexion.Close();
            //--------------------------------------------------------------------------------
            string CommandText4 = "SELECT DISTINCT Nature_Produit FROM conditions_service_c2 WHERE Nature_Produit IS NOT NULL";
            connexion.Open();
            MySqlCommand cmd4 = new MySqlCommand(CommandText4, connexion);
            cmd4.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
            da4.Fill(dt4);
            foreach (DataRow dr4 in dt4.Rows)
            {
                Nature_produit.Items.Add(dr4["Nature_Produit"].ToString());
            }
            connexion.Close();
        }
        public void Insert()
        {
            try
            {
                string reference = "TCE-" + dateTimePicker1.Value.ToString("dd") + dateTimePicker1.Value.ToString("MM") + "/" + dateTimePicker1.Value.ToString("yy");
                //--------------------------------------------------------
                //496AP.DN40XDN65.PN40
                string Ressai = "Oui";
                string ContreRessai = "Non";
                if (Oui.Checked)
                {
                    Ressai = "Oui";
                    ContreRessai = "Non";
                }
                else
                {
                    Ressai = "Non";
                    ContreRessai = "Oui";
                }
                string C_ref = "ROBINET " + Diametre_Sortie.Text + " VOIES " + Diametre_entre.Text;
                string requete = "INSERT INTO certificat_robinet (Num_Commande , Client , Num_TechniTar , Ref , Date ) VALUES ('" + Num_Commande.Text + "' , '" + Client.Text + "','" + Num_TechniTar.Text + "','" + reference + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "');"
                                + "INSERT INTO appareil (Marque , Type , Num_serie , Reference) VALUES ('" + Marque.Text + "','" + Type.Text + "','" + Num_Serie.Text + "','" + C_ref + "');"
                                + "INSERT INTO conditions_service_c2 (Nature_Produit , temp_Service , Contre_P , P_essai , Diametre_entre, Diametre_Sortie , PN, Essais_S , C_Essais_S) VALUES ('" + Nature_produit.Text + "','" + TService.Text + "','" + Contre_p.Text + "','" + P_essai.Text + "','" + Diametre_entre.Text + "','" + Diametre_Sortie.Text + "','" + PN.Text + "','" + Ressai + "','" + ContreRessai + "');";
                connexion.Open();
                cmd = new MySqlCommand(requete, connexion);
                cmd.ExecuteNonQuery();
                DialogResult res = MessageBox.Show("L'insertion a été effectuée avec succès.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(res == DialogResult.OK)
                {
                    this.Hide();
                }
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();

            }
        }
        public void Clear()
        {
            Num_Commande.Text = "";
            Client.Text = "";
            Num_TechniTar.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            Marque.Text = "";
            Type.Text = "";
            Num_Serie.Text = "";
            Nature_produit.Text = "";
            TService.Text = "";
            Contre_p.Text = "";
            P_essai.Text = "";
            Diametre_entre.Text = "";
            Diametre_Sortie.Text = "";
            PN.Text = "";
            Oui.Checked = false;
            Non.Checked = false;
        }
        private void Nettoyer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
        }

        private void Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Insert();

        }

        private void Enregistrer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                connexion.Open();
                string reference = "TCE-" + dateTimePicker1.Value.ToString("dd") + dateTimePicker1.Value.ToString("MM") + "/" + dateTimePicker1.Value.ToString("yy");
                //--------------------------------------------------------
                //496AP.DN40XDN65.PN40
                string Ressai = "Oui";
                string ContreRessai = "Non";
                if (Oui.Checked)
                {
                    Ressai = "Oui";
                    ContreRessai = "Non";
                }
                else
                {
                    Ressai = "Non";
                    ContreRessai = "Oui";
                }
                string C_ref = "ROBINET " + Diametre_Sortie.Text + " VOIES " + Diametre_entre.Text;
                string requete = "UPDATE certificat_robinet SET Num_Commande = '" + Num_Commande.Text + "' , Client = '" + Client.Text + "' , Num_TechniTar = '" + Num_TechniTar.Text + "' , Ref = '" + reference + "' , Date = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' WHERE id = " + Int32.Parse(id.Text) + ";"
                               + "UPDATE appareil SET Marque = '" + Marque.Text + "' , Type = '" + Type.Text + "' , Num_serie = '" + Num_Serie.Text + "' , Reference ='" + C_ref + "' WHERE id = " + Int32.Parse(id.Text) + ";"
                               + "UPDATE conditions_service_c2 SET Nature_Produit = '" + Nature_produit.Text + "', temp_Service = '" + TService.Text + "', Contre_P = '" + Contre_p.Text + "' , P_essai = '" + Contre_p.Text + "' , Diametre_entre = '" + Diametre_entre.Text + "', Diametre_Sortie = '" + Diametre_Sortie.Text + "' , PN = '" + PN.Text + "', Essais_S = '" + Ressai + "' , C_Essais_S = '" + ContreRessai + "' WHERE id = " + Int32.Parse(id.Text) + ";";
                DialogResult res = MessageBox.Show("Est-ce que vous confirme les modifications sur l'enregistrement " + Int32.Parse(id.Text) + " ?", "Modifications", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (res == DialogResult.Yes)
                {
                    cmd = new MySqlCommand(requete, connexion);
                    cmd.ExecuteNonQuery();
                    connexion.Close();
                    this.Hide();
                }
                else
                {
                    connexion.Close();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();
            }
        }

        private void Quitter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
