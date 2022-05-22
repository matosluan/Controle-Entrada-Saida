using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmEntrada : ControleEstoque1.FrmBase
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }

        private void LiberaText()
        {
            txtIdEntrada.Enabled = true;
            txtNomeProdutoEntrada.Enabled = true;
            txtProdutoEntrada.Enabled = true;
            txtQuantidadeEntrada.Enabled = true;
            txtValorTotalEntrada.Enabled = true;
            txtValorUnitario.Enabled = true;
        }

        private void DesabilitaText()
        {
            txtIdEntrada.Enabled = false;
            txtNomeProdutoEntrada.Enabled = false;
            txtProdutoEntrada.Enabled = false;
            txtQuantidadeEntrada.Enabled = false;
            txtValorTotalEntrada.Enabled = false;
            txtValorUnitario.Enabled = false;
           
        }

       
        private void PesquisaEntrada_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto!=0)
            {
               txtProdutoEntrada.Text = c.idProduto.ToString();
               txtProdutoEntrada.Focus();
            }

        }

        private void txtProdutoEntrada_Leave_1(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetIdProduto(int.Parse(txtProdutoEntrada.Text));
            txtNomeProdutoEntrada.Text = produto.nomeproduto;
        }

        private void txtValorUnitario_Leave_1(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(txtQuantidadeEntrada.Text) * decimal.Parse(txtValorUnitario.Text);
            txtValorTotalEntrada.Text = total.ToString();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            txtIdEntrada.Text = string.Empty;
            txtNomeProdutoEntrada.Text = string.Empty;
            txtProdutoEntrada.Text = string.Empty;
            txtQuantidadeEntrada.Text = string.Empty;
            txtValorTotalEntrada.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
            LiberaText();
            txtProdutoEntrada.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                Model set = new Model();
                DtoEntrada u = new DtoEntrada();
               
                u.idproduto = int.Parse(txtProdutoEntrada.Text);
                u.nomeproduto = txtNomeProdutoEntrada.Text;
                u.qteproduto = decimal.Parse(txtQuantidadeEntrada.Text);
                u.vlrcustoproduto = decimal.Parse(txtValorUnitario.Text);
                u.vlrtotalproduto = decimal.Parse(txtValorTotalEntrada.Text);
                u.dtcompra = DateTime.Now;

                set.SetEntrada(u);
                
                DesabilitaText();
        }
    }
}

