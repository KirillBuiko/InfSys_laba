using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Npgsql;

namespace Laba1
{
    class DBConnection
    {
        private bool isConn = false;
        private String host;
        private String db;
        private String name;
        private String password;

        private NpgsqlConnection dbconn;
        public DBConnection()
        {
            dbconn = new NpgsqlConnection();
        }
        public DBConnection(String host, String db, String name, String password)
        {
            dbconn = new NpgsqlConnection();
            Connect(host, db, name, password);
        }
        public bool isConnected()
        {
            return isConn;
        }
        public int Connect(String host, String db, String name, String password)
        {
            if (isConn) Disconnect();
            try
            {
                dbconn.ConnectionString = String.Format("Host={0};Username={2};Password={3};Database={1}", host, db, name, password);
                isConn = true;

            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
        public int Disconnect()
        {
            if (isConn) isConn = false;
            else return 0;
            try
            {
                dbconn.Close();

            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
        public String showTable(DataGridView dgv, String table)
        {
            if (!isConn) return "";
            String resultText = "";
            String command = "SELECT * FROM " + table + ";";
            try
            {
                dbconn.Open();
                NpgsqlCommand comm = new NpgsqlCommand(command, dbconn);
                var reader = comm.ExecuteReader();
                foreach (var col in reader.GetColumnSchema())
                {
                    resultText += col.ColumnName + "  | ";
                }
                resultText += "\n\n";
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        object[] obj = new object[reader.FieldCount];
                        reader.GetValues(obj);
                        foreach (var val in obj)
                        {
                            resultText += val.ToString() + "  |  ";
                        }

                        resultText = resultText.Trim();
                        resultText += '\n';
                    }

                }
                dbconn.Close();

                dbconn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, dbconn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dt.TableName = table;
                dgv.Columns.Clear();
                dgv.DataSource = dt;
                dgv.AutoResizeColumns();
                dbconn.Close();
                return resultText;
            }
            catch (Exception ex)
            {

            }
            try
            {
                dbconn.Close();
            }
            catch (Exception ex)
            {

            }
            return "";
        }

        public int dataGridUpdate(DataGridView dgv, int row)
        {
            if (!isConn) return 0;
            if (((DataTable)dgv.DataSource).TableName == "") return 0;
            String command = "UPDATE " + ((DataTable)dgv.DataSource).TableName + " SET ";
            var datarow = dgv.Rows[row];
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                command += String.Format("{0} = '{1}'", dgv.Columns[i].Name, datarow.Cells[i].Value);
                if (i < dgv.Columns.Count - 1)
                    command += ", ";
            }
            command += " WHERE " + dgv.Columns[0].Name + " = '" + datarow.Cells[0].Value + "';";
            try
            {
                Execute(command);
                return 1;
            }
            catch (Exception ex)
            {

            }
            return 0;
        }

        public int fillTreeDB(TreeView tv)
        {
            if (!isConn) return 0;
            String command = ("SELECT datname From pg_database WHERE  datistemplate=false;");
            try
            {
                dbconn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, dbconn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                tv.Nodes.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    tv.Nodes.Add(row.ItemArray[0].ToString());
                }
                dbconn.Close();
            }
            catch (Exception ex)
            {

            }
            try
            {
                dbconn.Close();
            }
            catch (Exception ex)
            {

            }
            return 1;
        }

        public int fillTreeTables(TreeNode tn)
        {
            if (!isConn) return 0;
            String command = ("SELECT table_name  FROM information_schema.tables WHERE table_catalog = '" + tn.Text + "' and table_schema='public';");
            try
            {
                dbconn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, dbconn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                tn.Nodes.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    tn.Nodes.Add(row.ItemArray[0].ToString());
                }
                dbconn.Close();
            }
            catch (Exception ex)
            {

            }
            try
            {
                dbconn.Close();
            }
            catch (Exception ex)
            {

            }
            return 0;
        }

        public int Execute(String text)
        {
            if (!isConn) return 0;
            String command = text;
            try
            {
                dbconn.Open();
                NpgsqlCommand comm = new NpgsqlCommand(command, dbconn);
                var rows = comm.ExecuteNonQuery();
                dbconn.Close();
                return rows;
            }
            catch (Exception ex)
            {

            }
            try
            {
                dbconn.Close();
            }
            catch (Exception ex)
            {

            }
            return 0;
        }
        public int ExecuteAndShow(String text, DataGridView dgv)
        {
            if (!isConn) return 0;
            String command = text;
            try
            {
                dbconn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, dbconn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dt.TableName = "";
                dgv.Columns.Clear();
                dgv.DataSource = dt;
                dgv.AutoResizeColumns();
                dbconn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                
            }
            try
            {
                dbconn.Close();
            }
            catch (Exception ex)
            {

            }
            return 0;
        }

        public int Dump(String DB, String path)
        {
            Process dump = new Process();
            dump.StartInfo.FileName = "C:/Program Files/PostgreSQL/13/bin/pg_dump.exe";
            dump.StartInfo.Arguments = $"--dbname=postgresql://postgres:admin@127.0.0.1:5432/{DB} -F c -f {path}/{DB}.db";
            dump.StartInfo.UseShellExecute = false;
            dump.StartInfo.CreateNoWindow = true;
            dump.Start();
            dump.WaitForExit();
            return dump.ExitCode;
        }

        public int Restore(String DB, String path)
        {
            Process dump = new Process();
            dump.StartInfo.FileName = "C:/Program Files/PostgreSQL/13/bin/pg_restore.exe";
            dump.StartInfo.Arguments = $"--dbname=postgresql://postgres:admin@127.0.0.1:5432/{DB} -c -F c {path}/{DB}.db";
            dump.StartInfo.UseShellExecute = false;
            dump.StartInfo.CreateNoWindow = true;
            dump.Start();
            dump.WaitForExit();
            return dump.ExitCode;
        }
    }
}
