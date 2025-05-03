using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = textBox3.Text;
            string user = textBox1.Text;
            string password = textBox2.Text;
            string puerto = textBox5.Text;
            string database = textBox4.Text;

            string connectionstring = $"SERVER={host};PORT={puerto};DATABASE={database};USER={user};PASSWORD={password}";

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("La conexion se ha efectuado");
                    conn.Close();
                }
                catch (Exception ex) { 
             
                    if (conn.State.Equals(ConnectionState.Open))
                    {
                        conn.Close();
                    }
                    MessageBox.Show("Ha acurrido un error" + ex.Message);

                }
            }
        }
                
    }
}
