using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleSystem.Properties;

namespace AppleSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }
        public void enabled_menu()
        {
            manageUsers.Enabled = true;
            productManager.Enabled = true;
            login.Text = "Logout";
            settings.Enabled = true;

        }
        public void disabled_menu()
        {
            manageUsers.Enabled = false;
            productManager.Enabled = false;
            settings.Enabled = false;
        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsProductManager_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmItems());
        }


        private void tsManageUsers_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmUsers());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if (login.Text == "Login")
            {
                closeForm();
                showFrm(new frmLogin(this));
            }
            else
            {
                closeForm();
                disabled_menu();
                login.Text = "Login";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();

        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmSettings());
        }
    }
}
