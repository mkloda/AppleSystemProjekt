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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql,typeid,unitID;

        private void btnTypeAdd_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO settings (DESCRIPTION,PARA) VALUES ('" + Type.Text + "','Category')";
            config.Execute_CUD(sql, "error to saved data", "Data has been saved in the database.");


            sql = "INSERT INTO autonumber (START,END,INCREMENT,DESCRIPTION)" +
               " VALUES ('" + Type.Text.Substring(0, 1) + "0000" + "',1,1,'" + Type.Text + "')";
            config.Execute_Query(sql); 
            btnTypeLoad_Click(sender, e);
        }
        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO settings (DESCRIPTION,PARA) VALUES ('" + Unit.Text + "','Unit')";
            config.Execute_CUD(sql, "error to save date", "Data has been saved in the database.");
            btnUnitLoad_Click(sender, e);
        }

        private void btnTypeLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT ID, DESCRIPTION as 'Category' FROM settings WHERE PARA='Category'";
            config.Load_DTG(sql, dtgTypeList); 
            dtgTypeList.Columns[0].Visible = false;
            Type.Clear();
        }
        private void btnUnitLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT ID, DESCRIPTION as 'Category' FROM settings WHERE PARA='Unit'";
            config.Load_DTG(sql, dtgUnitList);
            dtgUnitList.Columns[0].Visible = false;
            Unit.Clear();
        }

        private void btnTypeDel_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `autonumber` WHERE `ID`='" + dtgTypeList.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM `settings` WHERE `ID`='" + dtgTypeList.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "error to delete data", "Data has been deleted in the database.");

            btnTypeLoad_Click(sender, e);
        }

        private void dtgTypeList_Click(object sender, EventArgs e)
        {
            Type.Text = dtgTypeList.CurrentRow.Cells[1].Value.ToString();
            typeid = dtgTypeList.CurrentRow.Cells[0].Value.ToString();
        }


        private void btnUnitDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `settings` WHERE `ID`='" + dtgUnitList.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "error to delete date", "Data has been deleted in the database.");
            btnUnitLoad_Click(sender, e);
        }

        private void dtgUnitList_Click(object sender, EventArgs e)
        {
            Unit.Text = dtgUnitList.CurrentRow.Cells[1].Value.ToString();
            unitID = dtgUnitList.CurrentRow.Cells[0].Value.ToString();
        }


        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE settings  SET DESCRIPTION= '" + Unit.Text + "' WHERE ID ='" + unitID + "'";
            config.Execute_CUD(sql, "error to update data", "Data has been updated in the database.");
            btnUnitLoad_Click(sender, e);
        }

        private void btnTypeUpdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE settings  SET DESCRIPTION= '" + Type.Text + "' WHERE ID ='" + typeid + "'";
            config.Execute_CUD(sql, "error to update data", "Data has been updated in the database.");
            btnTypeLoad_Click(sender, e);
        }
    }
}
