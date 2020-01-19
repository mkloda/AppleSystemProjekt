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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxcolumn;
        int maxrow;

       private void select_navigation(string sql)
        {
            config.singleResult(sql);
            maxrow = config.dt.Rows.Count;
        }

            public void navigate_records(int inc)
        {
            config.singleResult("SELECT * FROM `items`");
            itemID.Text = config.dt.Rows[inc].Field<string>("ITEMID");
            name.Text = config.dt.Rows[inc].Field<string>("NAME");
            description.Text = config.dt.Rows[inc].Field<string>("DESCRIPTION");
            price.Text = config.dt.Rows[inc].Field<double>("PRICE").ToString();
            type.Text = config.dt.Rows[inc].Field<string>("TYPE");
            quantity.Text = config.dt.Rows[inc].Field<int>("Quantity").ToString();
            units.Text = config.dt.Rows[inc].Field<string>("Units");


        }
        private void btnNew_Click(object sender, EventArgs e)
        {

          
            sql = "SELECT * FROM items";
            config.Load_DTG(sql, dtgList);  

             
            select_navigation("SELECT ITEMID FROM items");


            sql = "SELECT DESCRIPTION FROM `settings` WHERE `PARA`='CATEGORY'";
            config.fiil_CBO(sql, type);

            sql = "SELECT DESCRIPTION FROM `settings` WHERE `PARA`='Unit'";
            config.fiil_CBO(sql, units);


            funct.clearTxt(pnl_productManager);

        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        { 
                sql = "SELECT concat(`START`, `END`) FROM `autonumber` WHERE `DESCRIPTION`= '" + type.Text + "'";
                config.autonumber(sql, itemID);
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            foreach(Control obj in pnl_productManager.Controls)
            {
                if(obj is TextBox)
                {
                    if(obj.Text == "")
                    {
                        MessageBox.Show("Action connot be perform. All fields are required to be fill up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }


            sql = "SELECT ITEMID FROM items WHERE ITEMID='" + itemID.Text + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                sql = "UPDATE items SET qty =qty + '" + quantity.Text + "' WHERE ITEMID ='" + itemID.Text + "'";
                config.Execute_Query(sql);
            }
            else
            {
                sql = "insert into items  (ITEMID,`NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY`,UNIT)" +
                   "VALUES ('" + itemID.Text + "','" + name.Text + "','" + description.Text + "','" + type.Text 
                   + "','" + price.Text + "','" + quantity.Text + "','" + units.Text + "' )";
                config.Execute_CUD(sql, "No data saved.", "Data has been saved in the database.");

                config.update_Autonumber(type.Text);
            }

            btnNew_Click(sender, e);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE items SET `NAME`='" + name.Text + "', `DESCRIPTION`='" + description.Text + "', `TYPE`='" + type.Text + "', `PRICE`='" + price.Text + "'" +
            ",`UNIT`='" + units.Text + "' WHERE ITEMID='" + itemID.Text + "'";
            config.Execute_CUD(sql, "Error to update", "Data has been updated in the database"); 
            btnNew_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM items WHERE ITEMID='" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "error to delete", "Data has been deleted.");
            btnNew_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgList_Click(object sender, EventArgs e)
        { 
            sql = "SELECT * FROM items WHERE ITEMID='" + dtgList.CurrentRow.Cells[0].Value.ToString() + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                itemID.Text = config.dt.Rows[0].Field<string>("ITEMID");
                name.Text = config.dt.Rows[0].Field<string>("NAME");
                description.Text = config.dt.Rows[0].Field<string>("DESCRIPTION");
                price.Text = config.dt.Rows[0].Field<double>("PRICE").ToString();
                type.Text = config.dt.Rows[0].Field<string>("TYPE");
                //quantity.Text = config.dt.Rows[0].Field<int>("Quantity").ToString();
                // units.Text = config.dt.Rows[0].Field<string>("UNIT");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM items WHERE ITEMID LIKE '%" + search.Text + "%' OR NAME LIKE '%" + search.Text + "%'";
            config.Load_DTG(sql, dtgList);


            maxcolumn = dtgList.Columns.Count - 1;

            dtgList.Columns[maxcolumn].Visible = false;

        }
    }
}
