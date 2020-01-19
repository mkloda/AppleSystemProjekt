using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace AppleSystem.Includes
{
    class SQLConfig
    {

        private MySqlConnection connection = new MySqlConnection("server=sql.tkasperski98.nazwa.pl;user id=tkasperski98_bazaProjekt;password=Test1234;database=tkasperski98_bazaProjekt;sslMode=none");
        private MySqlCommand command;
        private MySqlDataAdapter dataAdapter;
        public DataTable dt; 
        int result;
        usableFunction funct = new usableFunction();
        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                result = command.ExecuteNonQuery();

                if(result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
        }
        public void Execute_Query(string sql)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                result = command.ExecuteNonQuery();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Load_DTG(string sql,DataGridView dtg)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dt = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);
                dtg.DataSource = dt;

               
                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }

        }
        public void fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dt = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);
                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[0].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }

        }
        public void singleResult(string sql)

        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dt = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
        }

        public void loadReports(string sql)

        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dt = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
        }

        public void autocomplete(string sql,TextBox txt)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dt = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);
                txt.AutoCompleteCustomSource.Clear();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                foreach (DataRow r in dt.Rows)
                {
                    txt.AutoCompleteCustomSource.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
        }

        public void autonumber(string sql,TextBox txt)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dt = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dt);

                txt.Text = dt.Rows[0].Field<string>(0);
            

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                connection.Close();
            }
        }
        public void update_Autonumber(string id)
        { 
            Execute_Query("UPDATE `autonumber` SET `END`=`END`+`INCREMENT` WHERE `DESCRIPTION`='" + id + "'");
        }
       


    }
}
