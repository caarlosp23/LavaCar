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
    public partial class FormRelatorioVenda : Form
    {
        public FormRelatorioVenda()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            RelVenda y = new RelVenda();
            y.CreateDocument();
            documentViewer1.DocumentSource = y;
            documentViewer1.CreateControl();
        }
    }
}
