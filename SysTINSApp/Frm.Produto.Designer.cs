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
            txtId = new TextBox();
            txtCodBar = new TextBox();
            lblID = new Label();
            lblCodBar = new Label();
            lblDesc = new Label();
            lblVl_Unit = new Label();
            txtDesc = new TextBox();
            txtEstoqueMinimo = new TextBox();
            txtVlUnit = new TextBox();
            txtUnidadeVenda = new TextBox();
            btnCancelar = new Button();
            btnConsultar = new Button();
            label1 = new Label();
            lblUnidadeVenda = new Label();
            lblEstoqueMinimo = new Label();
            txtDesconto = new TextBox();
            lblDesconto = new Label();
            lblData_Cadastro = new Label();
            txtData_Cadastro = new TextBox();
            dgvProduto = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            ClnCodBar = new DataGridViewTextBoxColumn();
            clnDescrição = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(184, 232);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(300, 232);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(111, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(184, 66);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(137, 23);
            txtCodBar.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(111, 48);
            lblID.Name = "lblID";
            lblID.Size = new Size(17, 15);
            lblID.TabIndex = 4;
            lblID.Text = "ld";
            // 
            // lblCodBar
            // 
            lblCodBar.AutoSize = true;
            lblCodBar.Location = new Point(184, 48);
            lblCodBar.Name = "lblCodBar";
            lblCodBar.Size = new Size(46, 15);
            lblCodBar.TabIndex = 5;
            lblCodBar.Text = "CodBar";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(349, 48);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 6;
            lblDesc.Text = "Descrição";
            // 
            // lblVl_Unit
            // 
            lblVl_Unit.AutoSize = true;
            lblVl_Unit.Location = new Point(531, 48);
            lblVl_Unit.Name = "lblVl_Unit";
            lblVl_Unit.Size = new Size(78, 15);
            lblVl_Unit.TabIndex = 7;
            lblVl_Unit.Text = "Valor Unitário";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(349, 66);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(173, 23);
            txtDesc.TabIndex = 8;
            txtDesc.TextChanged += textBox3_TextChanged;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(207, 154);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(100, 23);
            txtEstoqueMinimo.TabIndex = 9;
            // 
            // txtVlUnit
            // 
            txtVlUnit.Location = new Point(531, 66);
            txtVlUnit.Name = "txtVlUnit";
            txtVlUnit.Size = new Size(100, 23);
            txtVlUnit.TabIndex = 11;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(86, 154);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(100, 23);
            txtUnidadeVenda.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(534, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(414, 232);
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
            // lblUnidadeVenda
            // 
            lblUnidadeVenda.AutoSize = true;
            lblUnidadeVenda.Location = new Point(86, 136);
            lblUnidadeVenda.Name = "lblUnidadeVenda";
            lblUnidadeVenda.Size = new Size(86, 15);
            lblUnidadeVenda.TabIndex = 18;
            lblUnidadeVenda.Text = "Unidade Venda";
            // 
            // lblEstoqueMinimo
            // 
            lblEstoqueMinimo.AutoSize = true;
            lblEstoqueMinimo.Location = new Point(207, 136);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(94, 15);
            lblEstoqueMinimo.TabIndex = 19;
            lblEstoqueMinimo.Text = "Estoque Minimo";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(339, 154);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 20;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(339, 141);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 21;
            lblDesconto.Text = "Desconto";
            // 
            // lblData_Cadastro
            // 
            lblData_Cadastro.AutoSize = true;
            lblData_Cadastro.Location = new Point(458, 141);
            lblData_Cadastro.Name = "lblData_Cadastro";
            lblData_Cadastro.Size = new Size(97, 15);
            lblData_Cadastro.TabIndex = 22;
            lblData_Cadastro.Text = "Data de Cadastro";
            // 
            // txtData_Cadastro
            // 
            txtData_Cadastro.Location = new Point(458, 159);
            txtData_Cadastro.Name = "txtData_Cadastro";
            txtData_Cadastro.Size = new Size(100, 23);
            txtData_Cadastro.TabIndex = 23;
            // 
            // dgvProduto
            // 
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.AllowUserToDeleteRows = false;
            dgvProduto.AllowUserToResizeColumns = false;
            dgvProduto.AllowUserToResizeRows = false;
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Columns.AddRange(new DataGridViewColumn[] { clnId, ClnCodBar, clnDescrição, clnValorUnit, clnEstoqueMinimo, clnDesconto, clnCategoria, clnDataCad });
            dgvProduto.Location = new Point(50, 293);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.RowHeadersVisible = false;
            dgvProduto.Size = new Size(697, 128);
            dgvProduto.TabIndex = 25;
            dgvProduto.CellClick += dgvProduto_CellClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // ClnCodBar
            // 
            ClnCodBar.Frozen = true;
            ClnCodBar.HeaderText = "CodBar";
            ClnCodBar.Name = "ClnCodBar";
            ClnCodBar.ReadOnly = true;
            // 
            // clnDescrição
            // 
            clnDescrição.Frozen = true;
            clnDescrição.HeaderText = "Descrição";
            clnDescrição.Name = "clnDescrição";
            clnDescrição.ReadOnly = true;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "ValorUnit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 80;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.Frozen = true;
            clnEstoqueMinimo.HeaderText = "EstoqueMinimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "DataCad";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(588, 159);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 26;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(588, 141);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 27;
            lblCategoria.Text = "Categoria";
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(dgvProduto);
            Controls.Add(txtData_Cadastro);
            Controls.Add(lblData_Cadastro);
            Controls.Add(lblDesconto);
            Controls.Add(txtDesconto);
            Controls.Add(lblEstoqueMinimo);
            Controls.Add(lblUnidadeVenda);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(btnCancelar);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(txtVlUnit);
            Controls.Add(txtEstoqueMinimo);
            Controls.Add(txtDesc);
            Controls.Add(lblVl_Unit);
            Controls.Add(lblDesc);
            Controls.Add(lblCodBar);
            Controls.Add(lblID);
            Controls.Add(txtCodBar);
            Controls.Add(txtId);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Name = "Frm";
            Text = "Frm";
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnAtualizar;
        private TextBox txtId;
        private TextBox txtCodBar;
        private Label lblID;
        private Label lblCodBar;
        private Label lblDesc;
        private Label lblVl_Unit;
        private TextBox txtDesc;
        private TextBox txtEstoqueMinimo;
        private TextBox txtVlUnit;
        private TextBox txtUnidadeVenda;
        private Button btnCancelar;
        private Button btnConsultar;
        private Label label1;
        private Label lblUnidadeVenda;
        private Label lblEstoqueMinimo;
        private TextBox txtDesconto;
        private Label lblDesconto;
        private Label lblData_Cadastro;
        private TextBox txtData_Cadastro;
        private DataGridView dgvProduto;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn ClnCodBar;
        private DataGridViewTextBoxColumn clnDescrição;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnDataCad;
    }
}