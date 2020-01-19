using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleSystem.Includes;

namespace AppleSystem
{
    public partial class frmLogin : Form
    {
        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();

            this.frm = frm;
        }
        SQLConfig config = new SQLConfig();
        string sql;


        private void Button1_Click(object sender, EventArgs e)
        {
            sql =" SELECT* FROM users WHERE user_name = '" + userName.Text + "' and pass = sha1('" + password.Text + "')";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                frm.enabled_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist! Please contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            password.Clear();
            userName.Clear();
            userName.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
