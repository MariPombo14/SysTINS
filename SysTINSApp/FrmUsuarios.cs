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
using static System.Windows.Forms.LinkLabel;

namespace SysTINSApp
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // carregando o combobox de níveis
            cmbNivel.DataSource = Nivel.ObterLista(); // Objeto do tipo ObterLista retorna uma coleção de objetos do tipo niveis
            cmbNivel.DisplayMember = "Nome"; // nome que desejo que apareça na tela 
            cmbNivel.ValueMember = "Id";// Isso é a forma que irá ser repassado(no caso o Id)

            // carrega grid
            CarregaGridUsuarios();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                // carrega grid
                // carregando o datagrid de usuários
                CarregaGridUsuarios();
                MessageBox.Show($"Usuario {usuario.Nome} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
        private void CarregaGridUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            var listaDeUsuarios = Usuario.ObterLista(); // metodo static da classe  //metodo nao statico é do objeto ou instancia
            int linha = 0;
            foreach (var usuario in listaDeUsuarios)       // foreach (Para cada usuario dentro da lista de Usuarios faça)  
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[linha].Cells[4].Value = usuario.Ativo;
                linha++;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvUsuarios.CurrentRow.Index + 1;
            int idUser = Convert.ToInt32(dgvUsuarios.Rows[linhaAtual].Cells[0].Value);
            var usuario = Usuario.ObterporId(idUser);
            txtid.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            chkAtivo.Checked = usuario.Ativo;
            cmbNivel.SelectedValue = usuario.Nivel.Id;
            btnAtualizar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();
            usuario.Id = int.Parse(txtid.Text);
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue));
            if (usuario.Atualizar())
            {
                CarregaGridUsuarios();
                MessageBox.Show("Usuário atualizado com sucesso!");
            }
        }
    }
}
