namespace AppleSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.productManager = new System.Windows.Forms.ToolStripButton();
            this.manageUsers = new System.Windows.Forms.ToolStripButton();
            this.settings = new System.Windows.Forms.ToolStripButton();
            this.login = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productManager,
            this.manageUsers,
            this.settings,
            this.login});
            this.toolStrip1.Location = new System.Drawing.Point(860, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(128, 556);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // productManager
            // 
            this.productManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManager.Image = ((System.Drawing.Image)(resources.GetObject("ts_stocks.Image")));
            this.productManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.productManager.Name = "productManager";
            this.productManager.Size = new System.Drawing.Size(125, 59);
            this.productManager.Text = "Product Manager";
            this.productManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productManager.Click += new System.EventHandler(this.tsProductManager_Click);
            // 
            // manageUsers
            // 
            this.manageUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsers.Image = ((System.Drawing.Image)(resources.GetObject("ts_ManageUsers.Image")));
            this.manageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.manageUsers.Name = "manageUsers";
            this.manageUsers.Size = new System.Drawing.Size(125, 59);
            this.manageUsers.Text = "Manage Users";
            this.manageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manageUsers.Click += new System.EventHandler(this.tsManageUsers_Click);
            // 
            // settings
            // 
            this.settings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("ts_settings.Image")));
            this.settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(125, 59);
            this.settings.Text = "Settings";
            this.settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settings.Click += new System.EventHandler(this.tsSettings_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Image = global::AppleSystem.Properties.Resources.login;
            this.login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(125, 59);
            this.login.Text = "Login";
            this.login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.login.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton productManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton manageUsers;
        private System.Windows.Forms.ToolStripButton login;
        private System.Windows.Forms.ToolStripButton settings;
    }
}

