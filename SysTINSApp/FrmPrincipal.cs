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
    }
}
// showdialog - obrigatoriamente retrona valor
//Hide();
//FrmLogin frmLogin = new();
//var retorno = frmLogin.ShowDialog();
//if (retorno == DialogResult.OK)
//    Show();
//else
//    Application.Exit();
