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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new(); // cria uma instância (objeto) dos FrmUsuarios
            frmUsuarios.MdiParent = this; // asssocia esta instancia ao container (MDI) FrmPrincipal 
            frmUsuarios.Show(); // exibe o form Usuarios na janela do sistema
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLogin = new();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                tsslUsuario.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
                Show();
            }
            else
                Application.Exit();

        }



        private void novoInserirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoCliente frmNovoCliente = new();
            frmNovoCliente.MdiParent = this;
            frmNovoCliente.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidoNovo = new();
            frmPedidoNovo.MdiParent = this;
            frmPedidoNovo.Show();
        }

        private void endereçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnderecos frmEnderecos = new();
            frmEnderecos.txtCliente_Id.Text = "27";
            frmEnderecos.Show();
        }


        //frmEnderecos.Show();

        //// Passa o valor diretamente para o TextBox de frmEnderecos
        //if (frmEnderecos != null)
        //{
        //    frmEnderecos.Cliente_id.Text = txtClienteId.Text;
        ////}
    }
}




        //FrmEnderecos frmEnderecos = new();
        //frmEnderecos.Cliente_id.text = "";
        //frmEnderecos.Show();
// showdialog - obrigatoriamente retrona valor
//Hide();
//FrmLogin frmLogin = new();
//var retorno = frmLogin.ShowDialog();
//if (retorno == DialogResult.OK)
//    Show();
//else
//    Application.Exit();
