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
    public partial class RedefinirSenha : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public RedefinirSenha()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_academia;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonATUALIZAR_Click(object sender, EventArgs e)
        {
            if (textBoxCONFIRMASENHA.Text != "" && textBoxSENHA.Text != "")
            {

                try
                {
                    conexao.Open();
                    comando.CommandText = "UPDATE tbl_login SET senha= '" + textBoxSENHA.Text + "' WHERE 1;";

                    if (textBoxSENHA.Text == textBoxCONFIRMASENHA.Text) {
                        MySqlDataReader resultado = comando.ExecuteReader();

                        MessageBox.Show("Senha atualizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("As senhas precisam estar iguais");
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
            else
            {
                MessageBox.Show("Por Favor prencher todos os campos");
            }
        }
    }
}
