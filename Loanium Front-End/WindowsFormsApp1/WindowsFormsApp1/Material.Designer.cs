namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class Material {

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        public void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material));
            this.lbl_Material = new System.Windows.Forms.Label();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblThematic = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnWClose = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.tipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSet();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbISSN = new System.Windows.Forms.TextBox();
            this.lblISSN = new System.Windows.Forms.Label();
            this.tbLenght = new System.Windows.Forms.TextBox();
            this.lblLenght = new System.Windows.Forms.Label();
            this.tipoMaterialTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.TipoMaterialTableAdapter();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.idiomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLang = new System.Windows.Forms.Label();
            this.cbThematic = new System.Windows.Forms.ComboBox();
            this.tematicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMaterialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idiomaTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.IdiomaTableAdapter();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateP = new System.Windows.Forms.Label();
            this.dtpDateP = new System.Windows.Forms.DateTimePicker();
            this.tematicaTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.TematicaTableAdapter();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Material
            // 
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Material.Location = new System.Drawing.Point(11, 16);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(210, 31);
            this.lbl_Material.TabIndex = 0;
            this.lbl_Material.Text = "Nuevo Material";
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(43, 97);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(125, 20);
            this.lblMaterialType.TabIndex = 1;
            this.lblMaterialType.Text = "Tipo de material:";
            this.lblMaterialType.Visible = false;
            // 
            // lblThematic
            // 
            this.lblThematic.AutoSize = true;
            this.lblThematic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThematic.Location = new System.Drawing.Point(90, 131);
            this.lblThematic.Name = "lblThematic";
            this.lblThematic.Size = new System.Drawing.Size(78, 20);
            this.lblThematic.TabIndex = 2;
            this.lblThematic.Text = "Temática:";
            this.lblThematic.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(72, 259);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descripción:";
            this.lblDescription.Visible = false;
            // 
            // btnMaterial
            // 
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.Location = new System.Drawing.Point(26, 460);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(314, 35);
            this.btnMaterial.TabIndex = 5;
            this.btnMaterial.Text = "Agregar Material";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(116, 197);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 20);
            this.lblAuthor.TabIndex = 19;
            this.lblAuthor.Text = "Autor:";
            this.lblAuthor.Visible = false;
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
            this.btnWClose.TabIndex = 6;
            this.btnWClose.UseVisualStyleBackColor = true;
            this.btnWClose.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(116, 385);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(51, 20);
            this.lblISBN.TabIndex = 27;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.Visible = false;
            // 
            // cbMaterial
            // 
            this.cbMaterial.DataSource = this.tipoMaterialBindingSource;
            this.cbMaterial.DisplayMember = "TipoMaterial";
            this.cbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(174, 94);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(180, 28);
            this.cbMaterial.TabIndex = 0;
            this.cbMaterial.ValueMember = "TipoMaterialId";
            this.cbMaterial.Visible = false;
            this.cbMaterial.SelectedValueChanged += new System.EventHandler(this.cbMaterial_SelectedValueChanged);
            // 
            // tipoMaterialBindingSource
            // 
            this.tipoMaterialBindingSource.DataMember = "TipoMaterial";
            this.tipoMaterialBindingSource.DataSource = this.tablasDataSet;
            // 
            // tablasDataSet
            // 
            this.tablasDataSet.DataSetName = "TablasDataSet";
            this.tablasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.Location = new System.Drawing.Point(174, 194);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(180, 26);
            this.tbAuthor.TabIndex = 2;
            this.tbAuthor.Visible = false;
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(174, 256);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(180, 86);
            this.tbDesc.TabIndex = 3;
            this.tbDesc.Visible = false;
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.Location = new System.Drawing.Point(174, 382);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(180, 26);
            this.tbISBN.TabIndex = 4;
            this.tbISBN.Visible = false;
            // 
            // tbISSN
            // 
            this.tbISSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISSN.Location = new System.Drawing.Point(174, 382);
            this.tbISSN.Name = "tbISSN";
            this.tbISSN.Size = new System.Drawing.Size(180, 26);
            this.tbISSN.TabIndex = 28;
            this.tbISSN.Visible = false;
            // 
            // lblISSN
            // 
            this.lblISSN.AutoSize = true;
            this.lblISSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISSN.Location = new System.Drawing.Point(116, 385);
            this.lblISSN.Name = "lblISSN";
            this.lblISSN.Size = new System.Drawing.Size(51, 20);
            this.lblISSN.TabIndex = 29;
            this.lblISSN.Text = "ISSN:";
            this.lblISSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblISSN.Visible = false;
            // 
            // tbLenght
            // 
            this.tbLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLenght.Location = new System.Drawing.Point(174, 382);
            this.tbLenght.Name = "tbLenght";
            this.tbLenght.Size = new System.Drawing.Size(180, 26);
            this.tbLenght.TabIndex = 30;
            this.tbLenght.Visible = false;
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenght.Location = new System.Drawing.Point(91, 385);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(77, 20);
            this.lblLenght.TabIndex = 31;
            this.lblLenght.Text = "Duración:";
            this.lblLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLenght.Visible = false;
            // 
            // tipoMaterialTableAdapter
            // 
            this.tipoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // tbEdit
            // 
            this.tbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdit.Location = new System.Drawing.Point(174, 414);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(180, 26);
            this.tbEdit.TabIndex = 32;
            this.tbEdit.Visible = false;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(97, 417);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(70, 20);
            this.lblEdit.TabIndex = 33;
            this.lblEdit.Text = "Editorial:";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEdit.Visible = false;
            // 
            // cbLang
            // 
            this.cbLang.DataSource = this.idiomaBindingSource;
            this.cbLang.DisplayMember = "NombreIdioma";
            this.cbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(174, 348);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(180, 28);
            this.cbLang.TabIndex = 34;
            this.cbLang.ValueMember = "IdiomaId";
            this.cbLang.Visible = false;
            // 
            // idiomaBindingSource
            // 
            this.idiomaBindingSource.DataMember = "Idioma";
            this.idiomaBindingSource.DataSource = this.tablasDataSet;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.Location = new System.Drawing.Point(107, 351);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(61, 20);
            this.lblLang.TabIndex = 35;
            this.lblLang.Text = "Idioma:";
            this.lblLang.Visible = false;
            // 
            // cbThematic
            // 
            this.cbThematic.DataSource = this.tematicaBindingSource;
            this.cbThematic.DisplayMember = "Tematica";
            this.cbThematic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThematic.FormattingEnabled = true;
            this.cbThematic.Location = new System.Drawing.Point(174, 128);
            this.cbThematic.Name = "cbThematic";
            this.cbThematic.Size = new System.Drawing.Size(180, 28);
            this.cbThematic.TabIndex = 38;
            this.cbThematic.ValueMember = "TematicaId";
            this.cbThematic.Visible = false;
            // 
            // tematicaBindingSource
            // 
            this.tematicaBindingSource.DataMember = "Tematica";
            this.tematicaBindingSource.DataSource = this.tablasDataSet;
            // 
            // tipoMaterialBindingSource1
            // 
            this.tipoMaterialBindingSource1.DataMember = "TipoMaterial";
            this.tipoMaterialBindingSource1.DataSource = this.tablasDataSet;
            // 
            // idiomaTableAdapter
            // 
            this.idiomaTableAdapter.ClearBeforeFill = true;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(174, 162);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(180, 26);
            this.tbTitle.TabIndex = 39;
            this.tbTitle.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(116, 165);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 20);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Título:";
            this.lblTitle.Visible = false;
            // 
            // lblDateP
            // 
            this.lblDateP.AutoSize = true;
            this.lblDateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateP.Location = new System.Drawing.Point(5, 230);
            this.lblDateP.Name = "lblDateP";
            this.lblDateP.Size = new System.Drawing.Size(163, 20);
            this.lblDateP.TabIndex = 41;
            this.lblDateP.Text = "Fecha de publicación:";
            this.lblDateP.Visible = false;
            // 
            // dtpDateP
            // 
            this.dtpDateP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateP.Location = new System.Drawing.Point(174, 230);
            this.dtpDateP.Name = "dtpDateP";
            this.dtpDateP.Size = new System.Drawing.Size(180, 20);
            this.dtpDateP.TabIndex = 42;
            this.dtpDateP.Visible = false;
            // 
            // tematicaTableAdapter
            // 
            this.tematicaTableAdapter.ClearBeforeFill = true;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(55, 59);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(218, 26);
            this.tbId.TabIndex = 43;
            this.tbId.WordWrap = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(22, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(279, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtpDateP);
            this.Controls.Add(this.lblDateP);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbThematic);
            this.Controls.Add(this.cbLang);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.tbLenght);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.tbISSN);
            this.Controls.Add(this.lblISSN);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnWClose);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblThematic);
            this.Controls.Add(this.lblMaterialType);
            this.Controls.Add(this.lbl_Material);
            this.Name = "Material";
            this.Size = new System.Drawing.Size(370, 513);
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Material;
        public System.Windows.Forms.Label lblMaterialType;
        public System.Windows.Forms.Label lblThematic;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Button btnMaterial;
        public System.Windows.Forms.Button btnWClose;
        public System.Windows.Forms.Label lblAuthor;
        public System.Windows.Forms.Label lblISBN;
        public System.Windows.Forms.ComboBox cbMaterial;
        public System.Windows.Forms.TextBox tbAuthor;
        public System.Windows.Forms.TextBox tbDesc;
        public System.Windows.Forms.TextBox tbISBN;
        public System.Windows.Forms.TextBox tbISSN;
        public System.Windows.Forms.Label lblISSN;
        public System.Windows.Forms.TextBox tbLenght;
        public System.Windows.Forms.Label lblLenght;
        public System.Windows.Forms.BindingSource tipoMaterialBindingSource;
        public TablasDataSet tablasDataSet;
        public TablasDataSetTableAdapters.TipoMaterialTableAdapter tipoMaterialTableAdapter;
        public System.Windows.Forms.TextBox tbEdit;
        public System.Windows.Forms.Label lblEdit;
        public System.Windows.Forms.ComboBox cbLang;
        public System.Windows.Forms.Label lblLang;
        public System.Windows.Forms.ComboBox cbThematic;
        public System.Windows.Forms.BindingSource tipoMaterialBindingSource1;
        public System.Windows.Forms.BindingSource idiomaBindingSource;
        public TablasDataSetTableAdapters.IdiomaTableAdapter idiomaTableAdapter;
        public System.Windows.Forms.TextBox tbTitle;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDateP;
        public System.Windows.Forms.DateTimePicker dtpDateP;
        public System.Windows.Forms.BindingSource tematicaBindingSource;
        public TablasDataSetTableAdapters.TematicaTableAdapter tematicaTableAdapter;
        public System.Windows.Forms.TextBox tbId;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.IContainer components;
    }
}
