using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;

namespace TintSysDesk
{
    public partial class FrmUsuarios : Form
    {
        private void CarregaGrid()
        {
            List<Usuario> lista = Usuario.Listar();
            int linha = 0;
            dgvUsuarios.Rows.Clear();
            foreach (Usuario iten in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = iten.Id.ToString();
                dgvUsuarios.Rows[linha].Cells[1].Value = iten.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = iten.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = iten.Nivel.Nome;
                dgvUsuarios.Rows[linha].Cells[4].Value = iten.Ativo;
                linha++;
            }
        }
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nivel  n = new Nivel();
            n.Inserir();
            //CarregaComboNivel();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Nivel n = Nivel.ObterPorId(Convert.ToInt32(txtIdNivel.Text));
            if (n != null)
            {
                txtNomeNivel.Text = n.Nome;
                txtSigla.Text = n.Sigla;
            }
            else
            {
                MessageBox.Show("´Nível não localizado!");
                txtSigla.Clear();
                txtNomeNivel.Clear();
                txtIdNivel.Focus();
                txtIdNivel.Clear();

            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarNivel_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarNivel_Click(object sender, EventArgs e)
        {
            Nivel n = new Nivel(Convert.ToInt32(txtIdNivel.Text), txtNomeNivel.Text, txtSigla.Text);
            n.Atualizar();
            CarregaComboNivel();
            CarregaGridNiveis();
            CarregaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CarregaGridNiveis()
        {
            List<Nivel> lista = Nivel.Listar();
            int linha = 0;
            foreach (Nivel iten in lista)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[linha].Cells[0].Value = iten.Id.ToString();
                dgvNiveis.Rows[linha].Cells[1].Value = iten.Nome;
                dgvNiveis.Rows[linha].Cells[2].Value = iten.Sigla;

                linha++;
            }
        }

        private void CarregaComboNivel()
        {
            comboBox1.DataSource = Nivel.Listar();
            comboBox1.ValueMember= "Id";
            comboBox1.DisplayMember= "Nome";
        }
    }

}
