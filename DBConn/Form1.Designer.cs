using System.Windows.Forms;

namespace DBConn
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
            this.closew_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.con_state_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.con_btn = new System.Windows.Forms.Button();
            this.discon_btn = new System.Windows.Forms.Button();
            this.Execute_command_btn = new System.Windows.Forms.Button();
            this.q_textbox = new System.Windows.Forms.TextBox();
            this.EntitiesNames_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Execute_lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.page1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.port_tbx = new System.Windows.Forms.TextBox();
            this.database_tbx = new System.Windows.Forms.TextBox();
            this.pass_tbx = new System.Windows.Forms.TextBox();
            this.user_tbx = new System.Windows.Forms.TextBox();
            this.host_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.Panel();
            this.last_id_val = new System.Windows.Forms.Label();
            this.column_count_val = new System.Windows.Forms.Label();
            this.row_count_val = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nav_to_connection_page_btn = new System.Windows.Forms.Button();
            this.nav_to_queries_page_btn = new System.Windows.Forms.Button();
            this.nav_to_describe_page_btn = new System.Windows.Forms.Button();
            this.page3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.change_size_btn = new System.Windows.Forms.Button();
            this.minmize_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.page1.SuspendLayout();
            this.page2.SuspendLayout();
            this.page3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closew_btn
            // 
            this.closew_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closew_btn.BackColor = System.Drawing.Color.Transparent;
            this.closew_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closew_btn.FlatAppearance.BorderSize = 0;
            this.closew_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closew_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.closew_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closew_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closew_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.closew_btn.Location = new System.Drawing.Point(851, 20);
            this.closew_btn.Name = "closew_btn";
            this.closew_btn.Size = new System.Drawing.Size(39, 26);
            this.closew_btn.TabIndex = 0;
            this.closew_btn.Text = "X";
            this.closew_btn.UseVisualStyleBackColor = false;
            this.closew_btn.Click += new System.EventHandler(this.closew_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(184)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 93);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(634, 315);
            this.textBox2.TabIndex = 2;
            // 
            // con_state_lable
            // 
            this.con_state_lable.AutoSize = true;
            this.con_state_lable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con_state_lable.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_state_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.con_state_lable.Location = new System.Drawing.Point(371, 23);
            this.con_state_lable.Name = "con_state_lable";
            this.con_state_lable.Size = new System.Drawing.Size(142, 23);
            this.con_state_lable.TabIndex = 3;
            this.con_state_lable.Text = "Disconnected";
            this.con_state_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(352, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 14);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // con_btn
            // 
            this.con_btn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_btn.Location = new System.Drawing.Point(170, 290);
            this.con_btn.Name = "con_btn";
            this.con_btn.Size = new System.Drawing.Size(114, 33);
            this.con_btn.TabIndex = 5;
            this.con_btn.Text = "Connect";
            this.con_btn.UseVisualStyleBackColor = true;
            this.con_btn.Click += new System.EventHandler(this.con_btn_Click);
            // 
            // discon_btn
            // 
            this.discon_btn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discon_btn.Location = new System.Drawing.Point(306, 289);
            this.discon_btn.Name = "discon_btn";
            this.discon_btn.Size = new System.Drawing.Size(113, 34);
            this.discon_btn.TabIndex = 6;
            this.discon_btn.Text = "Disconnect";
            this.discon_btn.UseVisualStyleBackColor = true;
            this.discon_btn.Click += new System.EventHandler(this.discon_btn_Click);
            // 
            // Execute_command_btn
            // 
            this.Execute_command_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Execute_command_btn.Enabled = false;
            this.Execute_command_btn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute_command_btn.ForeColor = System.Drawing.Color.Black;
            this.Execute_command_btn.Location = new System.Drawing.Point(213, 435);
            this.Execute_command_btn.Name = "Execute_command_btn";
            this.Execute_command_btn.Size = new System.Drawing.Size(114, 33);
            this.Execute_command_btn.TabIndex = 7;
            this.Execute_command_btn.Text = "Execute";
            this.Execute_command_btn.UseVisualStyleBackColor = true;
            this.Execute_command_btn.Click += new System.EventHandler(this.Execute_Command_Btn);
            // 
            // q_textbox
            // 
            this.q_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.q_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(184)))));
            this.q_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_textbox.Location = new System.Drawing.Point(16, 477);
            this.q_textbox.Multiline = true;
            this.q_textbox.Name = "q_textbox";
            this.q_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.q_textbox.Size = new System.Drawing.Size(631, 65);
            this.q_textbox.TabIndex = 8;
            this.q_textbox.TextChanged += new System.EventHandler(this.q_textbox_TextChanged);
            // 
            // EntitiesNames_ListBox
            // 
            this.EntitiesNames_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntitiesNames_ListBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntitiesNames_ListBox.FormattingEnabled = true;
            this.EntitiesNames_ListBox.ItemHeight = 22;
            this.EntitiesNames_ListBox.Location = new System.Drawing.Point(473, 65);
            this.EntitiesNames_ListBox.Name = "EntitiesNames_ListBox";
            this.EntitiesNames_ListBox.Size = new System.Drawing.Size(191, 158);
            this.EntitiesNames_ListBox.TabIndex = 9;
            this.EntitiesNames_ListBox.SelectedIndexChanged += new System.EventHandler(this.list_box_1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(470, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tables List:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 251);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 257);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Execute_lable
            // 
            this.Execute_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Execute_lable.AutoSize = true;
            this.Execute_lable.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute_lable.ForeColor = System.Drawing.Color.Snow;
            this.Execute_lable.Location = new System.Drawing.Point(15, 440);
            this.Execute_lable.Name = "Execute_lable";
            this.Execute_lable.Size = new System.Drawing.Size(153, 23);
            this.Execute_lable.TabIndex = 15;
            this.Execute_lable.Text = "Type Command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Log:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // page1
            // 
            this.page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.page1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.page1.Controls.Add(this.label9);
            this.page1.Controls.Add(this.label8);
            this.page1.Controls.Add(this.label7);
            this.page1.Controls.Add(this.label6);
            this.page1.Controls.Add(this.label5);
            this.page1.Controls.Add(this.port_tbx);
            this.page1.Controls.Add(this.database_tbx);
            this.page1.Controls.Add(this.pass_tbx);
            this.page1.Controls.Add(this.user_tbx);
            this.page1.Controls.Add(this.host_tbx);
            this.page1.Controls.Add(this.label4);
            this.page1.Controls.Add(this.con_btn);
            this.page1.Controls.Add(this.discon_btn);
            this.page1.Location = new System.Drawing.Point(216, 64);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(683, 612);
            this.page1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(52, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Database:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(66, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pass:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(66, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "User:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(354, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(66, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Host:";
            // 
            // port_tbx
            // 
            this.port_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tbx.Location = new System.Drawing.Point(425, 85);
            this.port_tbx.Name = "port_tbx";
            this.port_tbx.Size = new System.Drawing.Size(74, 30);
            this.port_tbx.TabIndex = 5;
            // 
            // database_tbx
            // 
            this.database_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_tbx.Location = new System.Drawing.Point(170, 193);
            this.database_tbx.Name = "database_tbx";
            this.database_tbx.Size = new System.Drawing.Size(173, 30);
            this.database_tbx.TabIndex = 4;
            // 
            // pass_tbx
            // 
            this.pass_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tbx.Location = new System.Drawing.Point(170, 157);
            this.pass_tbx.Name = "pass_tbx";
            this.pass_tbx.Size = new System.Drawing.Size(173, 30);
            this.pass_tbx.TabIndex = 3;
            this.pass_tbx.UseSystemPasswordChar = true;
            // 
            // user_tbx
            // 
            this.user_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tbx.Location = new System.Drawing.Point(170, 121);
            this.user_tbx.Name = "user_tbx";
            this.user_tbx.Size = new System.Drawing.Size(173, 30);
            this.user_tbx.TabIndex = 2;
            // 
            // host_tbx
            // 
            this.host_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_tbx.Location = new System.Drawing.Point(170, 85);
            this.host_tbx.Name = "host_tbx";
            this.host_tbx.Size = new System.Drawing.Size(173, 30);
            this.host_tbx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Connection Credintials";
            // 
            // page2
            // 
            this.page2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.page2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.page2.Controls.Add(this.last_id_val);
            this.page2.Controls.Add(this.column_count_val);
            this.page2.Controls.Add(this.row_count_val);
            this.page2.Controls.Add(this.label13);
            this.page2.Controls.Add(this.label12);
            this.page2.Controls.Add(this.label11);
            this.page2.Controls.Add(this.label10);
            this.page2.Controls.Add(this.EntitiesNames_ListBox);
            this.page2.Controls.Add(this.label1);
            this.page2.Controls.Add(this.tableLayoutPanel1);
            this.page2.Location = new System.Drawing.Point(216, 64);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(683, 612);
            this.page2.TabIndex = 19;
            // 
            // last_id_val
            // 
            this.last_id_val.AutoSize = true;
            this.last_id_val.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_id_val.ForeColor = System.Drawing.Color.Snow;
            this.last_id_val.Location = new System.Drawing.Point(176, 144);
            this.last_id_val.Name = "last_id_val";
            this.last_id_val.Size = new System.Drawing.Size(21, 23);
            this.last_id_val.TabIndex = 19;
            this.last_id_val.Text = "-";
            // 
            // column_count_val
            // 
            this.column_count_val.AutoSize = true;
            this.column_count_val.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column_count_val.ForeColor = System.Drawing.Color.Snow;
            this.column_count_val.Location = new System.Drawing.Point(176, 110);
            this.column_count_val.Name = "column_count_val";
            this.column_count_val.Size = new System.Drawing.Size(21, 23);
            this.column_count_val.TabIndex = 18;
            this.column_count_val.Text = "-";
            // 
            // row_count_val
            // 
            this.row_count_val.AutoSize = true;
            this.row_count_val.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row_count_val.ForeColor = System.Drawing.Color.Snow;
            this.row_count_val.Location = new System.Drawing.Point(176, 71);
            this.row_count_val.Name = "row_count_val";
            this.row_count_val.Size = new System.Drawing.Size(21, 23);
            this.row_count_val.TabIndex = 17;
            this.row_count_val.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Snow;
            this.label13.Location = new System.Drawing.Point(51, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "Last ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(20, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Column count:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(35, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Row count:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(20, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tables details";
            // 
            // nav_to_connection_page_btn
            // 
            this.nav_to_connection_page_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nav_to_connection_page_btn.AutoSize = true;
            this.nav_to_connection_page_btn.BackColor = System.Drawing.Color.Transparent;
            this.nav_to_connection_page_btn.FlatAppearance.BorderSize = 0;
            this.nav_to_connection_page_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.nav_to_connection_page_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_to_connection_page_btn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_to_connection_page_btn.ForeColor = System.Drawing.Color.Snow;
            this.nav_to_connection_page_btn.Location = new System.Drawing.Point(0, 160);
            this.nav_to_connection_page_btn.Name = "nav_to_connection_page_btn";
            this.nav_to_connection_page_btn.Size = new System.Drawing.Size(216, 33);
            this.nav_to_connection_page_btn.TabIndex = 20;
            this.nav_to_connection_page_btn.Text = "Connection";
            this.nav_to_connection_page_btn.UseVisualStyleBackColor = false;
            this.nav_to_connection_page_btn.Click += new System.EventHandler(this.nav_to_connection_page_btn_Click);
            // 
            // nav_to_queries_page_btn
            // 
            this.nav_to_queries_page_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nav_to_queries_page_btn.AutoSize = true;
            this.nav_to_queries_page_btn.BackColor = System.Drawing.Color.Transparent;
            this.nav_to_queries_page_btn.FlatAppearance.BorderSize = 0;
            this.nav_to_queries_page_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.nav_to_queries_page_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_to_queries_page_btn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_to_queries_page_btn.ForeColor = System.Drawing.Color.Snow;
            this.nav_to_queries_page_btn.Location = new System.Drawing.Point(0, 260);
            this.nav_to_queries_page_btn.Name = "nav_to_queries_page_btn";
            this.nav_to_queries_page_btn.Size = new System.Drawing.Size(216, 33);
            this.nav_to_queries_page_btn.TabIndex = 21;
            this.nav_to_queries_page_btn.Text = "Queries | Log";
            this.nav_to_queries_page_btn.UseVisualStyleBackColor = false;
            this.nav_to_queries_page_btn.Click += new System.EventHandler(this.nav_to_queries_page_btn_Click);
            // 
            // nav_to_describe_page_btn
            // 
            this.nav_to_describe_page_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nav_to_describe_page_btn.AutoSize = true;
            this.nav_to_describe_page_btn.BackColor = System.Drawing.Color.Transparent;
            this.nav_to_describe_page_btn.FlatAppearance.BorderSize = 0;
            this.nav_to_describe_page_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.nav_to_describe_page_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_to_describe_page_btn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_to_describe_page_btn.ForeColor = System.Drawing.Color.Snow;
            this.nav_to_describe_page_btn.Location = new System.Drawing.Point(0, 210);
            this.nav_to_describe_page_btn.Name = "nav_to_describe_page_btn";
            this.nav_to_describe_page_btn.Size = new System.Drawing.Size(216, 33);
            this.nav_to_describe_page_btn.TabIndex = 22;
            this.nav_to_describe_page_btn.Text = "Describe DB";
            this.nav_to_describe_page_btn.UseVisualStyleBackColor = false;
            this.nav_to_describe_page_btn.Click += new System.EventHandler(this.nav_to_describe_page_btn_Click);
            // 
            // page3
            // 
            this.page3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.page3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.page3.Controls.Add(this.q_textbox);
            this.page3.Controls.Add(this.label3);
            this.page3.Controls.Add(this.Execute_lable);
            this.page3.Controls.Add(this.Execute_command_btn);
            this.page3.Controls.Add(this.label2);
            this.page3.Controls.Add(this.textBox2);
            this.page3.Location = new System.Drawing.Point(216, 64);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(680, 612);
            this.page3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Queries | Log";
            // 
            // change_size_btn
            // 
            this.change_size_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change_size_btn.BackColor = System.Drawing.Color.Transparent;
            this.change_size_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.change_size_btn.FlatAppearance.BorderSize = 0;
            this.change_size_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.change_size_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.change_size_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_size_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_size_btn.ForeColor = System.Drawing.Color.Gold;
            this.change_size_btn.Location = new System.Drawing.Point(810, 19);
            this.change_size_btn.Name = "change_size_btn";
            this.change_size_btn.Size = new System.Drawing.Size(35, 27);
            this.change_size_btn.TabIndex = 24;
            this.change_size_btn.Text = "O";
            this.change_size_btn.UseVisualStyleBackColor = false;
            this.change_size_btn.Click += new System.EventHandler(this.change_size_btn_Click);
            // 
            // minmize_btn
            // 
            this.minmize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minmize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minmize_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minmize_btn.FlatAppearance.BorderSize = 0;
            this.minmize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minmize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.minmize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minmize_btn.ForeColor = System.Drawing.Color.SpringGreen;
            this.minmize_btn.Location = new System.Drawing.Point(769, 17);
            this.minmize_btn.Name = "minmize_btn";
            this.minmize_btn.Size = new System.Drawing.Size(35, 27);
            this.minmize_btn.TabIndex = 25;
            this.minmize_btn.Text = "-";
            this.minmize_btn.UseVisualStyleBackColor = false;
            this.minmize_btn.Click += new System.EventHandler(this.minmize_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.nav_to_connection_page_btn);
            this.panel2.Controls.Add(this.nav_to_describe_page_btn);
            this.panel2.Controls.Add(this.nav_to_queries_page_btn);
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 708);
            this.panel2.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Snow;
            this.label15.Location = new System.Drawing.Point(6, 677);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "GitHub: xXmelar-ksaXx";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DBConn.Properties.Resources.icon2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(17, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 111);
            this.panel3.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(216, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(708, 1);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Snow;
            this.label14.Location = new System.Drawing.Point(222, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "DB State :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(925, 703);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.minmize_btn);
            this.Controls.Add(this.change_size_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.con_state_lable);
            this.Controls.Add(this.closew_btn);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.page3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.page3.ResumeLayout(false);
            this.page3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closew_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label con_state_lable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button con_btn;
        private System.Windows.Forms.Button discon_btn;
        private System.Windows.Forms.Button Execute_command_btn;
        private System.Windows.Forms.TextBox q_textbox;
        private System.Windows.Forms.ListBox EntitiesNames_ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Execute_lable;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox port_tbx;
        private System.Windows.Forms.TextBox database_tbx;
        private System.Windows.Forms.TextBox pass_tbx;
        private System.Windows.Forms.TextBox user_tbx;
        private System.Windows.Forms.TextBox host_tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nav_to_describe_page_btn;
        private System.Windows.Forms.Button nav_to_queries_page_btn;
        private System.Windows.Forms.Button nav_to_connection_page_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel page3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label row_count_val;
        private System.Windows.Forms.Label last_id_val;
        private System.Windows.Forms.Label column_count_val;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minmize_btn;
        private System.Windows.Forms.Button change_size_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private Label label15;
    }
}

