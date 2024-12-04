using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuriloVieiraDESK
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cliente = new(
              txtNome.Text,
              txtEmail.Text,
              txtTelefone.Text,
              txtEndereco.Text
              );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                CarregaGridCliente();
                MessageBox.Show($"Cliente {cliente.Id} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
