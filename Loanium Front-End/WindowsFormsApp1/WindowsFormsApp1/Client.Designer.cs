namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGame = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_donate = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.ln_menu = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_catalog = new System.Windows.Forms.Button();
            this.btn_messages = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_closeWindow = new System.Windows.Forms.Button();
            this.btn_minimizeWindow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pqrs1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.PQRS();
            this.catalog1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.Catalog();
            this.donate1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.Donate();
            this.game1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.Game();
            this.profile1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.Profile();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnGame);
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.btn_donate);
            this.panel1.Controls.Add(this.btn_logOut);
            this.panel1.Controls.Add(this.ln_menu);
            this.panel1.Controls.Add(this.btn_info);
            this.panel1.Controls.Add(this.btn_config);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btn_catalog);
            this.panel1.Controls.Add(this.btn_messages);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 650);
            this.panel1.TabIndex = 1;
            // 
            // btnGame
            // 
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Image = ((System.Drawing.Image)(resources.GetObject("btnGame.Image")));
            this.btnGame.Location = new System.Drawing.Point(61, 597);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(30, 23);
            this.btnGame.TabIndex = 11;
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btn_help
            // 
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Image = ((System.Drawing.Image)(resources.GetObject("btn_help.Image")));
            this.btn_help.Location = new System.Drawing.Point(50, 625);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(20, 23);
            this.btn_help.TabIndex = 6;
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_donate
            // 
            this.btn_donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_donate.FlatAppearance.BorderSize = 0;
            this.btn_donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_donate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_donate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_donate.Image = ((System.Drawing.Image)(resources.GetObject("btn_donate.Image")));
            this.btn_donate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_donate.Location = new System.Drawing.Point(5, 261);
            this.btn_donate.Name = "btn_donate";
            this.btn_donate.Size = new System.Drawing.Size(145, 80);
            this.btn_donate.TabIndex = 3;
            this.btn_donate.Text = "    Donación";
            this.btn_donate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_donate.UseVisualStyleBackColor = true;
            this.btn_donate.Click += new System.EventHandler(this.btn_donate_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_logOut.Image")));
            this.btn_logOut.Location = new System.Drawing.Point(110, 625);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(20, 23);
            this.btn_logOut.TabIndex = 8;
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // ln_menu
            // 
            this.ln_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ln_menu.Enabled = false;
            this.ln_menu.Location = new System.Drawing.Point(0, 623);
            this.ln_menu.Name = "ln_menu";
            this.ln_menu.Size = new System.Drawing.Size(162, 2);
            this.ln_menu.TabIndex = 7;
            // 
            // btn_info
            // 
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Image = ((System.Drawing.Image)(resources.GetObject("btn_info.Image")));
            this.btn_info.Location = new System.Drawing.Point(20, 625);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(20, 23);
            this.btn_info.TabIndex = 5;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_config
            // 
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Image = ((System.Drawing.Image)(resources.GetObject("btn_config.Image")));
            this.btn_config.Location = new System.Drawing.Point(80, 625);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(20, 23);
            this.btn_config.TabIndex = 7;
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.sidePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 80);
            this.sidePanel.TabIndex = 2;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_catalog
            // 
            this.btn_catalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_catalog.FlatAppearance.BorderSize = 0;
            this.btn_catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_catalog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_catalog.Image = ((System.Drawing.Image)(resources.GetObject("btn_catalog.Image")));
            this.btn_catalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_catalog.Location = new System.Drawing.Point(5, 175);
            this.btn_catalog.Name = "btn_catalog";
            this.btn_catalog.Size = new System.Drawing.Size(145, 80);
            this.btn_catalog.TabIndex = 2;
            this.btn_catalog.Text = "    Catalogo";
            this.btn_catalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_catalog.UseVisualStyleBackColor = true;
            this.btn_catalog.Click += new System.EventHandler(this.btn_catalog_Click);
            // 
            // btn_messages
            // 
            this.btn_messages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_messages.FlatAppearance.BorderSize = 0;
            this.btn_messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_messages.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_messages.Image = ((System.Drawing.Image)(resources.GetObject("btn_messages.Image")));
            this.btn_messages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_messages.Location = new System.Drawing.Point(3, 347);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(145, 80);
            this.btn_messages.TabIndex = 4;
            this.btn_messages.Text = "    PQRS";
            this.btn_messages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_messages.UseVisualStyleBackColor = true;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(5, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(145, 80);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "    Buscar";
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(5, 0);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(145, 80);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "    Perfil";
            this.btn_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.btn_closeWindow);
            this.panel2.Controls.Add(this.btn_minimizeWindow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 25);
            this.panel2.TabIndex = 0;
            // 
            // btn_closeWindow
            // 
            this.btn_closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.btn_closeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeWindow.Image")));
            this.btn_closeWindow.Location = new System.Drawing.Point(724, 0);
            this.btn_closeWindow.Name = "btn_closeWindow";
            this.btn_closeWindow.Size = new System.Drawing.Size(23, 23);
            this.btn_closeWindow.TabIndex = 1;
            this.btn_closeWindow.UseVisualStyleBackColor = true;
            this.btn_closeWindow.Click += new System.EventHandler(this.btn_closeWindow_Click);
            // 
            // btn_minimizeWindow
            // 
            this.btn_minimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizeWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.btn_minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizeWindow.Image")));
            this.btn_minimizeWindow.Location = new System.Drawing.Point(695, 0);
            this.btn_minimizeWindow.Name = "btn_minimizeWindow";
            this.btn_minimizeWindow.Size = new System.Drawing.Size(23, 23);
            this.btn_minimizeWindow.TabIndex = 0;
            this.btn_minimizeWindow.UseVisualStyleBackColor = true;
            this.btn_minimizeWindow.Click += new System.EventHandler(this.btn_minimizeWindow_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(150, 625);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 25);
            this.panel3.TabIndex = 6;
            // 
            // pqrs1
            // 
            this.pqrs1.Location = new System.Drawing.Point(150, 25);
            this.pqrs1.Name = "pqrs1";
            this.pqrs1.Size = new System.Drawing.Size(750, 600);
            this.pqrs1.TabIndex = 14;
            // 
            // catalog1
            // 
            this.catalog1.Location = new System.Drawing.Point(150, 25);
            this.catalog1.Name = "catalog1";
            this.catalog1.Size = new System.Drawing.Size(750, 600);
            this.catalog1.TabIndex = 13;
            // 
            // donate1
            // 
            this.donate1.Location = new System.Drawing.Point(150, 25);
            this.donate1.Name = "donate1";
            this.donate1.Size = new System.Drawing.Size(750, 600);
            this.donate1.TabIndex = 11;
            // 
            // game1
            // 
            this.game1.Location = new System.Drawing.Point(150, 25);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(750, 600);
            this.game1.TabIndex = 15;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(150, 25);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(750, 600);
            this.profile1.TabIndex = 16;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.pqrs1);
            this.Controls.Add(this.catalog1);
            this.Controls.Add(this.donate1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_catalog;
        private System.Windows.Forms.Button btn_messages;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ln_menu;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_closeWindow;
        private System.Windows.Forms.Button btn_minimizeWindow;
        private System.Windows.Forms.Button btn_donate;
        private System.Windows.Forms.Button btn_help;
        private Donate donate1;
        private Catalog catalog1;
        private System.Windows.Forms.Button btnGame;
        private PQRS pqrs1;
        private Game game1;
        private Profile profile1;
    }
}

