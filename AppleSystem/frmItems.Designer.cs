namespace AppleSystem
{
    partial class frmItems
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
            this.quantity = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.ComboBox();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.pnl_productManager = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.Panel2.SuspendLayout();
            this.pnl_productManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(434, 100);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(153, 22);
            this.quantity.TabIndex = 4;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(227, 176);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(106, 30);
            this.Button1.TabIndex = 44;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(381, 167);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 13);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "Search :";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(435, 164);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(263, 20);
            this.search.TabIndex = 29;
            this.search.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(227, 140);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 30);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(118, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 30);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(83, 59);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(252, 24);
            this.type.TabIndex = 2;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(435, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(252, 22);
            this.name.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(32, 100);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 16);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Price :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(10, 59);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Category :";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(83, 94);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(250, 22);
            this.price.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(118, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 30);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(7, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 66);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(434, 56);
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.description.Size = new System.Drawing.Size(253, 23);
            this.description.TabIndex = 3;
            this.description.Text = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(348, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Description :";
            // 
            // itemID
            // 
            this.itemID.Enabled = false;
            this.itemID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemID.Location = new System.Drawing.Point(83, 19);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(251, 22);
            this.itemID.TabIndex = 7;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(21, 22);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(56, 16);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Item Id :";
            // 
            // units
            // 
            this.units.FormattingEnabled = true;
            this.units.Items.AddRange(new object[] {
            "Metre",
            "Pcs."});
            this.units.Location = new System.Drawing.Point(600, 101);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(87, 23);
            this.units.TabIndex = 6;
            this.units.Text = "Metre";
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(0, 0);
            this.dtgList.Name = "dtgList";
            this.dtgList.Size = new System.Drawing.Size(733, 206);
            this.dtgList.TabIndex = 0;
            this.dtgList.Click += new System.EventHandler(this.dtgList_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.dtgList);
            this.Panel2.Controls.Add(this.btnAdd);
            this.Panel2.Location = new System.Drawing.Point(6, 229);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(735, 208);
            this.Panel2.TabIndex = 32;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(354, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Item Name :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(364, 100);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 16);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Quantity :";
            // 
            // pnl_productManager
            // 
            this.pnl_productManager.BackColor = System.Drawing.Color.White;
            this.pnl_productManager.Controls.Add(this.itemID);
            this.pnl_productManager.Controls.Add(this.Label8);
            this.pnl_productManager.Controls.Add(this.units);
            this.pnl_productManager.Controls.Add(this.Label7);
            this.pnl_productManager.Controls.Add(this.quantity);
            this.pnl_productManager.Controls.Add(this.description);
            this.pnl_productManager.Controls.Add(this.type);
            this.pnl_productManager.Controls.Add(this.name);
            this.pnl_productManager.Controls.Add(this.Label4);
            this.pnl_productManager.Controls.Add(this.Label3);
            this.pnl_productManager.Controls.Add(this.price);
            this.pnl_productManager.Controls.Add(this.Label2);
            this.pnl_productManager.Controls.Add(this.Label1);
            this.pnl_productManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_productManager.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_productManager.Location = new System.Drawing.Point(0, 0);
            this.pnl_productManager.Name = "pnl_productManager";
            this.pnl_productManager.Size = new System.Drawing.Size(748, 134);
            this.pnl_productManager.TabIndex = 30;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 442);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.pnl_productManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Manager";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.pnl_productManager.ResumeLayout(false);
            this.pnl_productManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox quantity;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox search;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.ComboBox type;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox price;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.RichTextBox description;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox itemID;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox units;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel pnl_productManager;
    }
}