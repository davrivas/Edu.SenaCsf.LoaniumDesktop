namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class Search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Messages = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.i_menuBackground = new System.Windows.Forms.PictureBox();
            this.iMBTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMBTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lbl_Messages
            // 
            this.lbl_Messages.AutoSize = true;
            this.lbl_Messages.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Messages.Location = new System.Drawing.Point(220, 33);
            this.lbl_Messages.Name = "lbl_Messages";
            this.lbl_Messages.Size = new System.Drawing.Size(318, 31);
            this.lbl_Messages.TabIndex = 36;
            this.lbl_Messages.Text = "Buscar en la Aplicación";
            // 
            // build
            // 
            this.build.Location = new System.Drawing.Point(320, 217);
            this.build.MarqueeAnimationSpeed = 50;
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(100, 23);
            this.build.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.build.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "En construcción :\'v";
            // 
            // i_menuBackground
            // 
            this.i_menuBackground.Enabled = false;
            this.i_menuBackground.Image = ((System.Drawing.Image)(resources.GetObject("i_menuBackground.Image")));
            this.i_menuBackground.Location = new System.Drawing.Point(0, 0);
            this.i_menuBackground.Name = "i_menuBackground";
            this.i_menuBackground.Size = new System.Drawing.Size(750, 600);
            this.i_menuBackground.TabIndex = 39;
            this.i_menuBackground.TabStop = false;
            // 
            // iMBTest
            // 
            this.iMBTest.Image = ((System.Drawing.Image)(resources.GetObject("iMBTest.Image")));
            this.iMBTest.Location = new System.Drawing.Point(0, 0);
            this.iMBTest.Name = "iMBTest";
            this.iMBTest.Size = new System.Drawing.Size(750, 600);
            this.iMBTest.TabIndex = 52;
            this.iMBTest.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.build);
            this.Controls.Add(this.lbl_Messages);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.iMBTest);
            this.Controls.Add(this.i_menuBackground);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(750, 600);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMBTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Messages;
        private System.Windows.Forms.ProgressBar build;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox i_menuBackground;
        private System.Windows.Forms.PictureBox iMBTest;
    }
}
