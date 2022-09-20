using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHibernate.Stat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBConn
{
    public partial class Form1 : Form
    {

        List<Panel> listPanel = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void closew_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        System.Threading.Thread t;

        int myWidth = 925;
        int myHeight = 703;

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(page1); // Connection
            listPanel.Add(page2); // Descripe
            listPanel.Add(page3); // Queries & Log
            listPanel[0].Show();
            listPanel[1].Hide();
            listPanel[2].Hide();

            this.ClientSize = new Size(myWidth, myHeight);

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // resizing varibles
        bool resizeWindowEnable = false;
        bool mouseIsDown = false;
        bool mouseIsDown_2_X = false;
        bool mouseIsDown_2_Y = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (resizeWindowEnable && e.Button == MouseButtons.Left)
            {
                mouseIsDown = true;
            }
            else if (e.Button == MouseButtons.Left && mouseIsDown == false)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // reset resising varibles
                mouseIsDown = false;
                mouseIsDown_2_X = false;
                mouseIsDown_2_Y = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DBConn db = new DBConn();
        private void con_btn_Click(object sender, EventArgs e)
        {
           
            db.Host = this.host_tbx.Text;
            if (this.port_tbx.Text!= string.Empty && this.port_tbx.Text != "")
            {
                db.Host += ":" + this.port_tbx.Text;
            }
            db.User = this.user_tbx.Text;
            db.Pass = this.pass_tbx.Text;
            db.databaseName = this.database_tbx.Text;

            string conn_state = db.DBconnect();
            if (conn_state == "200") // Ok
            {
                // get and display Tables/Entities names
                this.EntitiesNames_ListBox.Items.Clear();
                foreach (string tn in db.Tables) {this.EntitiesNames_ListBox.Items.Add(tn);}
          
                isConnected(true);
            }
            else
            {
                isConnected(false, "conn_failed");
            }
            
        }

        private void discon_btn_Click(object sender, EventArgs e)
        {
            if (db.DBdisconnect() == "200") //Ok
            {
                isConnected(false);
            }
            else
            {
                isConnected(false, "disconn_failed");
            }
        }

        private void myCliPrint(dynamic msg)
        {
            this.textBox2.Text += msg + "\r\n";
            textBox2.SelectionStart = textBox2.TextLength;
            this.textBox2.ScrollToCaret();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //this.panel1.BackColor= Color.White;
        }

        private void Execute_Command_Btn(object sender, EventArgs e)
        {
            myCliPrint(db.queury(q_textbox.Text));
        }

        private void q_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetUI()
        {
            this.EntitiesNames_ListBox.Items.Clear();
            this.tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 1;
        }
        private void DisableUIFeatures()
        {
            this.Execute_command_btn.Enabled = false;
        }
        private void EnableUIFeatures()
        {
            this.Execute_command_btn.Enabled = true;
        }
        private void isConnected(bool state, string type="")
        {
            if (state)
            {
                this.panel1.BackColor = Color.FromArgb(138, 201, 38);
                this.con_state_lable.ForeColor = Color.FromArgb(138, 201, 38);
                this.con_state_lable.Text = "Connected";
                EnableUIFeatures();
                myCliPrint("Connected Ok");
            }
            else
            {
                if (type == "disconn_failed")
                {
                    myCliPrint("Disconnection falied !!");
                }
                else if(type=="conn_failed"){
                    resetUI();
                    DisableUIFeatures();
                    this.panel1.BackColor = Color.FromArgb(230, 57, 70);
                    this.con_state_lable.ForeColor = Color.FromArgb(230, 57, 70);
                    this.con_state_lable.Text = "Disconnected";
                    myCliPrint("Connection failed!!");
                }
                else // Disconnected Ok
                {
                    DisableUIFeatures();
                    resetUI();
                    this.panel1.BackColor = Color.FromArgb(230, 57, 70);
                    this.con_state_lable.ForeColor = Color.FromArgb(230, 57, 70);
                    this.con_state_lable.Text = "Disconnected";
                    myCliPrint("Disconnected Ok");
                }
            }
        }

        private void list_box_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Reset table row&column positions
            this.tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 1;


            List<string> columns = db.getColumns((string)this.EntitiesNames_ListBox.SelectedItem);
            this.tableLayoutPanel1.ColumnCount = columns.Count + 1;
            // details values
            try {
                this.row_count_val.Text = (dynamic)db.queury("select count(id) from " + this.EntitiesNames_ListBox.SelectedItem)[0]["count(id)"];
                this.column_count_val.Text = string.Concat(columns.Count);
                this.last_id_val.Text = (dynamic)db.queury("select max(id) from " + this.EntitiesNames_ListBox.SelectedItem)[0]["max(id)"];
            }
            catch
            {

            }

            for (int i=0; i < columns.Count; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                
            }
            //this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

            int count = 0;
            foreach (string i in columns)
            {
                Label label = new Label();
                count++;
                label.Text = i;
                label.AutoSize = true;
                this.tableLayoutPanel1.Controls.Add(label, count, 0);
                
            }

            dynamic drows = db.getRows((string)this.EntitiesNames_ListBox.SelectedItem);

            foreach (dynamic i in drows)
            {

                this.tableLayoutPanel1.RowCount = this.tableLayoutPanel1.RowCount + 1;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                int rcount = 0;
                foreach (dynamic j in columns)
                {
                    rcount++;
                    this.tableLayoutPanel1.Controls.Add(new Label() { Text = i[j] }, rcount, this.tableLayoutPanel1.RowCount - 1);
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nav_to_connection_page_btn_Click(object sender, EventArgs e)
        {
            listPanel[0].Show();
            listPanel[1].Hide();
            listPanel[2].Hide();
        }

        private void nav_to_describe_page_btn_Click(object sender, EventArgs e)
        {
            //listPanel[1].BringToFront();
            listPanel[0].Hide();
            listPanel[1].Show();
            listPanel[2].Hide();
        }

        private void nav_to_queries_page_btn_Click(object sender, EventArgs e)
        {   
            //listPanel[2].BringToFront();
            listPanel[0].Hide();
            listPanel[1].Hide();
            listPanel[2].Show();
        }

        private void minmize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void change_size_btn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
            //// Form resizing

            // below commented block is corners resizing

            //if ((e.X <= 2 && e.Y <= 2) || (e.X + 2 >= this.Width && e.Y + 2 >= this.Height))
            //{
            //    this.Cursor = Cursors.SizeNWSE;
            //}
            //else if ((e.X + 2 >= this.Width && e.Y <= 2) || (e.X <= 2 && e.Y + 2 >= this.Height))
            //{
            //    this.Cursor = Cursors.SizeNESW;
            //}

            // Width resizeing
            if (e.X <= 10 || e.X + 10 >= this.Width || mouseIsDown_2_X)
            {
                this.Cursor = Cursors.SizeWE;
                resizeWindowEnable = true;
                if (mouseIsDown)
                {
                    this.ClientSize = new Size(Cursor.Position.X - this.Location.X, this.Height);
                    panel3.Hide();
                    panel3.Show();
                    mouseIsDown_2_X = true;
                }
            }
            // Hieght resizing
            else if ( e.Y <= 2 || e.Y + 10 >= this.Height || mouseIsDown_2_Y)
            {
                this.Cursor = Cursors.SizeNS;
                resizeWindowEnable = true;
                if (mouseIsDown)
                {
                    this.ClientSize = new Size(this.Width, Cursor.Position.Y - this.Location.Y);
                    panel3.Hide();
                    panel3.Show();
                    mouseIsDown_2_Y = true;
                }
            }
            else
            {
                resizeWindowEnable = false;
                this.Cursor = Cursors.Default;
            }
        }

        
    }
}
