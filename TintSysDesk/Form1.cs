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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var n = Nivel.ObterPorId(1);
            label1.Text = n.Id.ToString();
            label2.Text = n.Nome;
            label3.Text = n.Sigla;

            comboBox1.DataSource = Nivel.Listar();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            
            Nivel nivel = new Nivel("Gerente", "GER");
            nivel.Inserir();
            if (nivel.Id > 0)
            {
                MessageBox.Show(nivel.Id.ToString());
            }
        }
    }
}
