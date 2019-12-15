namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class Donate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donate));
            this.lbl_donate = new System.Windows.Forms.Label();
            this.lblDonateD1 = new System.Windows.Forms.Label();
            this.lblDonateD3 = new System.Windows.Forms.Label();
            this.lbl_myDonations = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_materialType = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.i_menuBackground = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDonateD2 = new System.Windows.Forms.Label();
            this.tablasDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSet();
            this.tipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMaterialTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.TipoMaterialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_donate
            // 
            this.lbl_donate.AutoSize = true;
            this.lbl_donate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_donate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donate.Location = new System.Drawing.Point(298, 17);
            this.lbl_donate.Name = "lbl_donate";
            this.lbl_donate.Size = new System.Drawing.Size(196, 37);
            this.lbl_donate.TabIndex = 0;
            this.lbl_donate.Text = "Donaciones";
            // 
            // lblDonateD1
            // 
            this.lblDonateD1.AutoSize = true;
            this.lblDonateD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonateD1.Location = new System.Drawing.Point(27, 63);
            this.lblDonateD1.Name = "lblDonateD1";
            this.lblDonateD1.Size = new System.Drawing.Size(659, 40);
            this.lblDonateD1.TabIndex = 1;
            this.lblDonateD1.Text = "¿Tienes un libro que ya no uses, un disco que ya no te interesa o una revista que" +
    " ya no leas?\r\n ";
            // 
            // lblDonateD3
            // 
            this.lblDonateD3.AutoSize = true;
            this.lblDonateD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonateD3.Location = new System.Drawing.Point(9, 109);
            this.lblDonateD3.Name = "lblDonateD3";
            this.lblDonateD3.Size = new System.Drawing.Size(750, 40);
            this.lblDonateD3.TabIndex = 2;
            this.lblDonateD3.Text = "Muchas personas pueden resultar beneficiadas por tus articulos, una donación pued" +
    "e hacer la diferencia.\r\n\r\n";
            // 
            // lbl_myDonations
            // 
            this.lbl_myDonations.AutoSize = true;
            this.lbl_myDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_myDonations.Location = new System.Drawing.Point(255, 322);
            this.lbl_myDonations.Name = "lbl_myDonations";
            this.lbl_myDonations.Size = new System.Drawing.Size(253, 37);
            this.lbl_myDonations.TabIndex = 3;
            this.lbl_myDonations.Text = "Mis donaciones";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DataSource = this.tipoMaterialBindingSource;
            this.comboBox1.DisplayMember = "TipoMaterial";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "TipoMaterialId";
            // 
            // lbl_materialType
            // 
            this.lbl_materialType.AutoSize = true;
            this.lbl_materialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materialType.Location = new System.Drawing.Point(39, 156);
            this.lbl_materialType.Name = "lbl_materialType";
            this.lbl_materialType.Size = new System.Drawing.Size(167, 24);
            this.lbl_materialType.TabIndex = 6;
            this.lbl_materialType.Text = "Tipo de material:";
            this.lbl_materialType.Click += new System.EventHandler(this.lbl_materialType_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.Location = new System.Drawing.Point(305, 242);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(157, 35);
            this.btnDonate.TabIndex = 0;
            this.btnDonate.Text = "Donar";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btn_donate_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(750, 600);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 740;
            this.lineShape1.Y1 = 304;
            this.lineShape1.Y2 = 304;
            // 
            // i_menuBackground
            // 
            this.i_menuBackground.Image = ((System.Drawing.Image)(resources.GetObject("i_menuBackground.Image")));
            this.i_menuBackground.Location = new System.Drawing.Point(0, 0);
            this.i_menuBackground.Name = "i_menuBackground";
            this.i_menuBackground.Size = new System.Drawing.Size(750, 600);
            this.i_menuBackground.TabIndex = 9;
            this.i_menuBackground.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblDonateD2
            // 
            this.lblDonateD2.AutoSize = true;
            this.lblDonateD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonateD2.Location = new System.Drawing.Point(224, 83);
            this.lblDonateD2.Name = "lblDonateD2";
            this.lblDonateD2.Size = new System.Drawing.Size(313, 20);
            this.lblDonateD2.TabIndex = 11;
            this.lblDonateD2.Text = " ¡Aún puedes darle una nueva oportunidad!";
            // 
            // tablasDataSet
            // 
            this.tablasDataSet.DataSetName = "TablasDataSet";
            this.tablasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoMaterialBindingSource
            // 
            this.tipoMaterialBindingSource.DataMember = "TipoMaterial";
            this.tipoMaterialBindingSource.DataSource = this.tablasDataSet;
            // 
            // tipoMaterialTableAdapter
            // 
            this.tipoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // Donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDonateD2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.lbl_materialType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_myDonations);
            this.Controls.Add(this.lblDonateD3);
            this.Controls.Add(this.lblDonateD1);
            this.Controls.Add(this.lbl_donate);
            this.Controls.Add(this.shapeContainer1);
            this.Controls.Add(this.i_menuBackground);
            this.Name = "Donate";
            this.Size = new System.Drawing.Size(750, 600);
            this.Load += new System.EventHandler(this.Donate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_donate;
        private System.Windows.Forms.Label lblDonateD1;
        private System.Windows.Forms.Label lblDonateD3;
        private System.Windows.Forms.Label lbl_myDonations;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_materialType;
        private System.Windows.Forms.Button btnDonate;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox i_menuBackground;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDonateD2;
        private System.Windows.Forms.BindingSource tipoMaterialBindingSource;
        private TablasDataSet tablasDataSet;
        private TablasDataSetTableAdapters.TipoMaterialTableAdapter tipoMaterialTableAdapter;
    }
}
