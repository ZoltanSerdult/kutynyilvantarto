using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kutynyilvantarto
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_mutat_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "kutya";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ToString());
            sql = connection.CreateCommand();
            Kutyabetoltes();
        }

        private void Kutyabetoltes()
        {
            ListBox_mutat.Items.Clear();
            try
            {
                connection.Open();
                sql.CommandText = "SELECT nev, fajta, suly, szuletett FROM kutyak";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kutyak kutya = new Kutyak(dr.GetString("nev"),dr.GetString("fajta"),dr.GetDouble("suly"),dr.GetInt32("szuletett"));
                        ListBox_mutat.Items.Add(kutya);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
