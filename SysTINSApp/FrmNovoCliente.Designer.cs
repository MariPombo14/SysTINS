namespace SysTINSApp
{
    partial class FrmNovoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblID = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblDataNasc = new Label();
            txtID = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtDataNasc = new DateTimePicker();
            lblCadastro_Cliente = new Label();
            btnInserir = new Button();
            btnAtualizar = new Button();
            chkAtivo = new CheckBox();
            dgvClientes = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCPF = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(170, 83);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(269, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(515, 83);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(220, 146);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(436, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(199, 206);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 5;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(170, 101);
            txtID.Name = "txtID";
            txtID.Size = new Size(63, 23);
            txtID.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(220, 164);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(143, 23);
            txtTelefone.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(264, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(208, 23);
            txtNome.TabIndex = 7;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(515, 101);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(145, 23);
            txtCPF.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(436, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(156, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtDataNasc
            // 
            txtDataNasc.Format = DateTimePickerFormat.Short;
            txtDataNasc.Location = new Point(199, 224);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(123, 23);
            txtDataNasc.TabIndex = 11;
            // 
            // lblCadastro_Cliente
            // 
            lblCadastro_Cliente.AutoSize = true;
            lblCadastro_Cliente.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastro_Cliente.Location = new Point(233, 26);
            lblCadastro_Cliente.Name = "lblCadastro_Cliente";
            lblCadastro_Cliente.Size = new Size(359, 38);
            lblCadastro_Cliente.TabIndex = 13;
            lblCadastro_Cliente.Text = "Cadastro de Cliente";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(247, 274);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 14;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(397, 274);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Enabled = false;
            chkAtivo.Location = new Point(418, 224);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 15;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnCPF, clnTelefone, clnEmail, clnDataNasc, clnAtivo });
            dgvClientes.Location = new Point(38, 324);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(716, 133);
            dgvClientes.TabIndex = 16;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnCPF
            // 
            clnCPF.Frozen = true;
            clnCPF.HeaderText = "CPF";
            clnCPF.Name = "clnCPF";
            clnCPF.ReadOnly = true;
            clnCPF.Width = 111;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnDataNasc
            // 
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data Nasc";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 478);
            Controls.Add(dgvClientes);
            Controls.Add(chkAtivo);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(lblCadastro_Cliente);
            Controls.Add(txtDataNasc);
            Controls.Add(txtEmail);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtID);
            Controls.Add(lblDataNasc);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(lblID);
            Name = "FrmNovoCliente";
            Text = "FrmNovoCliente";
            Load += FrmNovoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNome;
        private Label lblCpf;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblDataNasc;
        private TextBox txtID;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEmail;
        private DateTimePicker txtDataNasc;
        private Label lblCadastro_Cliente;
        private Button btnInserir;
        private Button btnAtualizar;
        private CheckBox chkAtivo;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCPF;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnAtivo;
    }
}