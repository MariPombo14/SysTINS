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