namespace ControleEstoque1
{
    partial class FrmEntrada
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEntrada = new System.Windows.Forms.TextBox();
            this.GridViewEntrada = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
            this.txtProdutoEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PesquisaEntrada = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtValorTotalEntrada = new System.Windows.Forms.TextBox();
            this.txtNomeProdutoEntrada = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtIdEntrada
            // 
            this.txtIdEntrada.Location = new System.Drawing.Point(86, 130);
            this.txtIdEntrada.Name = "txtIdEntrada";
            this.txtIdEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtIdEntrada.TabIndex = 3;
            // 
            // GridViewEntrada
            // 
            this.GridViewEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewEntrada.Location = new System.Drawing.Point(15, 288);
            this.GridViewEntrada.Name = "GridViewEntrada";
            this.GridViewEntrada.Size = new System.Drawing.Size(773, 150);
            this.GridViewEntrada.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // txtQuantidadeEntrada
            // 
            this.txtQuantidadeEntrada.Location = new System.Drawing.Point(86, 195);
            this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
            this.txtQuantidadeEntrada.Size = new System.Drawing.Size(155, 20);
            this.txtQuantidadeEntrada.TabIndex = 7;
            // 
            // txtProdutoEntrada
            // 
            this.txtProdutoEntrada.Location = new System.Drawing.Point(86, 159);
            this.txtProdutoEntrada.Name = "txtProdutoEntrada";
            this.txtProdutoEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtProdutoEntrada.TabIndex = 8;
            this.txtProdutoEntrada.Leave += new System.EventHandler(this.txtProdutoEntrada_Leave_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 191);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Total";
            // 
            // PesquisaEntrada
            // 
            this.PesquisaEntrada.Location = new System.Drawing.Point(214, 161);
            this.PesquisaEntrada.Name = "PesquisaEntrada";
            this.PesquisaEntrada.Size = new System.Drawing.Size(75, 23);
            this.PesquisaEntrada.TabIndex = 11;
            this.PesquisaEntrada.Text = "...";
            this.PesquisaEntrada.UseVisualStyleBackColor = true;
            this.PesquisaEntrada.Click += new System.EventHandler(this.PesquisaEntrada_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(539, 188);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(155, 20);
            this.txtValorUnitario.TabIndex = 12;
            this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave_1);
            // 
            // txtValorTotalEntrada
            // 
            this.txtValorTotalEntrada.Location = new System.Drawing.Point(539, 141);
            this.txtValorTotalEntrada.Name = "txtValorTotalEntrada";
            this.txtValorTotalEntrada.Size = new System.Drawing.Size(155, 20);
            this.txtValorTotalEntrada.TabIndex = 13;
            // 
            // txtNomeProdutoEntrada
            // 
            this.txtNomeProdutoEntrada.Location = new System.Drawing.Point(295, 164);
            this.txtNomeProdutoEntrada.Name = "txtNomeProdutoEntrada";
            this.txtNomeProdutoEntrada.Size = new System.Drawing.Size(155, 20);
            this.txtNomeProdutoEntrada.TabIndex = 14;
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeProdutoEntrada);
            this.Controls.Add(this.txtValorTotalEntrada);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.PesquisaEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProdutoEntrada);
            this.Controls.Add(this.txtQuantidadeEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridViewEntrada);
            this.Controls.Add(this.txtIdEntrada);
            this.Controls.Add(this.label1);
            this.Name = "FrmEntrada";
            this.Text = "Entrada";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtIdEntrada, 0);
            this.Controls.SetChildIndex(this.GridViewEntrada, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtQuantidadeEntrada, 0);
            this.Controls.SetChildIndex(this.txtProdutoEntrada, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.PesquisaEntrada, 0);
            this.Controls.SetChildIndex(this.txtValorUnitario, 0);
            this.Controls.SetChildIndex(this.txtValorTotalEntrada, 0);
            this.Controls.SetChildIndex(this.txtNomeProdutoEntrada, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEntrada;
        private System.Windows.Forms.DataGridView GridViewEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidadeEntrada;
        private System.Windows.Forms.TextBox txtProdutoEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PesquisaEntrada;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtValorTotalEntrada;
        private System.Windows.Forms.TextBox txtNomeProdutoEntrada;
    }
}
