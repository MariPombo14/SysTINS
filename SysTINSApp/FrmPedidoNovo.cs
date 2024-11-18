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

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {

        }

        //private void btnAdicionar_Click(object sender, EventArgs e)
        //{
        //    Produto produto = new(
        //        txtCodBar.Text,
        //        txtDescricao.Text,
        //        double.Parse(txtValorUnit.Text),
        //        txtUnidadeVenda.Text,
        //        Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
        //        (double)npEstoqueMinimo.Value, // cast usar um double para converter um decimal 
        //        double.Parse(txtDesconto.Text) // o meteodo parse converte string para o int
        //        );
        //    produto.Inserir();
        //    if (produto.Id > 0)
        //    {
        //        txtId.Text = produto.Id.ToString(); // Converte essa saida para string 
        //        CarregaGrid();
        //        MessageBox.Show($"Produto cadastrado com o ID {produto.Id}");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Falha ao inserir o produto!");
        //    }

    }
}
}
