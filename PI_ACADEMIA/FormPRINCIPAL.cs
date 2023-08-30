using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ACADEMIA
{
    public partial class FormPRINCIPAL : Form
    {
        public FormPRINCIPAL()
        {
            InitializeComponent();
        }

        private void FormPRINCIPAL_Load(object sender, EventArgs e)
        {
           
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO_CLIENTES = new FormCADASTRO_CLIENTE();
            telaCADASTRO_CLIENTES.Show();
            telaCADASTRO_CLIENTES.WindowState = FormWindowState.Maximized;
        }
    }
}
