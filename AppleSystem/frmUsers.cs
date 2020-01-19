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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void btn_New_Click(object sender, EventArgs e)
        {
            iD.Text = "id";

            userType.Text = "Administrator";

            config.Load_DTG("Select user_id as 'ID' ,name as 'Name',user_name as 'Username',type as 'Type' From users", dtgListUser);
            dtgListUser.Columns[0].Visible = false;

            if(iD.Text == "id")
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false; 
                btnSaveUser.Enabled = true;
            }
            else
            {
                btnSaveUser.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }

            funct.clearTxt(Panel1);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {


            if( name.Text == "" || password.Text == "" || userName.Text== "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "insert into users (name,user_name,pass,type) "
                     + "values('" + name.Text + "','" + userName.Text
                     + "',sha1('" + password.Text + "'),'" + userType.Text
                     + "')";
                config.Execute_CUD(sql, "Unable to saved", "Data has been saved in the database.");
                frmUsers_Load(sender, e);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || password.Text == "" || userName.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "update users set name = '" + name.Text + "',user_name= '" + userName.Text 
                          + "',pass= sha1('" + password.Text + "'),type= '" + userType.Text 
                          + "' where user_id = " + iD.Text;
                config.Execute_CUD(sql, "Unable to update", "Data has been updated in the database.");
                frmUsers_Load(sender, e);
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "delete from users where user_id = '" + iD.Text + "'";
            config.Execute_CUD(sql, "unable to delete", "Data has been deleted in the database");
            frmUsers_Load(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgListUser_Click(object sender, EventArgs e)
        { 
            iD.Text = dtgListUser.CurrentRow.Cells[0].Value.ToString();
            name.Text = dtgListUser.CurrentRow.Cells[1].Value.ToString();
            userName.Text = dtgListUser.CurrentRow.Cells[2].Value.ToString();
            userType.Text = dtgListUser.CurrentRow.Cells[3].Value.ToString();
        }

        private void lblId_TextChanged(object sender, EventArgs e)
        {
            if (iD.Text == "id")
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSaveUser.Enabled = true;
            }
            else
            {
                btnSaveUser.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
