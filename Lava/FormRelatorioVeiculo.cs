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
    public partial class FormRelatorioVeiculo : Form
    {
        public FormRelatorioVeiculo()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            RelVeiculo x = new RelVeiculo();
            x.CreateDocument();
            documentViewer1.DocumentSource = x;
            documentViewer1.CreateControl();
        }
    }
}
