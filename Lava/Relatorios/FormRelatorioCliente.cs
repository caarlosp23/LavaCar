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
    public partial class FormRelatorioCliente : Form
    {
        public FormRelatorioCliente()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            RelCliente y = new RelCliente();
            y.CreateDocument();
            documentViewer1.DocumentSource = y;
            documentViewer1.CreateControl();
        }
    }
}
