
namespace SFE
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LoginF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Eye = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eye)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SFE.Properties.Resources.man_wearing_welding_helmet_welding_metal_near_gray_brick_1474993_1920x1200;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 666);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.Eye);
            this.panel6.Controls.Add(this.password);
            this.panel6.Controls.Add(this.userName);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(310, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(484, 344);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LoginF);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 287);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(484, 57);
            this.panel7.TabIndex = 28;
            // 
            // LoginF
            // 
            this.LoginF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(104)))), ((int)(((byte)(149)))));
            this.LoginF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(104)))), ((int)(((byte)(149)))));
            this.LoginF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginF.BorderRadius = 0;
            this.LoginF.ButtonText = "Connexion";
            this.LoginF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginF.DisabledColor = System.Drawing.Color.Gray;
            this.LoginF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginF.Iconcolor = System.Drawing.Color.Transparent;
            this.LoginF.Iconimage = ((System.Drawing.Image)(resources.GetObject("LoginF.Iconimage")));
            this.LoginF.Iconimage_right = null;
            this.LoginF.Iconimage_right_Selected = null;
            this.LoginF.Iconimage_Selected = null;
            this.LoginF.IconMarginLeft = 200;
            this.LoginF.IconMarginRight = 0;
            this.LoginF.IconRightVisible = true;
            this.LoginF.IconRightZoom = 0D;
            this.LoginF.IconVisible = true;
            this.LoginF.IconZoom = 50D;
            this.LoginF.IsTab = false;
            this.LoginF.Location = new System.Drawing.Point(0, 0);
            this.LoginF.Name = "LoginF";
            this.LoginF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(104)))), ((int)(((byte)(149)))));
            this.LoginF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoginF.OnHoverTextColor = System.Drawing.Color.White;
            this.LoginF.selected = false;
            this.LoginF.Size = new System.Drawing.Size(484, 57);
            this.LoginF.TabIndex = 23;
            this.LoginF.Text = "Connexion";
            this.LoginF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginF.Textcolor = System.Drawing.Color.White;
            this.LoginF.TextFont = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginF.Click += new System.EventHandler(this.Login_b_Click);
            // 
            // Eye
            // 
            this.Eye.BackColor = System.Drawing.Color.White;
            this.Eye.Image = global::SFE.Properties.Resources.invisible_24px;
            this.Eye.Location = new System.Drawing.Point(406, 231);
            this.Eye.Name = "Eye";
            this.Eye.Size = new System.Drawing.Size(24, 24);
            this.Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Eye.TabIndex = 27;
            this.Eye.TabStop = false;
            this.Eye.Click += new System.EventHandler(this.Eye_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(70, 227);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(366, 33);
            this.password.TabIndex = 26;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Gray;
            this.userName.Location = new System.Drawing.Point(70, 141);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(366, 33);
            this.userName.TabIndex = 25;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Slab Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(129, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 54);
            this.label3.TabIndex = 24;
            this.label3.Text = "Connexion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mot de passe";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nom d\'utilisateur";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(966, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SFE.Properties.Resources.man_wearing_welding_helmet_welding_metal_near_gray_brick_1474993_1920x1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 666);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton LoginF;
        private System.Windows.Forms.PictureBox Eye;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}