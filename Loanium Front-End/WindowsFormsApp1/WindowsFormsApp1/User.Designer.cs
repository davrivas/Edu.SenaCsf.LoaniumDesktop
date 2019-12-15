namespace Edu.SenaCsf.LoaniumDesktop.Presentacion
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.lbl_Messages = new System.Windows.Forms.Label();
            this.i_menuBackground = new System.Windows.Forms.PictureBox();
            this.iMBTest = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserLock = new System.Windows.Forms.Button();
            this.signUp1 = new Edu.SenaCsf.LoaniumDesktop.Presentacion.SignUp();
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMBTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Messages
            // 
            this.lbl_Messages.AutoSize = true;
            this.lbl_Messages.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Messages.Location = new System.Drawing.Point(314, 35);
            this.lbl_Messages.Name = "lbl_Messages";
            this.lbl_Messages.Size = new System.Drawing.Size(130, 31);
            this.lbl_Messages.TabIndex = 36;
            this.lbl_Messages.Text = "Usuarios";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAdd.FlatAppearance.BorderSize = 0;
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAdd.Image")));
            this.btnUserAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAdd.Location = new System.Drawing.Point(100, 505);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(145, 80);
            this.btnUserAdd.TabIndex = 1;
            this.btnUserAdd.Text = "    Agregar";
            this.btnUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserEdit.FlatAppearance.BorderSize = 0;
            this.btnUserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserEdit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnUserEdit.Image")));
            this.btnUserEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserEdit.Location = new System.Drawing.Point(299, 505);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(145, 80);
            this.btnUserEdit.TabIndex = 2;
            this.btnUserEdit.Text = "    Editar";
            this.btnUserEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserEdit.UseVisualStyleBackColor = false;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnUserLock
            // 
            this.btnUserLock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserLock.FlatAppearance.BorderSize = 0;
            this.btnUserLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLock.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserLock.Image = ((System.Drawing.Image)(resources.GetObject("btnUserLock.Image")));
            this.btnUserLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserLock.Location = new System.Drawing.Point(505, 505);
            this.btnUserLock.Name = "btnUserLock";
            this.btnUserLock.Size = new System.Drawing.Size(145, 80);
            this.btnUserLock.TabIndex = 3;
            this.btnUserLock.Text = "    Bloquear";
            this.btnUserLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserLock.UseVisualStyleBackColor = false;
            // 
            // signUp1
            // 
            this.signUp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUp1.Location = new System.Drawing.Point(209, 39);
            this.signUp1.Name = "signUp1";
            this.signUp1.Size = new System.Drawing.Size(370, 450);
            this.signUp1.TabIndex = 57;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUserLock);
            this.Controls.Add(this.btnUserEdit);
            this.Controls.Add(this.btnUserAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Messages);
            this.Controls.Add(this.iMBTest);
            this.Controls.Add(this.i_menuBackground);
            this.Controls.Add(this.signUp1);
            this.Name = "User";
            this.Size = new System.Drawing.Size(750, 600);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.i_menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMBTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Messages;
        private System.Windows.Forms.PictureBox i_menuBackground;
        private System.Windows.Forms.PictureBox iMBTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserLock;
        private SignUp signUp1;
    }
}
