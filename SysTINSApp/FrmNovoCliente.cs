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
    public partial class FrmNovoCliente : Form
    {
        public FrmNovoCliente()
        {
            InitializeComponent();
        }

        private void FrmNovoCliente_Load(object sender, EventArgs e)
        {
           
            CarregaGridClientes();
        }


        //private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int linhaAtual = dgvClientes.CurrentRow.Index + 1;
        //    int idCliente = Convert.ToInt32(dgvClientes.Rows[linhaAtual].Cells[0].Value);
        //    var cliente = Cliente.ObterPorId(idCliente);
        //    txtClienteId.Text = cliente.Id.ToString();
        //    txtNome.Text = cliente.Nome;
        //    txtTelefone.Text = cliente.Telefone;
        //    DataNasc.Value = cliente.DataNasc;
        //    chkAtivo.Checked = cliente.Ativo;
        //    btnAtualizar.Enabled = true;
        //}
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
               txtNome.Text,
               txtCpf.Text,
               txtTelefone.Text,
               txtEmail.Text,
               DataNasc.Value,
               chkAtivo.Checked
               );

            cliente.Inserir();
            if (cliente.Id > 0)
            {
                //carrega grid
                txtClienteId.Text = cliente.Id.ToString();
                CarregaGridClientes();
                MessageBox.Show($"Cliente {cliente.Id} inserido com sucesso");
                btnInserir.Enabled = false;
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            txtClienteId.Text = cliente.Id.ToString();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.DataNasc = DataNasc.Value;
            if (cliente.Atualizar())
            {
                CarregaGridClientes();
                MessageBox.Show("Cliente atualizado com sucesso!");
            }
        }
        private void CarregaGridClientes()
        {
            dgvClientes.Rows.Clear();
            var listaDeClientes = Cliente.ObterLista();
            int linha = 0;
            foreach (var cliente in listaDeClientes)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[linha].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[linha].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[linha].Cells[2].Value = cliente.Cpf;
                dgvClientes.Rows[linha].Cells[4].Value = cliente.Telefone;
                dgvClientes.Rows[linha].Cells[3].Value = cliente.Email;
                dgvClientes.Rows[linha].Cells[5].Value = cliente.DataNasc;
                dgvClientes.Rows[linha].Cells[6].Value = cliente.Ativo;
                linha++;
            }
        }
        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            int linhaAtual = dgvClientes.CurrentRow.Index + 1;
            int idCliente = Convert.ToInt32(dgvClientes.Rows[linhaAtual].Cells[0].Value);
            var cliente = Cliente.ObterPorId(idCliente);
            txtClienteId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            DataNasc.Value = cliente.DataNasc;
            chkAtivo.Checked = cliente.Ativo;
            btnAtualizar.Enabled = true;
        }

        
    }
}
