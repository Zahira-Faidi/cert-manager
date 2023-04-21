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
    public partial class ModifierCompte : Form
    {
        readonly MySqlConnection connexion = new MySqlConnection("Server=localhost;Port=3306;Database=technitar;Uid=root;");
        MySqlCommand cmd;
        public ModifierCompte()
        {
            InitializeComponent();
        }
        //string data = "SELECT id as ID , Nom_personnelle as 'Nom' , Prenom_personnelle as 'Prénom' , mail as 'Mail' , username as 'Nom utilisateur' , DateCreated , LastLogin  FROM personnels";


        private void Login_b_Click(object sender, EventArgs e)
        {
            connexion.Open();
            if(NewPass.Text == ConfPass.Text)
            {
                string requete = "UPDATE personnels SET  Nom_personnel = '" + Nom.Text + "' , Prenom_personnel = '" + lastName.Text + "' , mail = '" + mail.Text + "' , password = SHA1('"+NewPass.Text+"') Where id = " + Int32.Parse(id.Text);
                DialogResult res = MessageBox.Show("Est-ce que vous confirme les modifications sur l'enregistrement " + Int32.Parse(id.Text) + " ?", "Modifications", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    cmd = new MySqlCommand(requete, connexion);
                    cmd.ExecuteNonQuery();
                    connexion.Close();
                    MessageBox.Show("L'application va redémarrer.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("Erreur");
                }

            }
            else
            {
                MessageBox.Show("Mot de passe incorrect ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfPass.Text = "";
                ConfPass.Focus();
            }

        }
        private int flag = 1;
        private int flag2 = 1;

        private void Eye_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag != 1)
            {
                Bitmap bitmap1 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\eye_24px.png");
                Eye.Image = bitmap1;
                NewPass.isPassword = false;
            }
            else
            {
                Bitmap bitmap2 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\invisible_24px.png");
                Eye.Image = bitmap2;
                NewPass.isPassword = true;
            }
        }

        private void Eye2_Click(object sender, EventArgs e)
        {
            flag2 *= -1;
            if (flag2 != 1)
            {
                Bitmap bitmap1 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\eye_24px.png");
                Eye2.Image = bitmap1;
                ConfPass.isPassword = false;
            }
            else
            {
                Bitmap bitmap2 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\invisible_24px.png");
                Eye2.Image = bitmap2;
                ConfPass.isPassword = true;
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
