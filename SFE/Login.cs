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
    public partial class Login : Form
    {
        readonly MySqlConnection connexion = new MySqlConnection("Server=localhost;Port=3306;Database=technitar;Uid=root;");
        MySqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            
            panel6.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            dateTimePicker1.Value = DateTime.Now;
            userName.Text = "";
            password.Text = "";
            userName.Focus();
        }
        private void Login_b_Click(object sender, EventArgs e)
        {
            try
            {
                connexion.Open();
                string select = "SELECT id , username , password  FROM personnels  WHERE username = '" + userName.Text + "' AND password = SHA1('"+password.Text+"') ;"
                            + " Update personnels SET LastLogin = '"+dateTimePicker1.Value.ToString("g")+ "' WHERE username = '" + userName.Text + "' AND password = SHA1('" + password.Text + "')";
                cmd = new MySqlCommand(select , connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                    main.user.Text = userName.Text;
                    //main.personnels1.user.Text = userName.Text;
                    reader.Close();
                    connexion.Close();
                }
                else
                {
                    MessageBox.Show("champ invalide","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    reader.Close();
                    password.Text = "";
                    password.Focus();
                    connexion.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();
            }
        }

        private int flag2 = 1;

        private void Eye_Click(object sender, EventArgs e)
        {
            flag2 *= -1;
            if (flag2 != 1)
            {
                Bitmap bitmap1 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\eye_24px.png");
                Eye.Image = bitmap1;
                password.PasswordChar = '\0';
            }
            else
            {
                Bitmap bitmap2 = new Bitmap(@"C:\Users\client\source\repos\SFE\SFE\Resources\invisible_24px.png");
                Eye.Image = bitmap2;
                password.PasswordChar = '•';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
