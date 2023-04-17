using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;

namespace TintSysDesk
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tpgDados_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            tpgEnderecos.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
            txtNome.Text,
            mktCpf.Text,
            txtEmail.Text
            );
            cliente.Inserir();
            txtID.Text = cliente.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtID.Text);
        }
    }
}
