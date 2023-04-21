using DevExpress.XtraBars.Ribbon;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SFE
{
    public partial class FormCertif1 : RibbonForm
    {
        public FormCertif1()
        {
            InitializeComponent();
            Clear();
        }

        // Connecction string-----------------------------------------------------------------------------------------
        readonly MySqlConnection connexion = new MySqlConnection("Server=localhost;Port=3306;Database=technitar;Uid=root;");
        MySqlCommand cmd;
        //------------------------------------------------------------------------------------------------------------
        public void RemplirCombobox()
        {
            //------------------Remplire Combobox ------------------------------------
            string CommandText = "SELECT DISTINCT Nom_Demandeur FROM demandeur WHERE Nom_Demandeur IS NOT NULL ";
            MySqlCommand cmd = new MySqlCommand(CommandText, connexion);
            //open connexion
            connexion.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Demandeur.Items.Add(dr["Nom_Demandeur"].ToString());
            }
            //-----------------------------------------------------------------------
            string CommandText1 = "SELECT DISTINCT Type FROM identification_soupape WHERE Marque IS NOT NULL";
            MySqlCommand cmd1 = new MySqlCommand(CommandText1, connexion);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                Type.Items.Add(dr1["Type"].ToString());
            }
            //-----------------------------------------------------------------------
            string CommandText2 = "SELECT DISTINCT Marque FROM identification_soupape WHERE Marque IS NOT NULL";
            MySqlCommand cmd2 = new MySqlCommand(CommandText2, connexion);
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                Marque.Items.Add(dr2["Marque"].ToString());
            }
            //-----------------------------------------------------------------------
            string CommandText3 = "SELECT DISTINCT `Nature_Produit` FROM `conditions_de_service` WHERE `Nature_Produit` IS NOT NULL";
            MySqlCommand cmd3 = new MySqlCommand(CommandText3, connexion);
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                Nature_produit.Items.Add(dr3["Nature_Produit"].ToString());
            }
            //--------------------------------------------------------------------------------
            string CommandText4 = "SELECT DISTINCT Nom_Demandeur FROM demandeur WHERE Nom_Demandeur IS NOT NULL";
            MySqlCommand cmd4 = new MySqlCommand(CommandText4, connexion);
            cmd4.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
            da4.Fill(dt4);
            foreach (DataRow dr4 in dt4.Rows)
            {
                Client.Items.Add(dr4["Nom_Demandeur"].ToString());
            }
            connexion.Close();
        }
        public void InsertMySql()
        {
            try
            {
                connexion.Open();
                double pressionO = double.Parse(P_ouverture.Text);
                double etan = pressionO - 0.1;
                int resEntan1 = (int)etan;
                string resEntan = resEntan1.ToString();
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
                string C_ref = Type.Text + "-DN" + Diametre_entre.Text + "X" + Diametre_Sortie.Text + "-PN" + PN.Text;
                string requete = "INSERT INTO demandeur (Nom_Demandeur , Client) VALUES ('" + Demandeur.Text + "' , '" + Client.Text + "');"
                                + "INSERT INTO conditions_de_service (Nature_Produit , P_service , Temp_service , Contre_P , P_ouverture, P_reglage_froid ) VALUES ('" + Nature_produit.Text + "' , '" + PService.Text + "' , '" + TService.Text + "' , '" + Contre_p.Text + "' , '" + P_ouverture.Text + "' , '" + Pression_Reglage_froid.Text + "');"
                                + "INSERT INTO autres_caracteristique (Repere , D_entre , D_sortie , D_orifice , Pn ) VALUES ('" + Repere.Text + "' , '" + Diametre_entre.Text + "' , '" + Diametre_Sortie.Text + "' , '" + DiametreOrifice.Text + "' , '" + PN.Text + "');"
                                + "INSERT INTO tests_et_controles (etan_90_Crit , Res_Crit , H_reglage_avant , H_reglage_apres , etan , Essais_Satisfaisants , C_Essais_Satisfaisants , num_manométre) VALUES ('" + Etanchete.Text + "' , '" + ResCriteres.Text + "' , '" + HautRegAvant.Text + "' , '" + HautRegApres.Text + "' , '" + resEntan + "' , '" + Ressai + "' , '" + ContreRessai + "' , '"+comboBox1.Text+"');"
                                + "INSERT INTO identification_soupape (Marque , Reference , Type , Num_Serie ) VALUES ('" + Marque.Text + "' , '" + C_ref.ToString() + "' , '" + Type.Text + "', '" + N_de_Série.Text + "');"
                                + "INSERT INTO certificatdessai (Date_Création,Ref, num_Interne) VALUES ('" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' , '" + reference + "' , '" + NumInterne.Text + "');";
                cmd = new MySqlCommand(requete, connexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'insertion a été effectuée avec succès.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();

            }
        }
        // Clear;
        public void Clear()
        {
            Demandeur.Text = ""; // - 1
            Client.Text = ""; // - 2
            Marque.Text = ""; // - 3
            Type.Text = ""; // - 4
            N_de_Série.Text = ""; // - 5
            Nature_produit.Text = ""; // - 6
            PService.Text = ""; // - 7
            TService.Text = ""; // - 8
            Contre_p.Text = "";  // - 9
            P_ouverture.Text = ""; // - 10
            Pression_Reglage_froid.Text = ""; // - 11
            NumInterne.Text = ""; // - 12
            Repere.Text = ""; // - 13
            Diametre_entre.Text = ""; // - 14
            Diametre_Sortie.Text = ""; // - 15
            DiametreOrifice.Text = ""; // - 16
            PN.Text = ""; // - 17
            Etanchete.Text = ""; // - 18
            ResCriteres.Text = ""; // - 19
            HautRegAvant.Text = ""; // - 20
            HautRegApres.Text = ""; // - 21
            Oui.Checked = false; // - 22
            Non.Checked = false; // - 23
            dateTimePicker1.Value = DateTime.Now;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Clear();
            RemplirCombobox();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Demandeur.Text == "" && Client.Text == "" && Marque.Text == "" && Type.Text == "" && N_de_Série.Text == "" && Nature_produit.Text == "" && PService.Text == "" && TService.Text == "" && Contre_p.Text == "" && P_ouverture.Text == "" && Pression_Reglage_froid.Text == "" && NumInterne.Text == "" && Repere.Text == "" && Diametre_entre.Text == "" && Diametre_Sortie.Text == "" && DiametreOrifice.Text == "" && PN.Text == "" && Etanchete.Text == "" && ResCriteres.Text == "" && HautRegAvant.Text == "" && HautRegApres.Text == "" && (Oui.Checked == false || Non.Checked == false))
            {
                MessageBox.Show("Remplire tous les shamps ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InsertMySql();
                connexion.Close();
                this.Hide();
            }
        }

        private void Quitter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void Enregistrer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            connexion.Open();
            // string NumManometre =
            double pressionO = double.Parse(P_ouverture.Text);
            double etan = pressionO - 0.1;
            int resEntan = (int)etan;
            string reference = "TCE-" + dateTimePicker1.Value.Date.ToString("dM/yy");
            //--------------------------------------------------------
            //496AP.DN40XDN65.PN40
            string Ressai;
            string ContreRessai ;
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
            string C_ref = Type.Text + "-DN" + Diametre_entre.Text + "X" + Diametre_Sortie.Text + "-PN" + PN.Text;

            string requete = "UPDATE demandeur SET Nom_Demandeur ='" + Demandeur.Text + "', Client ='" + Client.Text + "' WHERE id =" + Int32.Parse(id.Text) + ";"
                            + "UPDATE conditions_de_service SET Nature_Produit = '" + Nature_produit.Text + "' , P_service = '" + PService.Text + "', Temp_service = '" + TService.Text + "', Contre_P = '" + Contre_p.Text + "' , P_ouverture = '" + P_ouverture.Text + "', P_reglage_froid = '" + Pression_Reglage_froid.Text + "' WHERE id = " + Int32.Parse(id.Text) + ";"
                            + "UPDATE autres_caracteristique SET Repere = '" + Repere.Text + "' , D_entre = '" + Diametre_entre.Text + "',  D_sortie = '" + Diametre_Sortie.Text + "', D_orifice = '" + DiametreOrifice.Text + "', Pn = '" + PN.Text + "' WHERE id = " + Int32.Parse(id.Text) + ";"
                            + "UPDATE tests_et_controles  SET etan_90_Crit = '" + Etanchete.Text + "' , Res_Crit = '" + ResCriteres.Text + "',  H_reglage_avant = '" + HautRegAvant.Text + "', H_reglage_apres = '" + HautRegApres.Text + "' , etan = '" + resEntan + "', Essais_Satisfaisants = '" + Ressai + "', C_Essais_Satisfaisants = '" + ContreRessai + "' WHERE id = " + Int32.Parse(id.Text) + ";"
                            + "UPDATE identification_soupape SET Marque = '" + Marque.Text + "' , Reference = '" + C_ref+ "', Type = '" + Type.Text + "', Num_Serie = '" + N_de_Série.Text + "' WHERE id = " + Int32.Parse(id.Text) + ";"
                            + "UPDATE certificatdessai SET Date_Création = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', Ref = '" + reference + "', num_Interne = '" + NumInterne.Text + "' WHERE id = " + Int32.Parse(id.Text) + ";";

            DialogResult res = MessageBox.Show("Est-ce que vous confirme les modifications sur l'enregistrement "+ Int32.Parse(id.Text) + " ?", "Modifications", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

    }
}