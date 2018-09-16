namespace Edu.SenaCsf.LoaniumDesktop.Presentacion {
    partial class NuevoMaterial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoMaterial = new System.Windows.Forms.ComboBox();
            this.tipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMaterialDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TipoMaterialDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoMaterialTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TipoMaterialDataSetTableAdapters.TipoMaterialTableAdapter();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.idiomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idiomaDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.IdiomaDataSet();
            this.idiomaTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.IdiomaDataSetTableAdapters.IdiomaTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTematica = new System.Windows.Forms.ComboBox();
            this.tematicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxEditorial = new System.Windows.Forms.TextBox();
            this.textBoxIssn = new System.Windows.Forms.TextBox();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.tematicaTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.LoaniumDataSetTableAdapters.TematicaTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.loaniumDataSet1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.LoaniumDataSet();
            this.loaniumDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tematicaSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TematicaSet();
            this.tematicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tematicaTableAdapter1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TematicaSetTableAdapters.TematicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaniumDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaniumDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(127, 10);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(200, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(127, 40);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(200, 20);
            this.textBoxAutor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor";
            // 
            // fechaPublicacion
            // 
            this.fechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaPublicacion.Location = new System.Drawing.Point(127, 66);
            this.fechaPublicacion.Name = "fechaPublicacion";
            this.fechaPublicacion.Size = new System.Drawing.Size(200, 20);
            this.fechaPublicacion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de publicacion";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(127, 92);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(200, 83);
            this.textBoxDescripcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion";
            // 
            // comboBoxTipoMaterial
            // 
            this.comboBoxTipoMaterial.DataSource = this.tipoMaterialBindingSource;
            this.comboBoxTipoMaterial.DisplayMember = "TipoMaterial";
            this.comboBoxTipoMaterial.FormattingEnabled = true;
            this.comboBoxTipoMaterial.Location = new System.Drawing.Point(455, 9);
            this.comboBoxTipoMaterial.Name = "comboBoxTipoMaterial";
            this.comboBoxTipoMaterial.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipoMaterial.TabIndex = 8;
            this.comboBoxTipoMaterial.ValueMember = "TipoMaterialId";
            // 
            // tipoMaterialBindingSource
            // 
            this.tipoMaterialBindingSource.DataMember = "TipoMaterial";
            this.tipoMaterialBindingSource.DataSource = this.tipoMaterialDataSet;
            // 
            // tipoMaterialDataSet
            // 
            this.tipoMaterialDataSet.DataSetName = "TipoMaterialDataSet";
            this.tipoMaterialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo material";
            // 
            // tipoMaterialTableAdapter
            // 
            this.tipoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DataSource = this.idiomaBindingSource;
            this.comboBoxIdioma.DisplayMember = "NombreIdioma";
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Location = new System.Drawing.Point(127, 181);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIdioma.TabIndex = 10;
            this.comboBoxIdioma.ValueMember = "IdiomaId";
            // 
            // idiomaBindingSource
            // 
            this.idiomaBindingSource.DataMember = "Idioma";
            this.idiomaBindingSource.DataSource = this.idiomaDataSet;
            // 
            // idiomaDataSet
            // 
            this.idiomaDataSet.DataSetName = "IdiomaDataSet";
            this.idiomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomaTableAdapter
            // 
            this.idiomaTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Idioma";
            // 
            // comboBoxTematica
            // 
            this.comboBoxTematica.DataSource = this.tematicaBindingSource1;
            this.comboBoxTematica.DisplayMember = "Tematica";
            this.comboBoxTematica.FormattingEnabled = true;
            this.comboBoxTematica.Location = new System.Drawing.Point(127, 208);
            this.comboBoxTematica.Name = "comboBoxTematica";
            this.comboBoxTematica.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTematica.TabIndex = 12;
            this.comboBoxTematica.ValueMember = "TematicaId";
            // 
            // tematicaBindingSource
            // 
            this.tematicaBindingSource.DataMember = "Tematica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tematica";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(455, 36);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(200, 20);
            this.textBoxIsbn.TabIndex = 14;
            // 
            // textBoxEditorial
            // 
            this.textBoxEditorial.Location = new System.Drawing.Point(455, 63);
            this.textBoxEditorial.Name = "textBoxEditorial";
            this.textBoxEditorial.Size = new System.Drawing.Size(200, 20);
            this.textBoxEditorial.TabIndex = 15;
            // 
            // textBoxIssn
            // 
            this.textBoxIssn.Location = new System.Drawing.Point(455, 88);
            this.textBoxIssn.Name = "textBoxIssn";
            this.textBoxIssn.Size = new System.Drawing.Size(200, 20);
            this.textBoxIssn.TabIndex = 16;
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Location = new System.Drawing.Point(455, 114);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(200, 20);
            this.textBoxDuracion.TabIndex = 17;
            // 
            // tematicaTableAdapter
            // 
            this.tematicaTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Editorial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "ISSN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Duración (min)";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(415, 151);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 22;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // loaniumDataSet1
            // 
            this.loaniumDataSet1.DataSetName = "LoaniumDataSet";
            this.loaniumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaniumDataSet1BindingSource
            // 
            this.loaniumDataSet1BindingSource.DataSource = this.loaniumDataSet1;
            this.loaniumDataSet1BindingSource.Position = 0;
            // 
            // tematicaSet
            // 
            this.tematicaSet.DataSetName = "TematicaSet";
            this.tematicaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tematicaBindingSource1
            // 
            this.tematicaBindingSource1.DataMember = "Tematica";
            this.tematicaBindingSource1.DataSource = this.tematicaSet;
            // 
            // tematicaTableAdapter1
            // 
            this.tematicaTableAdapter1.ClearBeforeFill = true;
            // 
            // NuevoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.textBoxIssn);
            this.Controls.Add(this.textBoxEditorial);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTematica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipoMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label1);
            this.Name = "NuevoMaterial";
            this.Text = "NuevoMaterial";
            this.Load += new System.EventHandler(this.NuevoMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaniumDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaniumDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoMaterial;
        private System.Windows.Forms.Label label5;
        private TipoMaterialDataSet tipoMaterialDataSet;
        private System.Windows.Forms.BindingSource tipoMaterialBindingSource;
        private TipoMaterialDataSetTableAdapters.TipoMaterialTableAdapter tipoMaterialTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private IdiomaDataSet idiomaDataSet;
        private System.Windows.Forms.BindingSource idiomaBindingSource;
        private IdiomaDataSetTableAdapters.IdiomaTableAdapter idiomaTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTematica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxEditorial;
        private System.Windows.Forms.TextBox textBoxIssn;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private TematicaDataSet tematicaDataSet;
        private System.Windows.Forms.BindingSource tematicaBindingSource;
        private LoaniumDataSetTableAdapters.TematicaTableAdapter tematicaTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonIngresar;
        private LoaniumDataSet loaniumDataSet1;
        private System.Windows.Forms.BindingSource loaniumDataSet1BindingSource;
        private TematicaSet tematicaSet;
        private System.Windows.Forms.BindingSource tematicaBindingSource1;
        private TematicaSetTableAdapters.TematicaTableAdapter tematicaTableAdapter1;
    }
}