using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SFE
{
    public partial class UserFirstInterface : Form
    {
        public UserFirstInterface()
        {
            InitializeComponent();
        }

        private void UserFirstInterface_Load(object sender, EventArgs e)
        {
            panel2.BackColor = System.Drawing.Color.FromArgb(100,0,0,0);
        }

        private void Demarrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
