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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtCPF.Text,
                txtTelefone.Text,
                txtEmail.Text,
                txtDataNasc.Value,
                chkAtivo.Checked
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                // carrega grid
                // carregando o datagrid de usuários
                CarregaGridClientes();
                MessageBox.Show($"{cliente.Nome} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.DataNasc = txtDataNasc.Value;
            if (cliente.Atualizar())
            {
                CarregaGridClientes();
                MessageBox.Show("Usuário atualizado com sucesso!");
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
                dgvClientes.Rows[linha].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[linha].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[linha].Cells[5].Value = cliente.DataNasc;
                dgvClientes.Rows[linha].Cells[6].Value = cliente.Ativo;
                linha++;
            }
        }
    }
}
