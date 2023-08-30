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

namespace PI_ACADEMIA
{
    public partial class Cadastro_de_Clientes : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public Cadastro_de_Clientes()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_academia;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_cliente(nome, sobrenome, cpf, celular, sexo, ficha_treino) VALUES ("'++'",'[value-2]','[value-3]','[value-4]','[value-5]','[value-6]');";

                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    MessageBox.Show("Usuário e senha corretos!");
                }



            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
