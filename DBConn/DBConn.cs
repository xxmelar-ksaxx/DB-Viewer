using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Drawing;
//using NHibernate.Tool.hbm2ddl;
using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json;

namespace DBConn

{
    internal class DBConn : Form
    {

        public MySqlConnection conn;

        
        public string Host { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string databaseName { get; set; }
        public List<string> Tables;

        public string DBconnect()
        {
            string myConnectionString;
            myConnectionString = "server="+Host+";uid="+User+";" +
            "pwd="+Pass+";database="+databaseName;
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                
                dynamic stuff1 = queury("show tables");

                Tables = new List<string>();
                foreach (dynamic i in stuff1)
                {
                    string r = i["Tables_in_"+databaseName];
                    Tables.Add(r);
                }

                return "200"; // Ok msg
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return "404"; // Err msg
            }
        }
        public string DBdisconnect()
        {
            try
            {
                conn.Close();
              
                return "200";
            }
            catch {
                return "404";
            }
        }

        public object connStatus()
        {
            return conn.State.ToString();
        }

        public dynamic queury(string sql)
        {
            try
            {

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp=new MySqlDataAdapter();
            adp.SelectCommand = cmd;

            DataTable dTable = new DataTable();
            adp.Fill(dTable);

            DataTable res = new DataTable();
            adp.Fill(res);

            string jsonStr = DataTableToJSONWithJSONNet(res);

            return JsonConvert.DeserializeObject(jsonStr);
            }
            catch
            {
                return "querie error!!";
            }
        }

        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        public List<string> getColumns(string tableName)
        {
            List<string> columnsList = new List<string>();
            dynamic stuff1 = queury("describe " + tableName);
            foreach (dynamic i in stuff1)
            {
                string r = i["Field"];
                columnsList.Add(r);
            }

            return columnsList;
        }

        public dynamic getRows(string tableName)
        {
            dynamic stuff1 = queury("select * from " + tableName);
            return stuff1;
        }
        

    }
}
