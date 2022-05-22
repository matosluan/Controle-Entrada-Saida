namespace ControleEstoque1
{
    partial class FrmSaida
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
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PesquisaSaida = new System.Windows.Forms.Button();
            this.txtIdSaida = new System.Windows.Forms.TextBox();
            this.idProduto = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.qntVendida = new System.Windows.Forms.TextBox();
            this.vlrproduto = new System.Windows.Forms.TextBox();
            this.vlrVenda = new System.Windows.Forms.TextBox();
            this.qntAtualizada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GridViewSaida = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
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
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(86, 139);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProduto.TabIndex = 2;
            this.txtIdProduto.Leave += new System.EventHandler(this.txtIdProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(338, 139);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(193, 20);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            // 
            // PesquisaSaida
            // 
            this.PesquisaSaida.Location = new System.Drawing.Point(227, 137);
            this.PesquisaSaida.Name = "PesquisaSaida";
            this.PesquisaSaida.Size = new System.Drawing.Size(75, 23);
            this.PesquisaSaida.TabIndex = 5;
            this.PesquisaSaida.Text = "...";
            this.PesquisaSaida.UseVisualStyleBackColor = true;
            this.PesquisaSaida.Click += new System.EventHandler(this.PesquisaSaida_Click);
            // 
            // txtIdSaida
            // 
            this.txtIdSaida.Location = new System.Drawing.Point(60, 194);
            this.txtIdSaida.Name = "txtIdSaida";
            this.txtIdSaida.Size = new System.Drawing.Size(100, 20);
            this.txtIdSaida.TabIndex = 6;
            // 
            // idProduto
            // 
            this.idProduto.Location = new System.Drawing.Point(241, 194);
            this.idProduto.Name = "idProduto";
            this.idProduto.Size = new System.Drawing.Size(121, 20);
            this.idProduto.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(431, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // qntVendida
            // 
            this.qntVendida.Location = new System.Drawing.Point(128, 247);
            this.qntVendida.Name = "qntVendida";
            this.qntVendida.Size = new System.Drawing.Size(100, 20);
            this.qntVendida.TabIndex = 9;
            this.qntVendida.Leave += new System.EventHandler(this.qntVendida_Leave);
            // 
            // vlrproduto
            // 
            this.vlrproduto.Location = new System.Drawing.Point(351, 247);
            this.vlrproduto.Name = "vlrproduto";
            this.vlrproduto.Size = new System.Drawing.Size(100, 20);
            this.vlrproduto.TabIndex = 10;
            // 
            // vlrVenda
            // 
            this.vlrVenda.Location = new System.Drawing.Point(351, 295);
            this.vlrVenda.Name = "vlrVenda";
            this.vlrVenda.Size = new System.Drawing.Size(100, 20);
            this.vlrVenda.TabIndex = 11;
            // 
            // qntAtualizada
            // 
            this.qntAtualizada.Location = new System.Drawing.Point(131, 295);
            this.qntAtualizada.Name = "qntAtualizada";
            this.qntAtualizada.Size = new System.Drawing.Size(100, 20);
            this.qntAtualizada.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Valor Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quantidade atualizada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Qunatidade vendida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID";
            // 
            // GridViewSaida
            // 
            this.GridViewSaida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSaida.Location = new System.Drawing.Point(548, 117);
            this.GridViewSaida.Name = "GridViewSaida";
            this.GridViewSaida.Size = new System.Drawing.Size(240, 198);
            this.GridViewSaida.TabIndex = 20;
            this.GridViewSaida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSaida_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(467, 321);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 21;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FrmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.GridViewSaida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qntAtualizada);
            this.Controls.Add(this.vlrVenda);
            this.Controls.Add(this.vlrproduto);
            this.Controls.Add(this.qntVendida);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.idProduto);
            this.Controls.Add(this.txtIdSaida);
            this.Controls.Add(this.PesquisaSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Name = "FrmSaida";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtIdProduto, 0);
            this.Controls.SetChildIndex(this.txtNomeProduto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.PesquisaSaida, 0);
            this.Controls.SetChildIndex(this.txtIdSaida, 0);
            this.Controls.SetChildIndex(this.idProduto, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.qntVendida, 0);
            this.Controls.SetChildIndex(this.vlrproduto, 0);
            this.Controls.SetChildIndex(this.vlrVenda, 0);
            this.Controls.SetChildIndex(this.qntAtualizada, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.GridViewSaida, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PesquisaSaida;
        private System.Windows.Forms.TextBox txtIdSaida;
        private System.Windows.Forms.TextBox idProduto;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox qntVendida;
        private System.Windows.Forms.TextBox vlrproduto;
        private System.Windows.Forms.TextBox vlrVenda;
        private System.Windows.Forms.TextBox qntAtualizada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridViewSaida;
        private System.Windows.Forms.Button btnAdicionar;
    }
}
