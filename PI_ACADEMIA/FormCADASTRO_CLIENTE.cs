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
    public partial class FormCADASTRO_CLIENTE : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public FormCADASTRO_CLIENTE()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_academia;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

       
        

       
        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            string genero = "masculino";
            if (radioButtonMASCULINO.Checked)
            {
                genero = "masculino";
            }
            else
            {
                genero = "feminino";
            }
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_cliente(nome, sobrenome, cpf, celular, sexo, ficha_treino) VALUES ('" + textBox_NOME.Text + "', '" + textBoxSOBRENOME.Text + "', '" + textBoxCELULAR.Text + "', '" + textBoxCPF.Text + "', '" + textBoxFICHA_TREINO.Text + "', '" + genero + "');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");
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

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxCPF.Clear();
            textBoxCELULAR.Clear();
            textBoxFICHA_TREINO.Clear();
            textBoxSOBRENOME.Clear();
            textBox_NOME.Clear();
        }
    }
} 
