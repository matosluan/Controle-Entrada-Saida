using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmConsulta : Form
    {
        public int idProduto = 0;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void dataGridViewConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex > 0)
            {
                idProduto = (Int32)dataGridViewConsulta.CurrentRow.Cells[0].Value;
                Close();
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            Model m = new Model();
            List<DtoProduto2> list = m.ListProdutosNome(txtConsulta.Text);
            dataGridViewConsulta.DataSource = list;
        }
    }
}
