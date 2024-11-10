namespace SysTINSApp
{
    partial class Frm
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
            btnAtualizar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtId = new Label();
            txtCodBar = new Label();
            txtDesc = new Label();
            txtVl_Unit = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            tex = new TextBox();
            textBox7 = new TextBox();
            btnCancelar = new Button();
            btnConsultar = new Button();
            label1 = new Label();
            txtClienteId = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox8 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(130, 231);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(245, 231);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(69, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(17, 15);
            txtId.TabIndex = 4;
            txtId.Text = "ld";
            // 
            // txtCodBar
            // 
            txtCodBar.AutoSize = true;
            txtCodBar.Location = new Point(245, 48);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(46, 15);
            txtCodBar.TabIndex = 5;
            txtCodBar.Text = "CodBar";
            // 
            // txtDesc
            // 
            txtDesc.AutoSize = true;
            txtDesc.Location = new Point(418, 48);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(58, 15);
            txtDesc.TabIndex = 6;
            txtDesc.Text = "Descrição";
            // 
            // txtVl_Unit
            // 
            txtVl_Unit.AutoSize = true;
            txtVl_Unit.Location = new Point(631, 48);
            txtVl_Unit.Name = "txtVl_Unit";
            txtVl_Unit.Size = new Size(78, 15);
            txtVl_Unit.TabIndex = 7;
            txtVl_Unit.Text = "Valor Unitário";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(419, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(205, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(140, 66);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(65, 23);
            textBox5.TabIndex = 10;
            // 
            // tex
            // 
            tex.Location = new Point(631, 66);
            tex.Name = "tex";
            tex.Size = new Size(100, 23);
            tex.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(86, 139);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(480, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(363, 231);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 14;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 121);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 16;
            // 
            // txtClienteId
            // 
            txtClienteId.AutoSize = true;
            txtClienteId.Location = new Point(140, 48);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(57, 15);
            txtClienteId.TabIndex = 17;
            txtClienteId.Text = "Cliente Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 121);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 18;
            label3.Text = "Unidade Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 119);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 19;
            label2.Text = "Estoque Minimo";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(338, 139);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 121);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 21;
            label4.Text = "Desconto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 121);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 22;
            label5.Text = "Data de Cadastro";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(480, 139);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 150);
            dataGridView1.TabIndex = 25;
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtClienteId);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(btnCancelar);
            Controls.Add(textBox7);
            Controls.Add(tex);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtVl_Unit);
            Controls.Add(txtDesc);
            Controls.Add(txtCodBar);
            Controls.Add(txtId);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Name = "Frm";
            Text = "Frm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnAtualizar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label txtId;
        private Label txtCodBar;
        private Label txtDesc;
        private Label txtVl_Unit;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox tex;
        private TextBox textBox7;
        private Button btnCancelar;
        private Button btnConsultar;
        private Label label1;
        private Label txtClienteId;
        private Label label3;
        private Label label2;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private TextBox textBox8;
        private DataGridView dataGridView1;
    }
}