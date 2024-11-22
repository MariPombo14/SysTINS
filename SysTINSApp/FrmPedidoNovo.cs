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
            CarregaGrid();

        }
        // private void btnInserir_Click(object sender, EventArgs e)
        //{
        //    Cliente cliente = new(
        //       txtNome.Text,
        //       txtCpf.Text,
        //       txtTelefone.Text,
        //       txtEmail.Text,
        //       DataNasc.Value,
        //       chkAtivo.Checked

        //       );
        //    cliente.Inserir();
        //    if (cliente.Id > 0)
        //    {
        //        //carrega grid
        //        CarregaGridClientes();
        //        MessageBox.Show($"Cliente {cliente.Nome} inserido com sucesso");
        //        btnInserir.Enabled = false;
        //    }


        //}

       /private void btnInserePedido_Click(object sender, EventArgs e)
        {
         Pedido pedido = new(
            txtUsuario.Text,
             txtIdCliente
               );
         }
        private void CarregaGrid()
        {
            var listaitempedido = ItemPedido.ObterItensPorPedidoId();

            dgvItensPedido.Rows.Clear();

            int linha = 0;

            foreach (var itempedido in listaitempedido) 

            {

                dgvItensPedido.Rows.Add();

                dgvItensPedido.Rows[linha].Cells[0].Value = itempedido.Id;

                dgvItensPedido.Rows[linha].Cells[1].Value = itempedido.Produto.CodBar;

                dgvItensPedido.Rows[linha].Cells[2].Value = itempedido.Produto.Descricao;

                dgvItensPedido.Rows[linha].Cells[3].Value = "R$ " + itempedido.ValorUnit.ToString("#0.00");

                dgvItensPedido.Rows[linha].Cells[4].Value = itempedido.Quantidade;

              / dgvItensPedido.Rows[linha].Cells[5].Value = itempedido.Desconto;

               //dgvProdutos.Rows[linha].Cells[6].Value = TotalItem;
                // var quantidade * valorUnit = total
                linha++;

            }

        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
             ItemPedido itempedido = new(
             txtIdPedido.Text,
             Produto.ObterPorId(txtCodBar.Text),
             Produto.ObterPorId(txtDescricao.Text),
             double.Parse(txtValorUnit.Text),
             double.Parse(txtQuantidade.Text),
             double.Parse(txtDescontoItem.Text)
             );

        }
    }
}
