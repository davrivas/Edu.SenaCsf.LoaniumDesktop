namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.i_LoaniumBackground = new System.Windows.Forms.PictureBox();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tbDocument = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cb_docType = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSet();
            this.i_loanium = new System.Windows.Forms.PictureBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_closeWindow = new System.Windows.Forms.Button();
            this.btn_minimizeWindow = new System.Windows.Forms.Button();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ln_document = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ln_doc = new System.Windows.Forms.Label();
            this.ln_pass = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tipoDocumentoTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.TipoDocumentoTableAdapter();
            this.signUp1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.SignUp();
            ((System.ComponentModel.ISupportInitialize)(this.i_LoaniumBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_loanium)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // i_LoaniumBackground
            // 
            this.i_LoaniumBackground.Image = ((System.Drawing.Image)(resources.GetObject("i_LoaniumBackground.Image")));
            this.i_LoaniumBackground.Location = new System.Drawing.Point(0, 0);
            this.i_LoaniumBackground.Name = "i_LoaniumBackground";
            this.i_LoaniumBackground.Size = new System.Drawing.Size(900, 650);
            this.i_LoaniumBackground.TabIndex = 0;
            this.i_LoaniumBackground.TabStop = false;
            // 
            // btn_signUp
            // 
            this.btn_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.Location = new System.Drawing.Point(29, 559);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(250, 35);
            this.btn_signUp.TabIndex = 4;
            this.btn_signUp.Text = "Registrarse";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(29, 508);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(250, 35);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Iniciar sesión";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbDocument
            // 
            this.tbDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.tbDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocument.ForeColor = System.Drawing.Color.LightGray;
            this.tbDocument.Location = new System.Drawing.Point(29, 409);
            this.tbDocument.MaxLength = 45;
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Size = new System.Drawing.Size(250, 19);
            this.tbDocument.TabIndex = 1;
            this.tbDocument.Text = "Documento";
            this.tbDocument.Enter += new System.EventHandler(this.tb_document_Enter);
            this.tbDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDocument_KeyPress);
            this.tbDocument.Leave += new System.EventHandler(this.tb_document_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.LightGray;
            this.tbPassword.Location = new System.Drawing.Point(29, 453);
            this.tbPassword.MaxLength = 45;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(250, 19);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // cb_docType
            // 
            this.cb_docType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.cb_docType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_docType.DataSource = this.tipoDocumentoBindingSource;
            this.cb_docType.DisplayMember = "TipoDocumento";
            this.cb_docType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_docType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_docType.ForeColor = System.Drawing.Color.White;
            this.cb_docType.FormattingEnabled = true;
            this.cb_docType.Location = new System.Drawing.Point(29, 367);
            this.cb_docType.Name = "cb_docType";
            this.cb_docType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_docType.Size = new System.Drawing.Size(250, 28);
            this.cb_docType.TabIndex = 0;
            this.cb_docType.ValueMember = "TipoDocumentoId";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.tablasDataSet;
            // 
            // tablasDataSet
            // 
            this.tablasDataSet.DataSetName = "TablasDataSet";
            this.tablasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // i_loanium
            // 
            this.i_loanium.Image = ((System.Drawing.Image)(resources.GetObject("i_loanium.Image")));
            this.i_loanium.Location = new System.Drawing.Point(12, 45);
            this.i_loanium.Name = "i_loanium";
            this.i_loanium.Size = new System.Drawing.Size(280, 280);
            this.i_loanium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.i_loanium.TabIndex = 47;
            this.i_loanium.TabStop = false;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_top.Controls.Add(this.btn_closeWindow);
            this.pnl_top.Controls.Add(this.btn_minimizeWindow);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(900, 25);
            this.pnl_top.TabIndex = 48;
            // 
            // btn_closeWindow
            // 
            this.btn_closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeWindow.ForeColor = System.Drawing.Color.Black;
            this.btn_closeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeWindow.Image")));
            this.btn_closeWindow.Location = new System.Drawing.Point(874, 0);
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
            this.btn_minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizeWindow.Image")));
            this.btn_minimizeWindow.Location = new System.Drawing.Point(845, 0);
            this.btn_minimizeWindow.Name = "btn_minimizeWindow";
            this.btn_minimizeWindow.Size = new System.Drawing.Size(23, 23);
            this.btn_minimizeWindow.TabIndex = 0;
            this.btn_minimizeWindow.UseVisualStyleBackColor = true;
            this.btn_minimizeWindow.Click += new System.EventHandler(this.btn_minimizeWindow_Click);
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 625);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(900, 25);
            this.pnl_bottom.TabIndex = 49;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.ln_document});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 650);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 447;
            this.lineShape4.X2 = 522;
            this.lineShape4.Y1 = 423;
            this.lineShape4.Y2 = 446;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 463;
            this.lineShape3.X2 = 538;
            this.lineShape3.Y1 = 356;
            this.lineShape3.Y2 = 379;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 317;
            this.lineShape2.X2 = 392;
            this.lineShape2.Y1 = 408;
            this.lineShape2.Y2 = 431;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 86;
            this.lineShape1.X2 = 161;
            this.lineShape1.Y1 = 431;
            this.lineShape1.Y2 = 454;
            // 
            // ln_document
            // 
            this.ln_document.BorderColor = System.Drawing.Color.White;
            this.ln_document.BorderWidth = 2;
            this.ln_document.Enabled = false;
            this.ln_document.Name = "ln_document";
            this.ln_document.X1 = 29;
            this.ln_document.X2 = 275;
            this.ln_document.Y1 = 428;
            this.ln_document.Y2 = 428;
            // 
            // ln_doc
            // 
            this.ln_doc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ln_doc.Enabled = false;
            this.ln_doc.Location = new System.Drawing.Point(29, 428);
            this.ln_doc.Name = "ln_doc";
            this.ln_doc.Size = new System.Drawing.Size(250, 2);
            this.ln_doc.TabIndex = 2;
            // 
            // ln_pass
            // 
            this.ln_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ln_pass.Enabled = false;
            this.ln_pass.Location = new System.Drawing.Point(29, 471);
            this.ln_pass.Name = "ln_pass";
            this.ln_pass.Size = new System.Drawing.Size(250, 2);
            this.ln_pass.TabIndex = 53;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // signUp1
            // 
            this.signUp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUp1.Location = new System.Drawing.Point(359, 155);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(391, 464);
            this.signUp1.TabIndex = 54;
            this.signUp1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.ln_pass);
            this.Controls.Add(this.ln_doc);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.i_loanium);
            this.Controls.Add(this.cb_docType);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbDocument);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.i_LoaniumBackground);
            this.Controls.Add(this.shapeContainer1);
            this.Controls.Add(this.signUp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.i_LoaniumBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_loanium)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox i_LoaniumBackground;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbDocument;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cb_docType;
        private System.Windows.Forms.PictureBox i_loanium;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_closeWindow;
        private System.Windows.Forms.Button btn_minimizeWindow;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape ln_document;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Label ln_doc;
        private System.Windows.Forms.Label ln_pass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TablasDataSet tablasDataSet;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private TablasDataSetTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private SignUp signUp1;
    }
}