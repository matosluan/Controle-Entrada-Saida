using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmProduto : ControleEstoque1.FrmBase
    {
        public FrmProduto()
        {
            InitializeComponent();
            CarregarGridproduto();
            DesabilitaText();
        }

        private void LiberaText()
        {
            txtUnidade.Enabled = true;
            txtNomeProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValordaVenda.Enabled = true;
            txtValordoCusto.Enabled = true;
        }

        private void DesabilitaText()
        {
            txtId.Enabled = false;
            txtUnidade.Enabled = false;
            txtNomeProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValordaVenda.Enabled = false;
            txtValordoCusto.Enabled = false;
        }

        private void CarregarGridproduto()
        {
            Model get = new Model();
            List<DtoProduto2> lista = get.ListProdutos();
            this.ViewProduto.DataSource = lista;
            this.ViewProduto.Refresh();
        }

        private void ViewProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (int)ViewProduto.CurrentRow.Cells[0].Value;

            Model get = new Model();
            DtoProduto2 pr = get.GetProdutoId(ID);
            txtId.Text = pr.idproduto.ToString();
            txtNomeProduto.Text = pr.nomeproduto;
            LiberaText();
            txtNomeProduto.Focus();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            txtUnidade.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtValordaVenda.Text = string.Empty;
            txtValordoCusto.Text = string.Empty;
            LiberaText();
            txtNomeProduto.Focus();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model set = new Model();
                DtoProduto u = new DtoProduto();
                u.unidade = txtUnidade.Text;
                u.nomeproduto = txtNomeProduto.Text;
                u.valorvenda = decimal.Parse(txtValordaVenda.Text);
                u.valorcusto = decimal.Parse(txtValordoCusto.Text);
                u.quantidade = decimal.Parse(txtQuantidade.Text);

                if (txtId.Text != string.Empty)
                {
                    u.idproduto = int.Parse(txtId.Text);
                    set.AlteraProduto(u);
                }
                else
                {
                    set.SetProduto(u);
                }

                DesabilitaText();
                CarregarGridproduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiberaText();
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtId.Text != String.Empty)
            {
                Model del = new Model();
                del.DeletarProduto(int.Parse(txtId.Text));
                DesabilitaText();
                CarregarGridproduto();
            }
        }
    }
}
