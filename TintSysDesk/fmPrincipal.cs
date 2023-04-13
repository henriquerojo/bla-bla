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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.ObterPorId(1);
            Usuario usuario = Usuario.ObterPorId(1);
            Pedido pedido = new Pedido(cliente, usuario);
            pedido.Inserir();
            
            MessageBox.Show(pedido.Hashcode);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmusuarios = new FrmUsuarios();
            frmusuarios.MdiParent = this;
            //frmusuarios.ShowDialog();
            frmusuarios.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente= new frmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto= new frmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.MdiParent = this;
            frmPedido.Show();
        }
    }
}
