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
    public partial class FrmEnderecos : Form
    {
        public FrmEnderecos()
        {
            InitializeComponent();
        }

        private void FrmEnderecos_Load(object sender, EventArgs e)
        {
            CarregaGridEnderecos();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Endereco endereco = new(
            ///txtCliente_Id.Text,
            //txtCep.Text,
            //txtLogradouro.Text,
            //txtNumero.Text,
            //txtComplemento.Text,
            //txtBairro.Text,
            //txtCidade.Text,
            //cmbUf.Text,
            //txtTpEndereco.Text);
        }

        private void CarregaGridEnderecos()
        {
            //dgvEnderecos.Rows.Clear();
            //var listaDeEnderecos = Endereco.ObterListaPorClienteId;
            //int linha = 0;
            //foreach (var enderecos in listaDeEnderecos)
            //{
            //    dgvEnderecos.Rows.Add();
            //    dgvEnderecos.Rows[linha].Cells[0].Value = enderecos.Id;
            //    dgvEnderecos.Rows[linha].Cells[1].Value = enderecos.Cliente_id;
            //    dgvEnderecos.Rows[linha].Cells[2].Value = enderecos.Cep;
            //    dgvEnderecos.Rows[linha].Cells[3].Value = enderecos.Logradouro;
            //    dgvEnderecos.Rows[linha].Cells[4].Value = enderecos.Numero;
            //    dgvEnderecos.Rows[linha].Cells[5].Value = enderecos.Complemento;
            //    dgvEnderecos.Rows[linha].Cells[6].Value = enderecos.Bairro;
            //    dgvEnderecos.Rows[linha].Cells[7].Value = enderecos.Cidade;
            //    dgvEnderecos.Rows[linha].Cells[8].Value = enderecos.TipoEndereco;
            //    dgvEnderecos.Rows[linha].Cells[9].Value = enderecos.Uf;
            //    linha++;
            //}
        }

        private void dgvEnderecos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvEnderecos.CurrentRow.Index;
            int idEnderecos = Convert.ToInt32(dgvEnderecos.Rows[linhaAtual].Cells[0].Value);
            var enderecos = Endereco.ObterPorId(idEnderecos);
            txtId.Text = enderecos.Id.ToString();
            txtCliente_Id.Text = enderecos.Id.ToString();
            txtCep.Text = enderecos.Cep;
            txtLogradouro.Text = enderecos.Logradouro;
            txtNumero.Text = enderecos.Numero;
            txtComplemento.Text = enderecos.Complemento;
            txtBairro.Text = enderecos.Bairro;
            txtCidade.Text = enderecos.Cidade;
            txtTpEndereco.Text = enderecos.TipoEndereco;
            cmbUf.SelectedText = enderecos.Uf;
            btnAtualizar.Enabled = true;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new();
            endereco.Id = int.Parse(txtId.Text);
            txtCliente_Id.Text = endereco.Id.ToString();
            txtCep.Text = endereco.Cep;
            txtLogradouro.Text = endereco.Logradouro;
            txtNumero.Text = endereco.Numero;
            txtComplemento.Text = endereco.Complemento;
            txtBairro.Text = endereco.Bairro;
            txtCidade.Text = endereco.Cidade;
            txtTpEndereco.Text = endereco.TipoEndereco;

            if (endereco.Atualizar())
            {
                CarregaGridEnderecos();
                MessageBox.Show("Endereço atualizado com sucesso!");
            }

        }
    }
}
