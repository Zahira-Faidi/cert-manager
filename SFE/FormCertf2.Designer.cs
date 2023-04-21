
namespace SFE
{
    partial class FormCertf2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCertf2));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Add = new DevExpress.XtraBars.BarButtonItem();
            this.Nettoyer = new DevExpress.XtraBars.BarButtonItem();
            this.Quitter = new DevExpress.XtraBars.BarButtonItem();
            this.Enregitrer = new DevExpress.XtraBars.BarButtonItem();
            this.Enregistrer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Num_Commande = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_TechniTar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Num_Serie = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Marque = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Nature_produit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TService = new System.Windows.Forms.TextBox();
            this.Contre_p = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.P_essai = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Diametre_entre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Diametre_Sortie = new System.Windows.Forms.TextBox();
            this.PN = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Non = new System.Windows.Forms.RadioButton();
            this.Oui = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Add,
            this.Nettoyer,
            this.Quitter,
            this.Enregitrer,
            this.Enregistrer});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(745, 158);
            // 
            // Add
            // 
            this.Add.Caption = "Ajouter";
            this.Add.Id = 1;
            this.Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Add.ImageOptions.SvgImage")));
            this.Add.Name = "Add";
            this.Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Add_ItemClick);
            // 
            // Nettoyer
            // 
            this.Nettoyer.Caption = "Nettoyer";
            this.Nettoyer.Id = 2;
            this.Nettoyer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Nettoyer.ImageOptions.SvgImage")));
            this.Nettoyer.Name = "Nettoyer";
            this.Nettoyer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Nettoyer_ItemClick);
            // 
            // Quitter
            // 
            this.Quitter.Caption = "Quitter";
            this.Quitter.Id = 3;
            this.Quitter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Quitter.ImageOptions.SvgImage")));
            this.Quitter.Name = "Quitter";
            this.Quitter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Quitter_ItemClick);
            // 
            // Enregitrer
            // 
            this.Enregitrer.Caption = "Enregistrer";
            this.Enregitrer.Id = 4;
            this.Enregitrer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Enregitrer.ImageOptions.SvgImage")));
            this.Enregitrer.Name = "Enregitrer";
            // 
            // Enregistrer
            // 
            this.Enregistrer.Caption = "Enregistrer";
            this.Enregistrer.Id = 5;
            this.Enregistrer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Enregistrer.ImageOptions.SvgImage")));
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Enregistrer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Add);
            this.ribbonPageGroup1.ItemLinks.Add(this.Nettoyer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Enregistrer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup3.ImageOptions.SvgImage")));
            this.ribbonPageGroup3.ItemLinks.Add(this.Quitter);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Num_Commande);
            this.groupBox1.Controls.Add(this.Client);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Num_TechniTar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(24, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 155);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Certificat";
            // 
            // Num_Commande
            // 
            this.Num_Commande.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Num_Commande.Location = new System.Drawing.Point(137, 32);
            this.Num_Commande.Name = "Num_Commande";
            this.Num_Commande.Size = new System.Drawing.Size(500, 22);
            this.Num_Commande.TabIndex = 153;
            // 
            // Client
            // 
            this.Client.BackColor = System.Drawing.Color.White;
            this.Client.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Client.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.FormattingEnabled = true;
            this.Client.Location = new System.Drawing.Point(137, 60);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(500, 21);
            this.Client.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 148;
            this.label3.Text = "N° Commande";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 123;
            this.label1.Text = "N° Technitar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 125;
            this.label2.Text = "Client";
            // 
            // Num_TechniTar
            // 
            this.Num_TechniTar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Num_TechniTar.Location = new System.Drawing.Point(137, 87);
            this.Num_TechniTar.Name = "Num_TechniTar";
            this.Num_TechniTar.Size = new System.Drawing.Size(500, 22);
            this.Num_TechniTar.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 150;
            this.label4.Text = "Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 118);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(500, 23);
            this.dateTimePicker1.TabIndex = 151;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Num_Serie);
            this.groupBox2.Controls.Add(this.Type);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Marque);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(24, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 117);
            this.groupBox2.TabIndex = 175;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "APPAREIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(16, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 153;
            this.label6.Text = "N° de Série";
            // 
            // Num_Serie
            // 
            this.Num_Serie.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Num_Serie.Location = new System.Drawing.Point(137, 81);
            this.Num_Serie.Name = "Num_Serie";
            this.Num_Serie.Size = new System.Drawing.Size(500, 22);
            this.Num_Serie.TabIndex = 154;
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.White;
            this.Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(137, 53);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(500, 21);
            this.Type.TabIndex = 152;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 148;
            this.label5.Text = "Marque";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Marque
            // 
            this.Marque.BackColor = System.Drawing.Color.White;
            this.Marque.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Marque.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marque.FormattingEnabled = true;
            this.Marque.Location = new System.Drawing.Point(137, 23);
            this.Marque.Name = "Marque";
            this.Marque.Size = new System.Drawing.Size(500, 21);
            this.Marque.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(16, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 125;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Nature_produit);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TService);
            this.groupBox3.Controls.Add(this.Contre_p);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.P_essai);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(24, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 152);
            this.groupBox3.TabIndex = 176;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conditions de Service";
            // 
            // Nature_produit
            // 
            this.Nature_produit.BackColor = System.Drawing.Color.White;
            this.Nature_produit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nature_produit.FormattingEnabled = true;
            this.Nature_produit.Location = new System.Drawing.Point(137, 25);
            this.Nature_produit.Name = "Nature_produit";
            this.Nature_produit.Size = new System.Drawing.Size(500, 21);
            this.Nature_produit.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 133;
            this.label8.Text = "Nature produit";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(17, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 137;
            this.label9.Text = "T° de Service";
            // 
            // TService
            // 
            this.TService.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TService.Location = new System.Drawing.Point(137, 53);
            this.TService.Name = "TService";
            this.TService.Size = new System.Drawing.Size(500, 22);
            this.TService.TabIndex = 138;
            // 
            // Contre_p
            // 
            this.Contre_p.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Contre_p.Location = new System.Drawing.Point(137, 81);
            this.Contre_p.Name = "Contre_p";
            this.Contre_p.Size = new System.Drawing.Size(500, 22);
            this.Contre_p.TabIndex = 140;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(17, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 139;
            this.label12.Text = "Contre Pression";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(16, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 141;
            this.label11.Text = "Pression d\'essai";
            // 
            // P_essai
            // 
            this.P_essai.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.P_essai.Location = new System.Drawing.Point(138, 111);
            this.P_essai.Name = "P_essai";
            this.P_essai.Size = new System.Drawing.Size(499, 22);
            this.P_essai.TabIndex = 142;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.Diametre_entre);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.Diametre_Sortie);
            this.groupBox4.Controls.Add(this.PN);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.Location = new System.Drawing.Point(24, 592);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 131);
            this.groupBox4.TabIndex = 177;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Autres Caractéristiques";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label21.Location = new System.Drawing.Point(17, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 15);
            this.label21.TabIndex = 154;
            this.label21.Text = "Diamètre entré";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Diametre_entre
            // 
            this.Diametre_entre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Diametre_entre.Location = new System.Drawing.Point(141, 35);
            this.Diametre_entre.Name = "Diametre_entre";
            this.Diametre_entre.Size = new System.Drawing.Size(496, 22);
            this.Diametre_entre.TabIndex = 155;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label20.Location = new System.Drawing.Point(17, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 15);
            this.label20.TabIndex = 156;
            this.label20.Text = "Diamètre Sortie";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Diametre_Sortie
            // 
            this.Diametre_Sortie.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Diametre_Sortie.Location = new System.Drawing.Point(141, 63);
            this.Diametre_Sortie.Name = "Diametre_Sortie";
            this.Diametre_Sortie.Size = new System.Drawing.Size(496, 22);
            this.Diametre_Sortie.TabIndex = 157;
            // 
            // PN
            // 
            this.PN.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PN.Location = new System.Drawing.Point(141, 92);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(496, 22);
            this.PN.TabIndex = 160;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label18.Location = new System.Drawing.Point(17, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 159;
            this.label18.Text = "Série ou PN";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Non
            // 
            this.Non.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Non.AutoSize = true;
            this.Non.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Non.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Non.Location = new System.Drawing.Point(465, 735);
            this.Non.Name = "Non";
            this.Non.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Non.Size = new System.Drawing.Size(63, 22);
            this.Non.TabIndex = 184;
            this.Non.TabStop = true;
            this.Non.Text = "NON";
            this.Non.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Non.UseVisualStyleBackColor = true;
            // 
            // Oui
            // 
            this.Oui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Oui.AutoSize = true;
            this.Oui.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oui.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Oui.Location = new System.Drawing.Point(401, 735);
            this.Oui.Name = "Oui";
            this.Oui.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Oui.Size = new System.Drawing.Size(58, 22);
            this.Oui.TabIndex = 183;
            this.Oui.TabStop = true;
            this.Oui.Text = "OUI";
            this.Oui.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label23.Location = new System.Drawing.Point(212, 737);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(185, 18);
            this.label23.TabIndex = 182;
            this.label23.Text = "Essais Satisfaisants  ";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(24, 739);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(13, 21);
            this.id.TabIndex = 186;
            this.id.Visible = false;
            // 
            // FormCertf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 772);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Non);
            this.Controls.Add(this.Oui);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::SFE.Properties.Resources.relief_valve_48px;
            this.MaximizeBox = false;
            this.Name = "FormCertf2";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CERTIFICAT ROBINET CBGS";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        public DevExpress.XtraBars.BarButtonItem Add;
        private DevExpress.XtraBars.BarButtonItem Nettoyer;
        private DevExpress.XtraBars.BarButtonItem Quitter;
        public DevExpress.XtraBars.BarButtonItem Enregitrer;
        public DevExpress.XtraBars.BarButtonItem Enregistrer;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Num_TechniTar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Num_Serie;
        public System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox Marque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox Nature_produit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TService;
        public System.Windows.Forms.TextBox Contre_p;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox P_essai;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox Diametre_entre;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox Diametre_Sortie;
        public System.Windows.Forms.TextBox PN;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.RadioButton Non;
        public System.Windows.Forms.RadioButton Oui;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox id;
        public System.Windows.Forms.TextBox Num_Commande;
    }
}