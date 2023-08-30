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
    public partial class LOGIN : Form
    {

        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public LOGIN()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_academia;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            Form TELALOGIN = new LOGIN();

            string hexcolor = "#0064c9";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexcolor);
            TELALOGIN.BackColor = myColor;
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            if (textBoxUSUARIO.Text != "" && textBoxSENHA.Text != "")
            {

                try
                {
                    conexao.Open();
                    comando.CommandText = "SELECT usuario, senha FROM tbl_login WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                    MySqlDataReader resultado = comando.ExecuteReader();
                    if (resultado.Read())
                    {
                     
                        Form telaPRINCIPAL = new FormPRINCIPAL();
                        telaPRINCIPAL.ShowDialog();
                    }
                    else
                    {
                        string message = "Usuário e senha de login estão incorretos";
                        string title = "Erro login";
                        MessageBox.Show(message, title);
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

        private void label4_Click(object sender, EventArgs e)
        {
            Form telaREDEFINIR = new RedefinirSenha();
            telaREDEFINIR.Show();
        }
    }
}
