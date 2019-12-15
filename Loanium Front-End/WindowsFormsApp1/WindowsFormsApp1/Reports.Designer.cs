namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.i_menuBackground = new System.Windows.Forms.PictureBox();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnSumUser = new System.Windows.Forms.Button();
            this.btnSumBook = new System.Windows.Forms.Button();
            this.btnSumCD = new System.Windows.Forms.Button();
            this.btnSumMagazine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasDataSet = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbUsuarios = new System.Windows.Forms.RichTextBox();
            this.rtbDiscos = new System.Windows.Forms.RichTextBox();
            this.rtbRevistas = new System.Windows.Forms.RichTextBox();
            this.rtbLibros = new System.Windows.Forms.RichTextBox();
            this.materialTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.MaterialTableAdapter();
            this.usuarioTableAdapter = new Edu.SenaCsf.LoaniumDesktop.Presentacion.TablasDataSetTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // i_menuBackground
            // 
            this.i_menuBackground.Image = ((System.Drawing.Image)(resources.GetObject("i_menuBackground.Image")));
            this.i_menuBackground.Location = new System.Drawing.Point(0, 0);
            this.i_menuBackground.Name = "i_menuBackground";
            this.i_menuBackground.Size = new System.Drawing.Size(750, 600);
            this.i_menuBackground.TabIndex = 0;
            this.i_menuBackground.TabStop = false;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.BackColor = System.Drawing.SystemColors.Control;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReports.Location = new System.Drawing.Point(322, 47);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(133, 31);
            this.lblReports.TabIndex = 57;
            this.lblReports.Text = "Reportes";
            // 
            // btnSumUser
            // 
            this.btnSumUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSumUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSumUser.FlatAppearance.BorderSize = 0;
            this.btnSumUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSumUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSumUser.Image")));
            this.btnSumUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSumUser.Location = new System.Drawing.Point(420, 140);
            this.btnSumUser.Name = "btnSumUser";
            this.btnSumUser.Size = new System.Drawing.Size(145, 80);
            this.btnSumUser.TabIndex = 61;
            this.btnSumUser.Text = "  Usuarios";
            this.btnSumUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSumUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSumUser.UseVisualStyleBackColor = false;
            // 
            // btnSumBook
            // 
            this.btnSumBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSumBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSumBook.FlatAppearance.BorderSize = 0;
            this.btnSumBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSumBook.Image = ((System.Drawing.Image)(resources.GetObject("btnSumBook.Image")));
            this.btnSumBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSumBook.Location = new System.Drawing.Point(571, 140);
            this.btnSumBook.Name = "btnSumBook";
            this.btnSumBook.Size = new System.Drawing.Size(145, 80);
            this.btnSumBook.TabIndex = 62;
            this.btnSumBook.Text = "    Libros";
            this.btnSumBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSumBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSumBook.UseVisualStyleBackColor = false;
            // 
            // btnSumCD
            // 
            this.btnSumCD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSumCD.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSumCD.FlatAppearance.BorderSize = 0;
            this.btnSumCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumCD.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSumCD.Image = ((System.Drawing.Image)(resources.GetObject("btnSumCD.Image")));
            this.btnSumCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSumCD.Location = new System.Drawing.Point(420, 226);
            this.btnSumCD.Name = "btnSumCD";
            this.btnSumCD.Size = new System.Drawing.Size(145, 80);
            this.btnSumCD.TabIndex = 63;
            this.btnSumCD.Text = "    Discos";
            this.btnSumCD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSumCD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSumCD.UseVisualStyleBackColor = false;
            // 
            // btnSumMagazine
            // 
            this.btnSumMagazine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSumMagazine.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSumMagazine.FlatAppearance.BorderSize = 0;
            this.btnSumMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumMagazine.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSumMagazine.Image = ((System.Drawing.Image)(resources.GetObject("btnSumMagazine.Image")));
            this.btnSumMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSumMagazine.Location = new System.Drawing.Point(571, 226);
            this.btnSumMagazine.Name = "btnSumMagazine";
            this.btnSumMagazine.Size = new System.Drawing.Size(145, 80);
            this.btnSumMagazine.TabIndex = 64;
            this.btnSumMagazine.Text = "  Revistas";
            this.btnSumMagazine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSumMagazine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSumMagazine.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(527, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Sumario";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.materialBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 140);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(335, 412);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.tablasDataSet;
            // 
            // tablasDataSet
            // 
            this.tablasDataSet.DataSetName = "TablasDataSet";
            this.tablasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(75, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Prestamos por Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(505, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Donaciones";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.usuarioBindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(396, 392);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(337, 160);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.tablasDataSet;
            // 
            // rtbUsuarios
            // 
            this.rtbUsuarios.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbUsuarios.Location = new System.Drawing.Point(488, 179);
            this.rtbUsuarios.Name = "rtbUsuarios";
            this.rtbUsuarios.Size = new System.Drawing.Size(66, 26);
            this.rtbUsuarios.TabIndex = 74;
            this.rtbUsuarios.Text = "123,456";
            // 
            // rtbDiscos
            // 
            this.rtbDiscos.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbDiscos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDiscos.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbDiscos.Location = new System.Drawing.Point(488, 262);
            this.rtbDiscos.Name = "rtbDiscos";
            this.rtbDiscos.Size = new System.Drawing.Size(66, 26);
            this.rtbDiscos.TabIndex = 75;
            this.rtbDiscos.Text = "123,456";
            // 
            // rtbRevistas
            // 
            this.rtbRevistas.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbRevistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRevistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRevistas.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbRevistas.Location = new System.Drawing.Point(641, 262);
            this.rtbRevistas.Name = "rtbRevistas";
            this.rtbRevistas.Size = new System.Drawing.Size(75, 26);
            this.rtbRevistas.TabIndex = 76;
            this.rtbRevistas.Text = "123,456";
            // 
            // rtbLibros
            // 
            this.rtbLibros.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLibros.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbLibros.Location = new System.Drawing.Point(641, 179);
            this.rtbLibros.Name = "rtbLibros";
            this.rtbLibros.Size = new System.Drawing.Size(75, 26);
            this.rtbLibros.TabIndex = 77;
            this.rtbLibros.Text = "123,456";
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbLibros);
            this.Controls.Add(this.rtbRevistas);
            this.Controls.Add(this.rtbDiscos);
            this.Controls.Add(this.rtbUsuarios);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnSumMagazine);
            this.Controls.Add(this.btnSumCD);
            this.Controls.Add(this.btnSumBook);
            this.Controls.Add(this.btnSumUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.i_menuBackground);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(750, 600);
            this.Load += new System.EventHandler(this.MyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox i_menuBackground;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Button btnSumUser;
        private System.Windows.Forms.Button btnSumBook;
        private System.Windows.Forms.Button btnSumCD;
        private System.Windows.Forms.Button btnSumMagazine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.RichTextBox rtbUsuarios;
        private System.Windows.Forms.RichTextBox rtbDiscos;
        private System.Windows.Forms.RichTextBox rtbRevistas;
        private System.Windows.Forms.RichTextBox rtbLibros;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private TablasDataSet tablasDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private TablasDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private TablasDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
    }
}
