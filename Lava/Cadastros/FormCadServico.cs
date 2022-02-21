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
    public partial class FormCadServico : Form
    {
        public FormCadServico()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void btnNovoServico_Click(object sender, EventArgs e)
        {
            

        }

        private void txtBoxVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnCadServico_Click(object sender, EventArgs e)
        {
            ServicoOp x = new ServicoOp();
            x.servico = txtBoxServico.Text;
            x.precoCusto = decimal.Parse(txtBoxCusto.Text);
            x.precoVenda = decimal.Parse(txtBoxVenda.Text);

            x.GravarServico();
            MessageBox.Show(x.mensagem);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

            //passa para um método responsável por preencher todos os textboxes  
            PreencherDtGridView(row);
        }

        private void btnAlterarServico_Click(object sender, EventArgs e)
        {
            ServicoOp veic = new ServicoOp();
            veic.ID = int.Parse(txtBoxIdServico.Text);
            veic.servico = txtBoxServico.Text;
            veic.precoCusto = decimal.Parse(txtBoxCusto.Text);
            veic.precoVenda = decimal.Parse(txtBoxVenda.Text);
            
            bool retorno = veic.atualizarServico();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        private void btnListarServico_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            string sql = "selecT id as ID, servico as 'Serviço', precocusto as 'Preço de Custo', precovenda as 'Preço de Venda' From cad_servico";


            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            ServicoOp veic = new ServicoOp();
            veic.ID = int.Parse(txtBoxIdServico.Text);

            veic = veic.ConsultaServico(veic.ID);

            if (veic == null)
            {
                MessageBox.Show("Erro ao excluir: O Veiculo não foi encontrado (404)!");
                return;
            }

            bool retorno = veic.ExcluirServico();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }

        }
        public void PreencherDtGridView(DataGridViewRow row)
        {
            txtBoxIdServico.Text = row.Cells["Id"].Value.ToString();
            txtBoxServico.Text = row.Cells["Serviço"].Value.ToString();
            txtBoxCusto.Text = row.Cells["Preço de Custo"].Value.ToString();
            txtBoxVenda.Text = row.Cells["Preço de venda"].Value.ToString();
        }
    }
}



