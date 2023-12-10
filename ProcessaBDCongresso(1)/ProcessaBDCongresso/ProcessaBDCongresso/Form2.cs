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

namespace ProcessaBDCongresso
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            MySqlConnection conexao;
            MySqlCommand stm;
            MySqlDataReader rs;
            string paisSelec = listBox1.SelectedItem.ToString();
            conexao = new MySqlConnection("server=localhost; port=3306; user id=root; password=12345; "
                                          + " database = congresso; ");
            conexao.Open();
            stm = new MySqlCommand("SELECT * FROM participantes WHERE pais='" + paisSelec + "' ORDER BY nome", conexao);
            rs = stm.ExecuteReader();
            textBox1.Text = "";
            string str = "";
            while (rs.Read()) {
                str += rs.GetString("nome") + "\r\n";
            }
            textBox1.Text = str;
            rs.Close();
            stm.Dispose();
            conexao.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao;
            MySqlCommand stm;
            MySqlDataReader rs;
            conexao = new MySqlConnection("server=localhost; port=3306; user id=root; password=12345; "
                                          + " database = congresso;");
            conexao.Open();
            stm = new MySqlCommand("SELECT * FROM paises ORDER BY pais", conexao);
            rs = stm.ExecuteReader();
            listBox1.Items.Clear();
            while (rs.Read())
            {
                listBox1.Items.Add(rs.GetString("pais"));
            }
            rs.Close();
            stm.Dispose();
            conexao.Close();
        }
    }
}
