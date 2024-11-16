namespace SysTINSApp
{
    partial class FrmEnderecos
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
            btnInserir = new Button();
            btnConsultar = new Button();
            btnCancelar = new Button();
            dgvEnderecos = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnTpEndereco = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblCep = new Label();
            lblComplemento = new Label();
            lblNumero = new Label();
            txtCep = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            lblUf = new Label();
            lblCidade = new Label();
            lblTpEndereco = new Label();
            txtCidade = new TextBox();
            txtTpEndereco = new TextBox();
            cmbUf = new ComboBox();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(159, 225);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(280, 225);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(528, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnTpEndereco, clnUf });
            dgvEnderecos.Location = new Point(34, 276);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(774, 150);
            dgvEnderecos.TabIndex = 3;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "Cep";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            // 
            // clnLogradouro
            // 
            clnLogradouro.Frozen = true;
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            // 
            // clnNumero
            // 
            clnNumero.Frozen = true;
            clnNumero.HeaderText = "Numero";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.Frozen = true;
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.Frozen = true;
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            // 
            // clnTpEndereco
            // 
            clnTpEndereco.Frozen = true;
            clnTpEndereco.HeaderText = "Tp de Endereço";
            clnTpEndereco.Name = "clnTpEndereco";
            clnTpEndereco.ReadOnly = true;
            // 
            // clnUf
            // 
            clnUf.Frozen = true;
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(257, 56);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 4;
            lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(257, 74);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(188, 23);
            txtLogradouro.TabIndex = 5;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(92, 56);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 4;
            lblCep.Text = "Cep";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(563, 56);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 4;
            lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(469, 56);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Numero";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(92, 74);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(142, 23);
            txtCep.TabIndex = 5;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(563, 74);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(117, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(469, 74);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(65, 23);
            txtNumero.TabIndex = 5;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(105, 156);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(129, 23);
            txtBairro.TabIndex = 5;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(105, 138);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 4;
            lblBairro.Text = "Bairro";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(596, 138);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(19, 15);
            lblUf.TabIndex = 4;
            lblUf.Text = "Uf";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(268, 138);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 4;
            lblCidade.Text = "Cidade";
            // 
            // lblTpEndereco
            // 
            lblTpEndereco.AutoSize = true;
            lblTpEndereco.Location = new Point(436, 138);
            lblTpEndereco.Name = "lblTpEndereco";
            lblTpEndereco.Size = new Size(98, 15);
            lblTpEndereco.TabIndex = 4;
            lblTpEndereco.Text = "Tipo de Endereço";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(268, 156);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(142, 23);
            txtCidade.TabIndex = 5;
            // 
            // txtTpEndereco
            // 
            txtTpEndereco.Location = new Point(436, 156);
            txtTpEndereco.Name = "txtTpEndereco";
            txtTpEndereco.Size = new Size(132, 23);
            txtTpEndereco.TabIndex = 5;
            // 
            // cmbUf
            // 
            cmbUf.FormattingEnabled = true;
            cmbUf.Location = new Point(596, 156);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(56, 23);
            cmbUf.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(406, 225);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmEnderecos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 450);
            Controls.Add(cmbUf);
            Controls.Add(txtCep);
            Controls.Add(txtTpEndereco);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblCep);
            Controls.Add(lblCidade);
            Controls.Add(lblTpEndereco);
            Controls.Add(lblUf);
            Controls.Add(lblBairro);
            Controls.Add(lblComplemento);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(dgvEnderecos);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Name = "FrmEnderecos";
            Text = "FrmEnderecos";
            Load += FrmEnderecos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnConsultar;
        private Button btnCancelar;
        private DataGridView dgvEnderecos;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblCep;
        private Label lblComplemento;
        private Label lblNumero;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private Label lblBairro;
        private Label lblUf;
        private Label lblCidade;
        private Label lblTpEndereco;
        private TextBox txtCidade;
        private TextBox txtTpEndereco;
        private ComboBox cmbUf;
        private Button btnAtualizar;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnTpEndereco;
        private DataGridViewTextBoxColumn clnUf;
    }
}