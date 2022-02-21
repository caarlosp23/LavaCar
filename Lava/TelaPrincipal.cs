using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lava
{
    public partial class TelaPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioCliente x = new FormRelatorioCliente();
            x.Show();
            
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadCliente x = new FormCadCliente();
            x.Show();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadVeiculo x = new FormCadVeiculo();
            x.Show();
        }

        private void veiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioVeiculo x = new FormRelatorioVeiculo();
            x.Show();

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadServico x = new FormCadServico();
            x.Show();
        }

        private void emissãoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocVenda x = new FormDocVenda();
            x.Show();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioVenda x = new FormRelatorioVenda();
            x.Show();
        }

        private void lucroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioLucro x = new FormRelatorioLucro();
            x.Show();
        }
    }
}