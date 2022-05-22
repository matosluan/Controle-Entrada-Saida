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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProduto p = new FrmProduto();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmUsuario f = new FrmUsuario();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEntrada f = new FrmEntrada();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSaida f = new FrmSaida();
            f.Show();
        }
    }
}
