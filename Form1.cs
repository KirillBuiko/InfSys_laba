using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        bool isInitialized = false;
        bool isConnected = false;
        DBConnection dbconn;
        public Form1()
        {
            InitializeComponent();
        }

        void initConnection()
        {
            isInitialized = true;
            initButton.Enabled = false;
            initStatus.Text = "Инициализировано";
            initStatus.ForeColor = Color.Green;
            initPanel.Visible = true;
            openButton.Enabled = true;
            this.Height = 800;
            this.Width = 1253;
            dbconn = new DBConnection();
        }
        void openConnection()
        {
            if (!isInitialized)
            {
                connectStatus.Text = "Нет подключения";
                connectStatus.ForeColor = Color.Red;
            }
            if (isConnected) closeConnection();
            if(dbconn.Connect(hostText.Text, DBText.Text, nameText.Text, passwordText.Text) == 1)
            {
                connectStatus.Text = "Подключение установлено!";
                connectStatus.ForeColor = Color.Green;
                isConnected = true;
                openButton.Enabled = false;
                closeButton.Enabled = true;
                executeButton.Visible = true;
                exFuncButton.Visible = true;
                showButton.Visible = true;
                dumpPanel.Visible = true;
                hostText.Enabled = false;
                DBText.Enabled = false;
                nameText.Enabled = false;
                passwordText.Enabled = false;
            }
            else
            {
                connectStatus.Text = "Подключение не установлено!";
                connectStatus.ForeColor = Color.Red;
            }
        }
        void closeConnection()
        {
            if (!isInitialized)
            {
                connectStatus.Text = "Нет подключения";
                connectStatus.ForeColor = Color.Red;
            }
            if (!isConnected) return;
            if (dbconn.Disconnect() == 1)
            {
                connectStatus.Text = "Подключение разорвано!";
                connectStatus.ForeColor = Color.Red;
                isConnected = false;
                openButton.Enabled = true;
                closeButton.Enabled = false;
                executeButton.Visible = false;
                showButton.Visible = false;
                exFuncButton.Visible = false;
                dumpPanel.Visible = false;
                hostText.Enabled = true;
                DBText.Enabled = true;
                nameText.Enabled = true;
                passwordText.Enabled = true;
            }
            else
            {
                connectStatus.Text = "Подключение не разорвано!";
                connectStatus.ForeColor = Color.Yellow;
            }
        }
        private void initButton_Click(object sender, EventArgs e)
        {
            initConnection();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openConnection();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            closeConnection();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            dbconn.ExecuteAndShow(commandText.Text, dataGridView1);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            resultText.Text = dbconn.showTable(dataGridView1, "boxes");
            dbconn.fillTreeDB(dbTree);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 1;
            this.Height = 325;
            this.Width =  830;
        }

        private void exFuncButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString().Contains("insert"))
            {
                dbconn.Execute("select insert('" + nameFuncText.Text + "'," + volumeFuncText.Text + ");");
            }
            else if (listBox1.SelectedItem.ToString().Contains("delete"))
            {
                dbconn.Execute("select delete(" + idFuncText.Text + ");");
            }
        }

        private void dbTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                foreach (TreeNode node in dbTree.Nodes)
                {
                    node.NodeFont = new Font("Segoe UI", 10, FontStyle.Regular);
                }
                e.Node.NodeFont = new Font("Segoe UI", 10, FontStyle.Bold);

                DBText.Text = e.Node.Text;
                closeConnection();
                openConnection();
                dbconn.fillTreeTables(e.Node);
            }
            if (e.Node.Level == 1)
            {
                dbconn.showTable(dataGridView1, e.Node.Text);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dbconn.dataGridUpdate(dataGridView1, e.RowIndex);
        }

        private void createDump_Click(object sender, EventArgs e)
        {
            String path = dumpPath.Text;
            String dbname = DBText.Text;
            if (dbconn.Dump(dbname, path) == 1)
            {
                dumpStatus.ForeColor = Color.Red;
                dumpStatus.Text = "Ошибка при создании дампа";
            }
            else
            {
                dumpStatus.ForeColor = Color.Green;
                dumpStatus.Text = "Дамп успешно создан";
            }
        }

        private void loadDump_Click(object sender, EventArgs e)
        {
            String path = dumpPath.Text;
            String dbname = DBText.Text;
            if (dbconn.Restore(dbname, path) == 1)
            {
                dumpStatus.ForeColor = Color.Red;
                dumpStatus.Text = "Ошибка при загрузке дампа";
            }
            else
            {
                dumpStatus.ForeColor = Color.Green;
                dumpStatus.Text = "Дамп успешно загружен";
            }
        }

        private void fileDialogButton_Click(object sender, EventArgs e)
        {
            if (dumpPathChoose.ShowDialog() == DialogResult.OK)
            {
                dumpPath.Text = dumpPathChoose.SelectedPath;
            }
        }

        private void dbTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0 && e.Button == MouseButtons.Right)
            {
                foreach (TreeNode node in dbTree.Nodes)
                {
                    node.NodeFont = new Font("Segoe UI", 10, FontStyle.Regular);
                }
                e.Node.NodeFont = new Font("Segoe UI", 10, FontStyle.Bold);

                DBText.Text = e.Node.Text;
                closeConnection();
                openConnection();
                dbconn.fillTreeTables(e.Node);
            }
        }
    }
}
