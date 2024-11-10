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
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Produto_Load(object sender, EventArgs e)
        {
            {
                // carregando o combobox de níveis
                cmbCategoria.DataSource = Categoria.ObterLista();
                cmbCategoria.DisplayMember = "Nome";
                cmbCategoria.ValueMember = "Id";

                // carrega grid
                CarregaGridProduto();
            }

            private void btnInserir_Click(object sender, EventArgs e)
            {
                Produto produto = new(
                                   txtCodBar.Text,
                                   txtDesc.Text,
                                   txtVlUnit.Text,
                                   txtUnidadeVenda.Text,
                                   Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                                   txtEstoqueMinimo.Text,
                                   txtDesconto.Text,
                                   txtData_Cadastro.Text);
                produto.Inserir();
                if (produto.Id > 0)
                {
                    // carrega grid
                    // carregando o datagrid de usuários
                    CarregaGridProduto();
                    MessageBox.Show($"Produto {produto.Descricao} inserido com sucesso");
                    btnInserir.Enabled = false;
                }

                private void CarregaGridProduto()
                {
                    dgvProduto.Rows.Clear();
                    var listaDeProdutos = Produto.ObterLista(); // metodo static da classe  //metodo nao statico é do objeto ou instancia
                    int linha = 0;
                    foreach (var produto in listaDeProdutos)       // foreach (Para cada usuario dentro da lista de Usuarios faça)  
                    {
                        dgvProduto.Rows.Add();
                        dgvProduto.Rows[linha].Cells[0].Value = produto.Id;
                        dgvProduto.Rows[linha].Cells[1].Value = produto.CodBar;
                        dgvProduto.Rows[linha].Cells[2].Value = produto.Descricao;
                        dgvProduto.Rows[linha].Cells[3].Value = produto.ValorUnit;
                        dgvProduto.Rows[linha].Cells[4].Value = produto.UnidadeVenda;
                        dgvProduto.Rows[linha].Cells[5].Value = produto.Categoria.Nome;
                        dgvProduto.Rows[linha].Cells[6].Value = produto.EstoqueMinimo;
                        dgvProduto.Rows[linha].Cells[7].Value = produto.ClasseDesconto;
                        dgvProduto.Rows[linha].Cells[9].Value = produto.DataCad;
                        linha++;
                    }
                }


            }

        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvProduto.CurrentRow.Index + 1;
            int idProduto = Convert.ToInt32(dgvProduto.Rows[linhaAtual].Cells[0].Value);
            var Produto = produto.ObterporId(idProduto);
            txtId.Text = produto.Id.ToString();
            txtCodBar.Text = produto.CodBar;
            txtEmail.Text = produto.Email;
            cmbNivel.SelectedValue = produto.Nivel.Id;
            btnAtualizar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Produto produto = new();
            produto.Id = int.Parse(txtId.Text);
            produto.Nome = txtNome.Text;
            produto.Senha = txtSenha.Text;
            produto.Categoria = Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue));
            if (Categoria.Atualizar())
            {
                CarregaGridProduto();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
        }
    }
}
}
