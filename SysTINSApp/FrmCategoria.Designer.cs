namespace SysTINSApp
{
    partial class FrmCategoria
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
            comboBox1 = new ComboBox();
            btnInserir = new Button();
            btnConsultar = new Button();
            Id = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblNome = new Label();
            lblSigla = new Label();
            btnAlterar = new Button();
            btnListar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(513, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 23);
            comboBox1.TabIndex = 0;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(144, 183);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(245, 183);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(144, 88);
            Id.Name = "Id";
            Id.Size = new Size(18, 15);
            Id.TabIndex = 3;
            Id.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(80, 23);
            textBox2.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(263, 88);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblSigla
            // 
            lblSigla.AutoSize = true;
            lblSigla.Location = new Point(513, 88);
            lblSigla.Name = "lblSigla";
            lblSigla.Size = new Size(32, 15);
            lblSigla.TabIndex = 7;
            lblSigla.Text = "Sigla";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(342, 183);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(434, 183);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(527, 183);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeletar);
            Controls.Add(btnListar);
            Controls.Add(btnAlterar);
            Controls.Add(lblSigla);
            Controls.Add(lblNome);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Id);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Controls.Add(comboBox1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnInserir;
        private Button btnConsultar;
        private Label Id;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblNome;
        private Label lblSigla;
        private Button btnAlterar;
        private Button btnListar;
        private Button btnDeletar;
    }
}