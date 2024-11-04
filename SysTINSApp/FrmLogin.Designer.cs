namespace SysTINSApp
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            Login = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            btnEntrar = new Button();
            btnCancelar = new Button();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 12F);
            Login.ForeColor = SystemColors.ActiveCaptionText;
            Login.Location = new Point(155, 49);
            Login.Name = "Login";
            Login.Size = new Size(48, 21);
            Login.TabIndex = 1;
            Login.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(155, 139);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(272, 23);
            txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(155, 115);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(155, 218);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 36);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(300, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 12F);
            lblMensagem.ForeColor = Color.Crimson;
            lblMensagem.Location = new Point(157, 173);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 21);
            lblMensagem.TabIndex = 6;
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            CancelButton = btnCancelar;
            ClientSize = new Size(584, 294);
            ControlBox = false;
            Controls.Add(lblMensagem);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(Login);
            Controls.Add(txtEmail);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label Login;
        private TextBox txtSenha;
        private Label label2;
        private Button btnEntrar;
        private Button btnCancelar;
        private Label lblMensagem;
    }
}