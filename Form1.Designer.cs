
namespace Laba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.initButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.initPanel = new System.Windows.Forms.Panel();
            this.dbTree = new System.Windows.Forms.TreeView();
            this.volumeFuncText = new System.Windows.Forms.TextBox();
            this.nameFuncText = new System.Windows.Forms.TextBox();
            this.idFuncText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.exFuncButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.commandText = new System.Windows.Forms.TextBox();
            this.DBText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hostText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.initStatus = new System.Windows.Forms.Label();
            this.connectStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dumpPath = new System.Windows.Forms.TextBox();
            this.fileDialogButton = new System.Windows.Forms.Button();
            this.dumpPanel = new System.Windows.Forms.Panel();
            this.dumpStatus = new System.Windows.Forms.Label();
            this.loadDump = new System.Windows.Forms.Button();
            this.createDump = new System.Windows.Forms.Button();
            this.dumpPathChoose = new System.Windows.Forms.FolderBrowserDialog();
            this.initPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dumpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // initButton
            // 
            this.initButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.initButton.FlatAppearance.BorderSize = 0;
            this.initButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initButton.ForeColor = System.Drawing.Color.White;
            this.initButton.Location = new System.Drawing.Point(40, 74);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(733, 42);
            this.initButton.TabIndex = 0;
            this.initButton.Text = "Инициализировать соединение";
            this.initButton.UseVisualStyleBackColor = false;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openButton.Enabled = false;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(40, 122);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(733, 42);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Открыть сеанс";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.Enabled = false;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(40, 170);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(733, 42);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Закрыть сеанс";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeButton.FlatAppearance.BorderSize = 0;
            this.executeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executeButton.ForeColor = System.Drawing.Color.White;
            this.executeButton.Location = new System.Drawing.Point(40, 218);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(733, 42);
            this.executeButton.TabIndex = 3;
            this.executeButton.Text = "Выполнить команду";
            this.executeButton.UseVisualStyleBackColor = false;
            this.executeButton.Visible = false;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // initPanel
            // 
            this.initPanel.Controls.Add(this.dbTree);
            this.initPanel.Controls.Add(this.volumeFuncText);
            this.initPanel.Controls.Add(this.nameFuncText);
            this.initPanel.Controls.Add(this.idFuncText);
            this.initPanel.Controls.Add(this.listBox1);
            this.initPanel.Controls.Add(this.exFuncButton);
            this.initPanel.Controls.Add(this.label5);
            this.initPanel.Controls.Add(this.commandText);
            this.initPanel.Controls.Add(this.DBText);
            this.initPanel.Controls.Add(this.label4);
            this.initPanel.Controls.Add(this.nameText);
            this.initPanel.Controls.Add(this.label3);
            this.initPanel.Controls.Add(this.hostText);
            this.initPanel.Controls.Add(this.passwordText);
            this.initPanel.Controls.Add(this.label2);
            this.initPanel.Controls.Add(this.label1);
            this.initPanel.Location = new System.Drawing.Point(40, 265);
            this.initPanel.Name = "initPanel";
            this.initPanel.Size = new System.Drawing.Size(733, 461);
            this.initPanel.TabIndex = 5;
            this.initPanel.Visible = false;
            // 
            // dbTree
            // 
            this.dbTree.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dbTree.Location = new System.Drawing.Point(462, 56);
            this.dbTree.Name = "dbTree";
            this.dbTree.Size = new System.Drawing.Size(271, 370);
            this.dbTree.TabIndex = 11;
            this.dbTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTree_NodeMouseClick);
            this.dbTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTree_NodeMouseDoubleClick);
            // 
            // volumeFuncText
            // 
            this.volumeFuncText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volumeFuncText.Location = new System.Drawing.Point(2, 394);
            this.volumeFuncText.Name = "volumeFuncText";
            this.volumeFuncText.PlaceholderText = "volume";
            this.volumeFuncText.Size = new System.Drawing.Size(213, 34);
            this.volumeFuncText.TabIndex = 13;
            // 
            // nameFuncText
            // 
            this.nameFuncText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameFuncText.Location = new System.Drawing.Point(2, 354);
            this.nameFuncText.Name = "nameFuncText";
            this.nameFuncText.PlaceholderText = "name";
            this.nameFuncText.Size = new System.Drawing.Size(213, 34);
            this.nameFuncText.TabIndex = 12;
            // 
            // idFuncText
            // 
            this.idFuncText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idFuncText.Location = new System.Drawing.Point(2, 314);
            this.idFuncText.Name = "idFuncText";
            this.idFuncText.PlaceholderText = "id";
            this.idFuncText.Size = new System.Drawing.Size(213, 34);
            this.idFuncText.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "insert(name, volume)",
            "delete(id)"});
            this.listBox1.Location = new System.Drawing.Point(232, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 172);
            this.listBox1.TabIndex = 10;
            // 
            // exFuncButton
            // 
            this.exFuncButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exFuncButton.FlatAppearance.BorderSize = 0;
            this.exFuncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exFuncButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exFuncButton.ForeColor = System.Drawing.Color.White;
            this.exFuncButton.Location = new System.Drawing.Point(0, 254);
            this.exFuncButton.Name = "exFuncButton";
            this.exFuncButton.Size = new System.Drawing.Size(215, 42);
            this.exFuncButton.TabIndex = 9;
            this.exFuncButton.Text = "Выполнить функцию";
            this.exFuncButton.UseVisualStyleBackColor = false;
            this.exFuncButton.Visible = false;
            this.exFuncButton.Click += new System.EventHandler(this.exFuncButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Команда";
            // 
            // commandText
            // 
            this.commandText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commandText.Location = new System.Drawing.Point(220, 16);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(513, 34);
            this.commandText.TabIndex = 8;
            // 
            // DBText
            // 
            this.DBText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DBText.Location = new System.Drawing.Point(220, 96);
            this.DBText.Name = "DBText";
            this.DBText.Size = new System.Drawing.Size(223, 34);
            this.DBText.TabIndex = 5;
            this.DBText.Text = "IS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пароль";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameText.Location = new System.Drawing.Point(220, 136);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(223, 34);
            this.nameText.TabIndex = 6;
            this.nameText.Text = "postgres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя пользователя";
            // 
            // hostText
            // 
            this.hostText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hostText.Location = new System.Drawing.Point(220, 56);
            this.hostText.Name = "hostText";
            this.hostText.Size = new System.Drawing.Size(223, 34);
            this.hostText.TabIndex = 4;
            this.hostText.Text = "localhost";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordText.Location = new System.Drawing.Point(220, 176);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(223, 34);
            this.passwordText.TabIndex = 7;
            this.passwordText.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "База данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Хост";
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showButton.ForeColor = System.Drawing.Color.White;
            this.showButton.Location = new System.Drawing.Point(823, 74);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(394, 42);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Просмотр";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Visible = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultText.Location = new System.Drawing.Point(823, 122);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.resultText.Size = new System.Drawing.Size(394, 138);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "";
            // 
            // initStatus
            // 
            this.initStatus.AutoSize = true;
            this.initStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.initStatus.ForeColor = System.Drawing.Color.Red;
            this.initStatus.Location = new System.Drawing.Point(40, 14);
            this.initStatus.Name = "initStatus";
            this.initStatus.Size = new System.Drawing.Size(195, 23);
            this.initStatus.TabIndex = 6;
            this.initStatus.Text = "Не инициализировано";
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.connectStatus.ForeColor = System.Drawing.Color.Red;
            this.connectStatus.Location = new System.Drawing.Point(40, 43);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(164, 23);
            this.connectStatus.TabIndex = 7;
            this.connectStatus.Text = "Нет подключения";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(823, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(394, 191);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Каталог для дампа БД:";
            // 
            // dumpPath
            // 
            this.dumpPath.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dumpPath.Location = new System.Drawing.Point(0, 43);
            this.dumpPath.Name = "dumpPath";
            this.dumpPath.ReadOnly = true;
            this.dumpPath.Size = new System.Drawing.Size(284, 30);
            this.dumpPath.TabIndex = 12;
            // 
            // fileDialogButton
            // 
            this.fileDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fileDialogButton.FlatAppearance.BorderSize = 0;
            this.fileDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileDialogButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileDialogButton.ForeColor = System.Drawing.Color.White;
            this.fileDialogButton.Location = new System.Drawing.Point(290, 43);
            this.fileDialogButton.Name = "fileDialogButton";
            this.fileDialogButton.Size = new System.Drawing.Size(104, 30);
            this.fileDialogButton.TabIndex = 13;
            this.fileDialogButton.Text = "Обзор...";
            this.fileDialogButton.UseVisualStyleBackColor = false;
            this.fileDialogButton.Click += new System.EventHandler(this.fileDialogButton_Click);
            // 
            // dumpPanel
            // 
            this.dumpPanel.Controls.Add(this.fileDialogButton);
            this.dumpPanel.Controls.Add(this.dumpStatus);
            this.dumpPanel.Controls.Add(this.loadDump);
            this.dumpPanel.Controls.Add(this.createDump);
            this.dumpPanel.Controls.Add(this.dumpPath);
            this.dumpPanel.Controls.Add(this.label6);
            this.dumpPanel.Location = new System.Drawing.Point(823, 480);
            this.dumpPanel.Name = "dumpPanel";
            this.dumpPanel.Size = new System.Drawing.Size(394, 246);
            this.dumpPanel.TabIndex = 14;
            this.dumpPanel.Visible = false;
            // 
            // dumpStatus
            // 
            this.dumpStatus.AutoSize = true;
            this.dumpStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dumpStatus.ForeColor = System.Drawing.Color.Red;
            this.dumpStatus.Location = new System.Drawing.Point(0, 190);
            this.dumpStatus.Name = "dumpStatus";
            this.dumpStatus.Size = new System.Drawing.Size(0, 23);
            this.dumpStatus.TabIndex = 15;
            // 
            // loadDump
            // 
            this.loadDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadDump.FlatAppearance.BorderSize = 0;
            this.loadDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadDump.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadDump.ForeColor = System.Drawing.Color.White;
            this.loadDump.Location = new System.Drawing.Point(0, 150);
            this.loadDump.Name = "loadDump";
            this.loadDump.Size = new System.Drawing.Size(394, 42);
            this.loadDump.TabIndex = 14;
            this.loadDump.Text = "Загрузить дамп БД";
            this.loadDump.UseVisualStyleBackColor = false;
            this.loadDump.Click += new System.EventHandler(this.loadDump_Click);
            // 
            // createDump
            // 
            this.createDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.createDump.FlatAppearance.BorderSize = 0;
            this.createDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createDump.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createDump.ForeColor = System.Drawing.Color.White;
            this.createDump.Location = new System.Drawing.Point(0, 95);
            this.createDump.Name = "createDump";
            this.createDump.Size = new System.Drawing.Size(394, 42);
            this.createDump.TabIndex = 14;
            this.createDump.Text = "Создать дамп БД";
            this.createDump.UseVisualStyleBackColor = false;
            this.createDump.Click += new System.EventHandler(this.createDump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1266, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.initStatus);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.initPanel);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.dumpPanel);
            this.Name = "Form1";
            this.Text = "Клиентское приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.initPanel.ResumeLayout(false);
            this.initPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dumpPanel.ResumeLayout(false);
            this.dumpPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Panel initPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.TextBox DBText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hostText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label initStatus;
        private System.Windows.Forms.Label connectStatus;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button exFuncButton;
        private System.Windows.Forms.TextBox volumeFuncText;
        private System.Windows.Forms.TextBox nameFuncText;
        private System.Windows.Forms.TextBox idFuncText;
        private System.Windows.Forms.TreeView dbTree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dumpPath;
        private System.Windows.Forms.Button fileDialogButton;
        private System.Windows.Forms.Panel dumpPanel;
        private System.Windows.Forms.Label dumpStatus;
        private System.Windows.Forms.Button loadDump;
        private System.Windows.Forms.Button createDump;
        private System.Windows.Forms.FolderBrowserDialog dumpPathChoose;
    }
}

