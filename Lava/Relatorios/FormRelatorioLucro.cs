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
    public partial class FormRelatorioLucro : Form
    {
        public FormRelatorioLucro()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            RelLucro x = new RelLucro();
            x.CreateDocument();
            documentViewer1.DocumentSource = x;
            documentViewer1.CreateControl();
        }
    }
}
