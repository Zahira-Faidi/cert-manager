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
    public partial class Personnels : UserControl
    {
        readonly MySqlConnection connexion = new MySqlConnection("Server=localhost;Port=3306;Database=technitar;Uid=root;");
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        readonly string data = "SELECT id as ID , Nom_personnel as 'Nom' , Prenom_personnel as 'Prénom' , mail as 'Mail' , username as 'Nom utilisateur' , DateCreated as 'Date créeation' , LastLogin as 'Dernière connexion' FROM personnels where superAdmin != 1 ";
        public void IsEmpty()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                Edit.Enabled = false;
                DeleteP.Enabled = false;
            }
            else
            {
                Edit.Enabled = true;
                DeleteP.Enabled = true;
            }
        }
        public void UpLoad()
        {
            try
            {
                connexion.Open();
                MySqlDataAdapter adapt;
                adapt = new MySqlDataAdapter(data, connexion);
                dt = new DataTable();
                adapt.FillAsync(dt);
                dataGridView1.DataSource = dt;
                connexion.Close();
                dataGridView1.Refresh();
                IsEmpty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();
            }
        }
        public Personnels()
        {
            InitializeComponent();
            UpLoad();

        }

        private void Ajouter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreerCompte register = new CreerCompte();
            register.ShowDialog();
        }

        private void RefreshA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                connexion.Open();
                MySqlDataAdapter adapt;
                adapt = new MySqlDataAdapter(data, connexion);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                connexion.Close();
                dataGridView1.Refresh();
                IsEmpty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();

            }

        }
        public void DeletePer()
        {
            string selectedIndexS = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            int selectedIndex = Int32.Parse(selectedIndexS);
            string d = "DELETE FROM personnels WHERE id = "+selectedIndex;
            int selectIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectIndex > -1)
            {

                MySqlCommand MyCommand2 = new MySqlCommand(d, connexion);
                MySqlDataReader MyReader2;
                connexion.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                dataGridView1.Rows.RemoveAt(selectIndex);
                MessageBox.Show("Suppression bien effectué ", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (MyReader2.Read())
                {
                }
                connexion.Close();

            }
        }

        private void DeleteP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cond = dataGridView1.CurrentRow.Cells["Nom utilisateur"].Value.ToString();
            if(user1.Text == "Admin")
            {
                DialogResult result = MessageBox.Show("Est-ce que vous êtes sure ? ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeletePer();
                    IsEmpty();

                }
            }
            else if (cond != user1.Text)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer ce compte !", "", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Est-ce que vous êtes sure ? ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeletePer();
                    IsEmpty();
                    Application.Restart();
                    Environment.Exit(0);
                }
            }

        }

        private void Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string selectedIndexS = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            string cond = dataGridView1.CurrentRow.Cells["Nom utilisateur"].Value.ToString();
            if (user1.Text == "Admin")
            {
                ModifierCompte modifierCompte = new ModifierCompte();
                modifierCompte.Show();
                modifierCompte.id.Text = selectedIndexS;
                int index = Int32.Parse(modifierCompte.id.Text);
                string getdata = "SELECT Nom_personnel , Prenom_personnel , mail , username FROM personnels  WHERE id = " + index;
                connexion.Open();
                cmd = new MySqlCommand(getdata, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    modifierCompte.Nom.Text = reader.GetValue(0).ToString();
                    modifierCompte.lastName.Text = reader.GetValue(1).ToString();
                    modifierCompte.mail.Text = reader.GetValue(2).ToString();
                    modifierCompte.UserName.Text = reader.GetValue(3).ToString();

                }
                connexion.Close();

            }
            else if (cond != user1.Text)
            {
                MessageBox.Show("Vous ne pouvez pas Modifier ce compte !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ModifierCompte modifierCompte = new ModifierCompte();
                modifierCompte.Show();
                modifierCompte.id.Text = selectedIndexS;
                int index = Int32.Parse(modifierCompte.id.Text);
                string getdata = "SELECT Nom_personnel , Prenom_personnel , mail , username FROM personnels  WHERE id = " + index;
                connexion.Open();
                cmd = new MySqlCommand(getdata, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    modifierCompte.Nom.Text = reader.GetValue(0).ToString();
                    modifierCompte.lastName.Text = reader.GetValue(1).ToString();
                    modifierCompte.mail.Text = reader.GetValue(2).ToString();
                    modifierCompte.UserName.Text = reader.GetValue(3).ToString();

                }
                connexion.Close();


            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {//, DateCreated as 'Date créeation' , LastLogin as 'Dernière connexion' FROM personnels where superAdmin != 1 ";
            connexion.Open();
            MySqlDataAdapter adapt;
            string chercher = "SELECT id as ID , Nom_personnel as 'Nom' , Prenom_personnel as 'Prénom' , mail as 'Mail' , username as 'Nom utilisateur' , DateCreated as 'Date créeation' , LastLogin as 'Dernière connexion' FROM personnels"
            + " Where (personnels.Nom_personnel like '%" + textBox1.Text + "%'"
                + " Or personnels.Prenom_personnel like '%" + textBox1.Text + "%'"
                + " Or personnels.mail  like '%" + textBox1.Text + "%'"
                + " Or personnels.username like '%" + textBox1.Text + "%')"
                + " And (superAdmin != 1 )";
            adapt = new MySqlDataAdapter(chercher, connexion);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connexion.Close();
        }
    }
}
