namespace SysTINSApp
{
    partial class FrmUsuarios
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
            btnAtualizar = new Button();
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSenha = new Label();
            cmbNivel = new ComboBox();
            label5 = new Label();
            chkAtivo = new CheckBox();
            txtid = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            textBox4 = new TextBox();
            txtConfSenha = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(125, 232);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(220, 232);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(319, 232);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(150, 289);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 3;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 60;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 50);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 50);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 104);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Location = new Point(137, 164);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(39, 15);
            txtSenha.TabIndex = 7;
            txtSenha.Text = "Senha";
            // 
            // cmbNivel
            // 
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(399, 122);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 104);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Nível";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Enabled = false;
            chkAtivo.Location = new Point(466, 160);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            txtid.Location = new Point(137, 68);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(51, 23);
            txtid.TabIndex = 11;
            txtid.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(220, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 23);
            txtNome.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 23);
            txtEmail.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            textBox4.UseSystemPasswordChar = true;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // txtConfSenha
            // 
            txtConfSenha.AutoSize = true;
            txtConfSenha.Location = new Point(261, 164);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(96, 15);
            txtConfSenha.TabIndex = 15;
            txtConfSenha.Text = "Confirmar Senha";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(261, 182);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 16;
            textBox5.UseSystemPasswordChar = true;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(txtConfSenha);
            Controls.Add(textBox4);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtid);
            Controls.Add(chkAtivo);
            Controls.Add(label5);
            Controls.Add(cmbNivel);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnConsultar;
        private Button btnAtualizar;
        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtSenha;
        private ComboBox cmbNivel;
        private Label label5;
        private CheckBox chkAtivo;
        private TextBox txtid;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox textBox4;
        private Label txtConfSenha;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}