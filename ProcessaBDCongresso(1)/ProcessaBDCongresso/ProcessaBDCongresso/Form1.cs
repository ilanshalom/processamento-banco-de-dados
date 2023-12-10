using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProcessaBDCongresso
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand stm;
        private MySqlDataReader rs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("server=localhost; port=3306; user id=root; password=12345; "
                                          + " database=congresso;");
            conexao.Open(); String str = "";
            stm = new MySqlCommand("SELECT * FROM paises ORDER BY pais", conexao);
            //stm.Prepare();
            rs = stm.ExecuteReader();
            while ( rs.Read() )
            {
                str += rs.GetString("pais") 
                    + ", " + rs.GetString("continente") + ", " + rs.GetString("continente")
                    + ", " + rs.GetString("capital") + ", " + rs.GetString("populacao");
                str += "\r\n";
            }
            textBox1.Text = str;
            rs.Close();
            stm.Dispose();
            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
