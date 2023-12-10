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

namespace EscolaBDMySQL
{
    public partial class Form1 : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection conexao
              = new MySql.Data.MySqlClient.MySqlConnection(
                "server=localhost; port=3306; user id = root; password=12345; database=escola; ");
        private MySql.Data.MySqlClient.MySqlCommand stm;
        private MySql.Data.MySqlClient.MySqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                string cursoSelec = (string)(listBox1.SelectedItem);
                string sql = "SELECT * FROM alunos WHERE curso='" + cursoSelec + "'";
                conexao.Open();
                stm = new MySql.Data.MySqlClient.MySqlCommand(sql, conexao);
                dr = stm.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(dr.GetString(1) + ", sexo: " + dr.GetString(3) + ", semestre: " + dr.GetString(4));
                }
                dr.Close();
                stm.Dispose();
                conexao.Close();
            }
            catch (Exception exmos) { }
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexao.Open();
            stm = new MySqlCommand("SELECT * FROM cursos ORDER BY abrev", conexao);
            //stm.Prepare();
            dr = stm.ExecuteReader();
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr.GetString("abrev"));
            }
            dr.Close();
            stm.Dispose();
            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroDeCurso curs = new CadastroDeCurso();
            curs.ShowDialog();
        }
    }
}
