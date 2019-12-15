namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.lblDocType = new System.Windows.Forms.Label();
            this.btnProfileSave = new System.Windows.Forms.Button();
            this.lblEProfile = new System.Windows.Forms.Label();
            this.tbETel = new System.Windows.Forms.TextBox();
            this.tbCPass = new System.Windows.Forms.TextBox();
            this.tbEPass = new System.Windows.Forms.TextBox();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.tbEDoc = new System.Windows.Forms.TextBox();
            this.tbESNames = new System.Windows.Forms.TextBox();
            this.tbENames = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCPass = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblSNames = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.i_menuBackground = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblEChangePass = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.tablasDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSet();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocumentoTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.TipoDocumentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDocType
            // 
            this.cbDocType.DataSource = this.tipoDocumentoBindingSource;
            this.cbDocType.DisplayMember = "TipoDocumento";
            this.cbDocType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Location = new System.Drawing.Point(158, 168);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(200, 21);
            this.cbDocType.TabIndex = 1;
            this.cbDocType.ValueMember = "TipoDocumentoId";
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDocType.Location = new System.Drawing.Point(33, 170);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(130, 20);
            this.lblDocType.TabIndex = 59;
            this.lblDocType.Text = "Tipo Documento:";
            // 
            // btnProfileSave
            // 
            this.btnProfileSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileSave.Location = new System.Drawing.Point(104, 283);
            this.btnProfileSave.Name = "btnProfileSave";
            this.btnProfileSave.Size = new System.Drawing.Size(230, 35);
            this.btnProfileSave.TabIndex = 10;
            this.btnProfileSave.Text = "Guardar";
            this.btnProfileSave.UseVisualStyleBackColor = true;
            // 
            // lblEProfile
            // 
            this.lblEProfile.AutoSize = true;
            this.lblEProfile.BackColor = System.Drawing.SystemColors.Control;
            this.lblEProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEProfile.Location = new System.Drawing.Point(332, 69);
            this.lblEProfile.Name = "lblEProfile";
            this.lblEProfile.Size = new System.Drawing.Size(167, 31);
            this.lblEProfile.TabIndex = 57;
            this.lblEProfile.Text = "Editar Perfil";
            // 
            // tbETel
            // 
            this.tbETel.Location = new System.Drawing.Point(526, 268);
            this.tbETel.MaxLength = 25;
            this.tbETel.Name = "tbETel";
            this.tbETel.Size = new System.Drawing.Size(200, 20);
            this.tbETel.TabIndex = 9;
            // 
            // tbCPass
            // 
            this.tbCPass.Location = new System.Drawing.Point(535, 487);
            this.tbCPass.MaxLength = 45;
            this.tbCPass.Name = "tbCPass";
            this.tbCPass.PasswordChar = '*';
            this.tbCPass.Size = new System.Drawing.Size(200, 20);
            this.tbCPass.TabIndex = 4;
            // 
            // tbEPass
            // 
            this.tbEPass.Location = new System.Drawing.Point(172, 438);
            this.tbEPass.Name = "tbEPass";
            this.tbEPass.PasswordChar = '*';
            this.tbEPass.Size = new System.Drawing.Size(200, 20);
            this.tbEPass.TabIndex = 3;
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(528, 223);
            this.tbEMail.MaxLength = 100;
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(200, 20);
            this.tbEMail.TabIndex = 7;
            // 
            // tbEDoc
            // 
            this.tbEDoc.Location = new System.Drawing.Point(528, 171);
            this.tbEDoc.MaxLength = 45;
            this.tbEDoc.Name = "tbEDoc";
            this.tbEDoc.Size = new System.Drawing.Size(200, 20);
            this.tbEDoc.TabIndex = 6;
            // 
            // tbESNames
            // 
            this.tbESNames.Location = new System.Drawing.Point(528, 122);
            this.tbESNames.MaxLength = 45;
            this.tbESNames.Name = "tbESNames";
            this.tbESNames.Size = new System.Drawing.Size(200, 20);
            this.tbESNames.TabIndex = 5;
            // 
            // tbENames
            // 
            this.tbENames.Location = new System.Drawing.Point(158, 119);
            this.tbENames.MaxLength = 45;
            this.tbENames.Name = "tbENames";
            this.tbENames.Size = new System.Drawing.Size(200, 20);
            this.tbENames.TabIndex = 0;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTel.Location = new System.Drawing.Point(452, 270);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(75, 20);
            this.lblTel.TabIndex = 48;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblCPass
            // 
            this.lblCPass.AutoSize = true;
            this.lblCPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCPass.Location = new System.Drawing.Point(374, 486);
            this.lblCPass.Name = "lblCPass";
            this.lblCPass.Size = new System.Drawing.Size(169, 20);
            this.lblCPass.TabIndex = 47;
            this.lblCPass.Text = "Confirmar Contraseña:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPass.Location = new System.Drawing.Point(35, 440);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(145, 20);
            this.lblPass.TabIndex = 46;
            this.lblPass.Text = "Contraseña Actual:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMail.Location = new System.Drawing.Point(469, 224);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 20);
            this.lblMail.TabIndex = 45;
            this.lblMail.Text = "E-mail:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(23, 224);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(141, 20);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Fecha Nacimiento:";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoc.Location = new System.Drawing.Point(435, 170);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(96, 20);
            this.lblDoc.TabIndex = 43;
            this.lblDoc.Text = "Documento:";
            // 
            // lblSNames
            // 
            this.lblSNames.AutoSize = true;
            this.lblSNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSNames.Location = new System.Drawing.Point(452, 121);
            this.lblSNames.Name = "lblSNames";
            this.lblSNames.Size = new System.Drawing.Size(77, 20);
            this.lblSNames.TabIndex = 42;
            this.lblSNames.Text = "Apellidos:";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNames.Location = new System.Drawing.Point(81, 121);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(77, 20);
            this.lblNames.TabIndex = 41;
            this.lblNames.Text = "Nombres:";
            // 
            // i_menuBackground
            // 
            this.i_menuBackground.Image = ((System.Drawing.Image)(resources.GetObject("i_menuBackground.Image")));
            this.i_menuBackground.Location = new System.Drawing.Point(0, 0);
            this.i_menuBackground.Name = "i_menuBackground";
            this.i_menuBackground.Size = new System.Drawing.Size(750, 600);
            this.i_menuBackground.TabIndex = 61;
            this.i_menuBackground.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(542, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(406, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nueva Contraseña:";
            // 
            // dtpEDateBirth
            // 
            this.dtpEDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEDateBirth.Location = new System.Drawing.Point(158, 222);
            this.dtpEDateBirth.Name = "dtpEDateBirth";
            this.dtpEDateBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpEDateBirth.TabIndex = 63;
            this.dtpEDateBirth.Value = new System.DateTime(2018, 9, 20, 16, 20, 8, 0);
            // 
            // lblEChangePass
            // 
            this.lblEChangePass.AutoSize = true;
            this.lblEChangePass.BackColor = System.Drawing.SystemColors.Control;
            this.lblEChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEChangePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEChangePass.Location = new System.Drawing.Point(255, 370);
            this.lblEChangePass.Name = "lblEChangePass";
            this.lblEChangePass.Size = new System.Drawing.Size(276, 31);
            this.lblEChangePass.TabIndex = 64;
            this.lblEChangePass.Text = "Cambiar contraseña";
            // 
            // btnChangePass
            // 
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(94, 486);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(230, 35);
            this.btnChangePass.TabIndex = 65;
            this.btnChangePass.Text = "Cambiar";
            this.btnChangePass.UseVisualStyleBackColor = true;
            // 
            // tablasDataSet
            // 
            this.tablasDataSet.DataSetName = "TablasDataSet";
            this.tablasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.tablasDataSet;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.lblEChangePass);
            this.Controls.Add(this.dtpEDateBirth);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDocType);
            this.Controls.Add(this.lblDocType);
            this.Controls.Add(this.btnProfileSave);
            this.Controls.Add(this.lblEProfile);
            this.Controls.Add(this.tbETel);
            this.Controls.Add(this.tbCPass);
            this.Controls.Add(this.tbEPass);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbEDoc);
            this.Controls.Add(this.tbESNames);
            this.Controls.Add(this.tbENames);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblSNames);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.i_menuBackground);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(750, 600);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDocType;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.Button btnProfileSave;
        private System.Windows.Forms.Label lblEProfile;
        private System.Windows.Forms.TextBox tbETel;
        private System.Windows.Forms.TextBox tbCPass;
        private System.Windows.Forms.TextBox tbEPass;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.TextBox tbEDoc;
        private System.Windows.Forms.TextBox tbESNames;
        private System.Windows.Forms.TextBox tbENames;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblSNames;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.PictureBox i_menuBackground;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEDateBirth;
        private System.Windows.Forms.Label lblEChangePass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private TablasDataSet tablasDataSet;
        private TablasDataSetTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
    }
}
