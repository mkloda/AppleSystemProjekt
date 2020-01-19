namespace AppleSystem
{
    partial class frmSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgTypeList = new System.Windows.Forms.DataGridView();
            this.Unit = new System.Windows.Forms.TextBox();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.btnTypeDelete = new System.Windows.Forms.Button();
            this.btnTypeUpdate = new System.Windows.Forms.Button();
            this.btnTypeLoad = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnUnitLoad = new System.Windows.Forms.Button();
            this.dtgUnitList = new System.Windows.Forms.DataGridView();
            this.btnTypeAdd = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnit = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnitList)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTypeList
            // 
            this.dtgTypeList.AllowUserToAddRows = false;
            this.dtgTypeList.AllowUserToDeleteRows = false;
            this.dtgTypeList.AllowUserToResizeColumns = false;
            this.dtgTypeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgTypeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTypeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgTypeList.Location = new System.Drawing.Point(6, 54);
            this.dtgTypeList.Name = "dtgTypeList";
            this.dtgTypeList.RowHeadersVisible = false;
            this.dtgTypeList.Size = new System.Drawing.Size(278, 312);
            this.dtgTypeList.TabIndex = 3;
            this.dtgTypeList.Click += new System.EventHandler(this.dtgTypeList_Click);
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(72, 28);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(212, 20);
            this.Unit.TabIndex = 2;
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.BackColor = System.Drawing.Color.White;
            this.btnUnitAdd.ForeColor = System.Drawing.Color.Black;
            this.btnUnitAdd.Location = new System.Drawing.Point(290, 31);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUnitAdd.TabIndex = 0;
            this.btnUnitAdd.Text = "Add";
            this.btnUnitAdd.UseVisualStyleBackColor = false;
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // btnTypeDelete
            // 
            this.btnTypeDelete.BackColor = System.Drawing.Color.White;
            this.btnTypeDelete.ForeColor = System.Drawing.Color.Black;
            this.btnTypeDelete.Location = new System.Drawing.Point(290, 112);
            this.btnTypeDelete.Name = "btnTypeDelete";
            this.btnTypeDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTypeDelete.TabIndex = 6;
            this.btnTypeDelete.Text = "Delete";
            this.btnTypeDelete.UseVisualStyleBackColor = false;
            this.btnTypeDelete.Click += new System.EventHandler(this.btnTypeDel_Click);
            // 
            // btnTypeUpdate
            // 
            this.btnTypeUpdate.BackColor = System.Drawing.Color.White;
            this.btnTypeUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnTypeUpdate.Location = new System.Drawing.Point(290, 74);
            this.btnTypeUpdate.Name = "btnTypeUpdate";
            this.btnTypeUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTypeUpdate.TabIndex = 5;
            this.btnTypeUpdate.Text = "Update";
            this.btnTypeUpdate.UseVisualStyleBackColor = false;
            this.btnTypeUpdate.Click += new System.EventHandler(this.btnTypeUpdate_Click);
            // 
            // btnTypeLoad
            // 
            this.btnTypeLoad.BackColor = System.Drawing.Color.White;
            this.btnTypeLoad.ForeColor = System.Drawing.Color.Black;
            this.btnTypeLoad.Location = new System.Drawing.Point(290, 146);
            this.btnTypeLoad.Name = "btnTypeLoad";
            this.btnTypeLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTypeLoad.TabIndex = 4;
            this.btnTypeLoad.Text = "Load";
            this.btnTypeLoad.UseVisualStyleBackColor = false;
            this.btnTypeLoad.Click += new System.EventHandler(this.btnTypeLoad_Click);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(72, 28);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(212, 20);
            this.Type.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(6, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Type :";
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.BackColor = System.Drawing.Color.White;
            this.btnUnitUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUnitUpdate.Location = new System.Drawing.Point(290, 74);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUnitUpdate.TabIndex = 5;
            this.btnUnitUpdate.Text = "Update";
            this.btnUnitUpdate.UseVisualStyleBackColor = false;
            this.btnUnitUpdate.Click += new System.EventHandler(this.btnUnitUpdate_Click);
            // 
            // btnUnitLoad
            // 
            this.btnUnitLoad.BackColor = System.Drawing.Color.White;
            this.btnUnitLoad.ForeColor = System.Drawing.Color.Black;
            this.btnUnitLoad.Location = new System.Drawing.Point(290, 146);
            this.btnUnitLoad.Name = "btnUnitLoad";
            this.btnUnitLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUnitLoad.TabIndex = 4;
            this.btnUnitLoad.Text = "Load";
            this.btnUnitLoad.UseVisualStyleBackColor = false;
            this.btnUnitLoad.Click += new System.EventHandler(this.btnUnitLoad_Click);
            // 
            // dtgUnitList
            // 
            this.dtgUnitList.AllowUserToAddRows = false;
            this.dtgUnitList.AllowUserToDeleteRows = false;
            this.dtgUnitList.AllowUserToResizeColumns = false;
            this.dtgUnitList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgUnitList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgUnitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUnitList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgUnitList.Location = new System.Drawing.Point(6, 54);
            this.dtgUnitList.Name = "dtgUnitList";
            this.dtgUnitList.RowHeadersVisible = false;
            this.dtgUnitList.Size = new System.Drawing.Size(278, 312);
            this.dtgUnitList.TabIndex = 3;
            this.dtgUnitList.Click += new System.EventHandler(this.dtgUnitList_Click);
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.BackColor = System.Drawing.Color.White;
            this.btnTypeAdd.ForeColor = System.Drawing.Color.Black;
            this.btnTypeAdd.Location = new System.Drawing.Point(290, 31);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTypeAdd.TabIndex = 0;
            this.btnTypeAdd.Text = "Add";
            this.btnTypeAdd.UseVisualStyleBackColor = false;
            this.btnTypeAdd.Click += new System.EventHandler(this.btnTypeAdd_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnUnit);
            this.GroupBox2.Controls.Add(this.btnUnitUpdate);
            this.GroupBox2.Controls.Add(this.btnUnitLoad);
            this.GroupBox2.Controls.Add(this.dtgUnitList);
            this.GroupBox2.Controls.Add(this.Unit);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btnUnitAdd);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(392, 9);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(374, 372);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Add New Unit";
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.Color.White;
            this.btnUnit.ForeColor = System.Drawing.Color.Black;
            this.btnUnit.Location = new System.Drawing.Point(290, 112);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(75, 23);
            this.btnUnit.TabIndex = 7;
            this.btnUnit.Text = "Delete";
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnitDelete_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(6, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Unit :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnTypeDelete);
            this.GroupBox1.Controls.Add(this.btnTypeUpdate);
            this.GroupBox1.Controls.Add(this.btnTypeLoad);
            this.GroupBox1.Controls.Add(this.dtgTypeList);
            this.GroupBox1.Controls.Add(this.Type);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnTypeAdd);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(374, 372);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Add New Apple Type";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 395);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnitList)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgTypeList;
        internal System.Windows.Forms.TextBox Unit;
        internal System.Windows.Forms.Button btnUnitAdd;
        internal System.Windows.Forms.Button btnTypeDelete;
        internal System.Windows.Forms.Button btnTypeUpdate;
        internal System.Windows.Forms.Button btnTypeLoad;
        internal System.Windows.Forms.TextBox Type;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnUnitUpdate;
        internal System.Windows.Forms.Button btnUnitLoad;
        internal System.Windows.Forms.DataGridView dtgUnitList;
        internal System.Windows.Forms.Button btnTypeAdd;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnUnit;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}