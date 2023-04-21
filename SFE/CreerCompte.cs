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
    public partial class CreerCompte : Form
    {
        MySqlConnection connexion = new MySqlConnection("Server=localhost;Port=3306;Database=technitar;Uid=root;");
        MySqlCommand cmd;
        DataTable dt = new DataTable();
        public CreerCompte()
        {
            InitializeComponent();
        }
        public bool UserNameExist()
        {
            bool test = false;
            connexion.Open();
            //SELECT COUNT(*) FROM personnels WHERE username =
            string checkuser = "SELECT COUNT(*) FROM personnels WHERE username = '" + UserName.Text + "'";
            MySqlCommand com = new MySqlCommand(checkuser, connexion);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                test = true;
            }
            else if(temp == 0)
            {
                test = false;
            }
            connexion.Close();
            return test;
        }
        private void Login_b_Click(object sender, EventArgs e)
        {
            try 
            { 
                string requete = "INSERT INTO personnels ( Nom_personnel , Prenom_personnel , mail , username , password , DateCreated , LastLogin )"
                           +" VALUES ('"+Nom.Text+"' , '"+lastName.Text+"' , '"+mail.Text+"' , '"+UserName.Text+"' , SHA1('"+password.Text+"') , '"+dateTimePicker1.Value.ToString("d")+"' , '"+dateTimePicker1.Value.ToString("g")+"')";

                if (Nom.Text == "" && lastName.Text == "" && mail.Text == "" && mail.Text == "" && UserName.Text == "" && password.Text == "")
                {
                    MessageBox.Show("Remplire tous les champs","Erreur",MessageBoxButtons.OK , MessageBoxIcon.Error);

                }
                else if (UserNameExist()==true)
                {
                    MessageBox.Show("Nom d'utilisateur déjà utilisé", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserName.Text = "";
                    UserName.Focus();
                }
                else 
                { 
                    connexion.Open();
                    cmd = new MySqlCommand(requete, connexion);
                    cmd.ExecuteNonQuery();
                    DialogResult res = MessageBox.Show("Compte créer avec succès.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        this.Hide();
                    }
                    connexion.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();

            }
        }

        private int flag = 1;
        private void Eye_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag != 1)
            {
                Bitmap bitmap1 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\eye_24px.png");
                Eye.Image = bitmap1;
                password.isPassword = false;
            }
            else
            {
                Bitmap bitmap2 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\invisible_24px.png");
                Eye.Image = bitmap2;
                password.isPassword = true;
            }
        }
         private int a = 0 , b= 0, c = 0, d = 0, f =0;
        private void Name_MouseHover(object sender, EventArgs e)
        {
            if(a == 0) { 
                Nom.Text = "";
                Nom.ForeColor = Color.Black;
                a++;
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lastName_MouseHover(object sender, EventArgs e)
        {
            if (b == 0) { 
                lastName.Text = "";
                lastName.ForeColor = Color.Black;
                b++;
            }
        }

        private void UserName_MouseHover(object sender, EventArgs e)
        {
            if (c == 0) { 
                UserName.Text = "";
                UserName.ForeColor = Color.Black;
                c++;
            }
        }

        private void mail_MouseHover(object sender, EventArgs e)
        {
            if(d == 0) { 
                mail.Text = "";
                mail.ForeColor = Color.Black;
                d++;
            }
        }

        private void password_MouseHover(object sender, EventArgs e)
        {
            if (f == 0) { 
                password.Text = "";
                password.ForeColor = Color.Black;
                f++;
            }
        }
    }
    }

