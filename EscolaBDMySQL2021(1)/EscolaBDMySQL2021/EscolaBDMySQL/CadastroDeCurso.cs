using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaBDMySQL
{
    public partial class CadastroDeCurso : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conexao
           = new MySql.Data.MySqlClient.MySqlConnection(
               "server=localhost; user id=root; password=12345; database=escola");
        MySql.Data.MySqlClient.MySqlCommand stm;

        public CadastroDeCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botão Cadastrar
            try
            {
                string sqlNovo = "INSERT  INTO cursos (abrev,descricao) VALUES "
                               + "('" + textBox1.Text + "','" + textBox2.Text + "');";
                stm = new MySql.Data.MySqlClient.MySqlCommand(sqlNovo, conexao);
                int quant = stm.ExecuteNonQuery();
                if (quant == 1)
                {
                    MessageBox.Show(null, "Curso inserido.", "OK.");
                }
                stm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Erro adicionando curso" + ex.Message, "Erro");
            }

        }

        private void CadastroDeCurso_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Erro na conexão" + ex.Message, "Erro");
            }

        }

        private void CadastroDeCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexao.Close();
        }
    }
}
