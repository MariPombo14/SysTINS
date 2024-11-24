using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmPedidoNovo : Form
    {
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            CarregaGridPedidoNovo();

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
           Pedido pedido = new(
           Usuario.ObterporId (Convert.ToInt32(txtUsuario.Text)),
           Cliente.ObterPorId(Convert.ToInt32(txtIdCliente.Text))
            );
        }

        private void CarregaGridPedidoNovo()
        {
            var listaPedido = Pedido.ObterLista();
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            foreach (var pedido in listaPedido)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = pedido.Id;
                dgvItensPedido.Rows[linha].Cells[1].Value = pedido.Usuario;
                dgvItensPedido.Rows[linha].Cells[2].Value = pedido.Cliente;
                dgvItensPedido.Rows[linha].Cells[3].Value = pedido.Data;
                dgvItensPedido.Rows[linha].Cells[4].Value = pedido.Desconto;
                dgvItensPedido.Rows[linha].Cells[5].Value = pedido.Items;
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //ItemPedido itemPedido = new(
            // txtIdPedido.Text,
            // Produto.ObterPorId(Convert.ToInt32(txtCodBar.Text)),
            // txtQuantidade.Text,
            // txtDescontoItem.Text
            //  );
        }
    }
}
