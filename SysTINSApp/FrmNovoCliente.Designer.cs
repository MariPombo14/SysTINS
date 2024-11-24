
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
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtClienteId = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            chkAtivo = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblID = new Label();
            btnAtualizar = new Button();
            btnInserir = new Button();
            txtCpf = new TextBox();
            label8 = new Label();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            DataNasc = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(248, 118);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(346, 23);
            txtNome.TabIndex = 40;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(342, 167);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(163, 23);
            txtTelefone.TabIndex = 39;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(150, 118);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.ReadOnly = true;
            txtClienteId.Size = new Size(57, 23);
            txtClienteId.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(89, 23);
            txtEmail.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 205);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 35;
            label7.Text = "Data Nasc";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Enabled = false;
            chkAtivo.Location = new Point(426, 223);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 34;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 205);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 33;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 56);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 149);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 30;
            label4.Text = "Cpf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 149);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 29;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 28;
            label2.Text = "Nome";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(150, 100);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 27;
            lblID.Text = "ID";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(376, 289);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 25;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(201, 289);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 23;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(150, 167);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(163, 23);
            txtCpf.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(227, 24);
            label8.Name = "label8";
            label8.Size = new Size(278, 32);
            label8.TabIndex = 41;
            label8.Text = "Cadastro Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnAtivo });
            dgvClientes.Location = new Point(50, 361);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(629, 150);
            dgvClientes.TabIndex = 42;
            dgvClientes.CellClick += dgvClientes_CellClick_1;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 160;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "Cpf";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 90;
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
            clnEmail.Width = 130;
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
            clnAtivo.Width = 50;
            // 
            // DataNasc
            // 
            DataNasc.Format = DateTimePickerFormat.Short;
            DataNasc.Location = new Point(276, 223);
            DataNasc.Name = "DataNasc";
            DataNasc.Size = new Size(103, 23);
            DataNasc.TabIndex = 43;
            DataNasc.Value = new DateTime(2024, 11, 13, 17, 5, 53, 0);
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 523);
            Controls.Add(DataNasc);
            Controls.Add(dgvClientes);
            Controls.Add(label8);
            Controls.Add(txtNome);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(txtClienteId);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(chkAtivo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Name = "FrmNovoCliente";
            Text = "FrmNovoCliente";
            Load += FrmNovoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtClienteId;
        private TextBox txtEmail;
        private Label label7;
        private CheckBox chkAtivo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblID;
        private Button btnAtualizar;
        private Button btnInserir;
        private TextBox txtCpf;
        private Label label8;
        private DataGridView dgvClientes;
        private DateTimePicker DataNasc;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}
