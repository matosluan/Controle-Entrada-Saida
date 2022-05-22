using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmSaida : ControleEstoque1.FrmBase
    {
        public FrmSaida()
        {
            InitializeComponent();
            BloqueiaCampo();
        }

        private void BloqueiaCampo()
        {
            idProduto.Enabled = false;
            txtIdSaida.Enabled = false;
        }
        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoSaida2> lista = get.ListSaidas();
            this.GridViewSaida.DataSource = lista;
            this.GridViewSaida.Refresh();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model set = new Model();
            DtoSaida u = new DtoSaida();

            u.id = int.Parse(txtIdProduto.Text);
            set.SetSaida(u);
        }

        private void PesquisaSaida_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto != 0)
            {
                txtIdProduto.Text = c.idProduto.ToString();
                txtIdProduto.Focus();
                qntVendida.Focus();
                vlrVenda.Focus();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Model set = new Model();
            DtoSaida p = new DtoSaida();
            p.qntpedido = decimal.Parse(qntVendida.Text);
            p.vlrpedido = decimal.Parse(vlrVenda.Text);
            p.idproduro = int.Parse(idProduto.Text);
            p.dtpedido = DateTime.Now;
            set.SetSaida(p);

            CarregarGrid();
            Model set1 = new Model();
            DtoProduto pr = new DtoProduto();

            pr.quantidade = decimal.Parse(qntAtualizada.Text);
            pr.idproduto = p.idproduro;


            set1.AlteraProduto2(pr);
        }

        private void GridViewSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (Int32)GridViewSaida.CurrentRow.Cells[0].Value;
            Model get = new Model();
            DtoSaida2 p = get.GetSaidaId(id);
            txtIdSaida.Text = p.id.ToString();
            qntVendida.Text = p.qntpedido.ToString();
            vlrVenda.Text = p.vlrpedido.ToString();
            p.dtpedido = DateTime.Now;

            vlrVenda.Focus();
            qntVendida.Focus();
        }

        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetIdProduto(int.Parse(txtIdProduto.Text));
            idProduto.Text = produto.idproduto.ToString();
            txtNomeProduto.Text = produto.nomeproduto;
            vlrproduto.Text = produto.valorvenda.ToString();
        }

        private void qntVendida_Leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetIdProduto(int.Parse(txtIdProduto.Text));

            decimal total = decimal.Parse(qntVendida.Text) * decimal.Parse(vlrproduto.Text);
            vlrVenda.Text = total.ToString();
            decimal qtdeatu = (decimal)produto.quantidade - decimal.Parse(qntVendida.Text);
            qntAtualizada.Text = qtdeatu.ToString();
        }
    }
}
