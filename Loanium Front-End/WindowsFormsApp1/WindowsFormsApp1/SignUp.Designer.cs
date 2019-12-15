namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class SignUp
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblSNames = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDocType = new System.Windows.Forms.Label();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSet();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.btnWClose = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSNames = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNames = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDocType = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDocument = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.tbSNames = new System.Windows.Forms.TextBox();
            this.tbDocument = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCPassword = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbNames = new System.Windows.Forms.TextBox();
            this.tipoDocumentoTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.TipoDocumentoTableAdapter();
            this.bwRegister = new System.ComponentModel.BackgroundWorker();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoUsuarioTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.TipoUsuarioTableAdapter();
            this.lblUserType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDocType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(11, 16);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(273, 31);
            this.lblSignUp.TabIndex = 0;
            this.lblSignUp.Text = "Registro de Usuario";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(89, 67);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(75, 16);
            this.lblNames.TabIndex = 1;
            this.lblNames.Text = "* Nombres:";
            // 
            // lblSNames
            // 
            this.lblSNames.AutoSize = true;
            this.lblSNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNames.Location = new System.Drawing.Point(88, 97);
            this.lblSNames.Name = "lblSNames";
            this.lblSNames.Size = new System.Drawing.Size(76, 16);
            this.lblSNames.TabIndex = 2;
            this.lblSNames.Text = "* Apellidos:";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocument.Location = new System.Drawing.Point(76, 160);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(88, 16);
            this.lblDocument.TabIndex = 3;
            this.lblDocument.Text = "* Documento:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(36, 191);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(128, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "* Fecha Nacimiento:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(107, 222);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 16);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "* E-mail:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(76, 250);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 16);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "* Contraseña:";
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPassword.Location = new System.Drawing.Point(16, 284);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(148, 16);
            this.lblCPassword.TabIndex = 7;
            this.lblCPassword.Text = "* Confirmar Contraseña:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(99, 316);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(65, 16);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Teléfono:";
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(39, 414);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(314, 35);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocType.Location = new System.Drawing.Point(45, 129);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(119, 16);
            this.lblDocType.TabIndex = 19;
            this.lblDocType.Text = "* Tipo Documento:";
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoDocumentoBindingSource, "TipoDocumento", true));
            this.cbDocumentType.DataSource = this.tipoDocumentoBindingSource;
            this.cbDocumentType.DisplayMember = "TipoDocumento";
            this.cbDocumentType.FormattingEnabled = true;
            this.cbDocumentType.Location = new System.Drawing.Point(170, 124);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(171, 21);
            this.cbDocumentType.TabIndex = 2;
            this.cbDocumentType.ValueMember = "TipoDocumentoId";
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
            // dtpDateBirth
            // 
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBirth.Location = new System.Drawing.Point(170, 187);
            this.dtpDateBirth.MaxDate = new System.DateTime(2018, 9, 17, 10, 10, 50, 758);
            this.dtpDateBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(171, 20);
            this.dtpDateBirth.TabIndex = 4;
            this.dtpDateBirth.Value = new System.DateTime(2018, 9, 17, 0, 0, 0, 0);
            // 
            // btnWClose
            // 
            this.btnWClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWClose.FlatAppearance.BorderSize = 0;
            this.btnWClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(178)))), ((int)(((byte)(199)))));
            this.btnWClose.Image = ((System.Drawing.Image)(resources.GetObject("btnWClose.Image")));
            this.btnWClose.Location = new System.Drawing.Point(345, -1);
            this.btnWClose.Name = "btnWClose";
            this.btnWClose.Size = new System.Drawing.Size(26, 27);
            this.btnWClose.TabIndex = 11;
            this.btnWClose.UseVisualStyleBackColor = true;
            this.btnWClose.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(170, 218);
            this.tbMail.MaxLength = 45;
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(171, 20);
            this.tbMail.TabIndex = 5;
            this.tbMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMail_KeyPress);
            this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            this.epEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("epEmail.Icon")));
            // 
            // epSNames
            // 
            this.epSNames.ContainerControl = this;
            // 
            // epNames
            // 
            this.epNames.ContainerControl = this;
            // 
            // epDocType
            // 
            this.epDocType.ContainerControl = this;
            // 
            // epDocument
            // 
            this.epDocument.ContainerControl = this;
            // 
            // epDate
            // 
            this.epDate.ContainerControl = this;
            // 
            // epMail
            // 
            this.epMail.ContainerControl = this;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // epCPassword
            // 
            this.epCPassword.ContainerControl = this;
            // 
            // epTel
            // 
            this.epTel.ContainerControl = this;
            // 
            // chkTerms
            // 
            this.chkTerms.AutoSize = true;
            this.chkTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTerms.Location = new System.Drawing.Point(62, 378);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(239, 20);
            this.chkTerms.TabIndex = 9;
            this.chkTerms.Text = "Acepto los Términos y Condiciones";
            this.chkTerms.UseVisualStyleBackColor = true;
            this.chkTerms.CheckedChanged += new System.EventHandler(this.chkTerms_CheckedChanged);
            // 
            // tbSNames
            // 
            this.tbSNames.Location = new System.Drawing.Point(170, 93);
            this.tbSNames.MaxLength = 45;
            this.tbSNames.Name = "tbSNames";
            this.tbSNames.Size = new System.Drawing.Size(171, 20);
            this.tbSNames.TabIndex = 1;
            this.tbSNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSNames_KeyPress);
            this.tbSNames.Leave += new System.EventHandler(this.tbSNames_Leave);
            // 
            // tbDocument
            // 
            this.tbDocument.Location = new System.Drawing.Point(170, 156);
            this.tbDocument.MaxLength = 45;
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Size = new System.Drawing.Size(171, 20);
            this.tbDocument.TabIndex = 3;
            this.tbDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDocument_KeyPress);
            this.tbDocument.Leave += new System.EventHandler(this.tbDocument_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(170, 246);
            this.tbPassword.MaxLength = 45;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(171, 20);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbCPassword
            // 
            this.tbCPassword.Location = new System.Drawing.Point(170, 280);
            this.tbCPassword.MaxLength = 45;
            this.tbCPassword.Name = "tbCPassword";
            this.tbCPassword.PasswordChar = '*';
            this.tbCPassword.Size = new System.Drawing.Size(171, 20);
            this.tbCPassword.TabIndex = 7;
            this.tbCPassword.TextChanged += new System.EventHandler(this.tbCPassword_TextChanged);
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(170, 312);
            this.tbTel.MaxLength = 45;
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(171, 20);
            this.tbTel.TabIndex = 8;
            this.tbTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTel_KeyPress);
            // 
            // tbNames
            // 
            this.tbNames.Location = new System.Drawing.Point(170, 63);
            this.tbNames.MaxLength = 45;
            this.tbNames.Name = "tbNames";
            this.tbNames.Size = new System.Drawing.Size(171, 20);
            this.tbNames.TabIndex = 0;
            this.tbNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNames_KeyPress);
            this.tbNames.Leave += new System.EventHandler(this.tbNames_Leave);
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // bwRegister
            // 
            this.bwRegister.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRegister_DoWork);
            this.bwRegister.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRegister_RunWorkerCompleted);
            // 
            // cbUserType
            // 
            this.cbUserType.DataSource = this.tipoUsuarioBindingSource;
            this.cbUserType.DisplayMember = "TipoUsuario";
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Location = new System.Drawing.Point(170, 339);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(171, 21);
            this.cbUserType.TabIndex = 21;
            this.cbUserType.ValueMember = "TipoUsuarioId";
            this.cbUserType.Visible = false;
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "TipoUsuario";
            this.tipoUsuarioBindingSource.DataSource = this.tablasDataSet;
            // 
            // tipoUsuarioTableAdapter
            // 
            this.tipoUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(59, 340);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(105, 16);
            this.lblUserType.TabIndex = 22;
            this.lblUserType.Text = "Tipo de usuario:";
            this.lblUserType.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.cbUserType);
            this.Controls.Add(this.tbNames);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbCPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbDocument);
            this.Controls.Add(this.tbSNames);
            this.Controls.Add(this.chkTerms);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.dtpDateBirth);
            this.Controls.Add(this.cbDocumentType);
            this.Controls.Add(this.lblDocType);
            this.Controls.Add(this.btnWClose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblSNames);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblSignUp);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(391, 464);
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDocType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblSNames;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnWClose;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        public System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.ErrorProvider epSNames;
        private System.Windows.Forms.ErrorProvider epNames;
        private System.Windows.Forms.ErrorProvider epDocType;
        private System.Windows.Forms.ErrorProvider epDocument;
        private System.Windows.Forms.ErrorProvider epDate;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.ErrorProvider epCPassword;
        private System.Windows.Forms.ErrorProvider epTel;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.TextBox tbSNames;
        private System.Windows.Forms.TextBox tbDocument;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbCPassword;
        private System.Windows.Forms.TextBox tbNames;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private TablasDataSet tablasDataSet;
        private TablasDataSetTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.ComponentModel.BackgroundWorker bwRegister;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private TablasDataSetTableAdapters.TipoUsuarioTableAdapter tipoUsuarioTableAdapter;
    }
}
