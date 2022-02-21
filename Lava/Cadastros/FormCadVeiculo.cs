using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lava
{
    public partial class FormCadVeiculo : Form
    {
        public FormCadVeiculo()
        {
            InitializeComponent();
            preencherCmbBoxCliente();
            txtBoxIdVeiculo.Enabled = false;
            limparDesativarCampos();
        }


        public void limparDesativarCampos()
        {
            txtBoxModelo.Enabled = false;
            txtBoxPlaca.Enabled = false;
            cmbBoxTipoVeiculo.Enabled = false;
            txtBoxCor.Enabled = false;
            cmbBoxCliente.Enabled = false;

            btnAlterarVeiculo.Enabled = false;
            btnCadVeiculo.Enabled = false;
            btnExcluirVeiculo.Enabled = false;
            btnLimparVeiculo.Enabled = false;

            txtBoxModelo.Clear();
            txtBoxPlaca.Clear();
            txtBoxCor.Clear();

        }
        public void ativaCampos()
        {
            txtBoxModelo.Enabled = true;
            txtBoxPlaca.Enabled = true;
            cmbBoxTipoVeiculo.Enabled = true;
            txtBoxCor.Enabled = true;
            cmbBoxCliente.Enabled = true;

            btnAlterarVeiculo.Enabled = true;
            btnCadVeiculo.Enabled = true;
            btnExcluirVeiculo.Enabled = true;
            btnLimparVeiculo.Enabled = true;
        }
        public void preencherCmbBoxCliente()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=LavaCarlos; User ID=usuario; password=senha;language=Portuguese; Trusted_Connection=true");
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,nome, *from cad_cliente";
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbBoxCliente.DisplayMember = "nome";
                cmbBoxCliente.DataSource = dt;
                cmbBoxCliente.ValueMember = "id";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            VeiculoOp x = new VeiculoOp();
            x.Modelo = txtBoxModelo.Text;
            x.TipoVeiculo = cmbBoxTipoVeiculo.SelectedItem.ToString();
            x.Cor = txtBoxCor.Text;
            x.Placa = txtBoxPlaca.Text;
            x.Cliente = cmbBoxCliente.SelectedValue.ToString();

            x.GravarVeiculo();
            MessageBox.Show(x.mensagem);
            btnListarVeiculo.PerformClick();
        }

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            VeiculoOp veic = new VeiculoOp();
            veic.Id = int.Parse(txtBoxIdVeiculo.Text);
            veic.TipoVeiculo = cmbBoxTipoVeiculo.Text;
            veic.Modelo = txtBoxModelo.Text;
            veic.Cor = txtBoxCor.Text;
            veic.Placa = txtBoxPlaca.Text;
            veic.Cliente = cmbBoxCliente.SelectedValue.ToString();
            bool retorno = veic.atualizarVeiculo();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
            btnListarVeiculo.PerformClick();

        }

        private void btnListarVeiculo_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            string sql = "selecT veiculo.Id,TipoVeiculo as 'Tipo de Veiculo', Modelo, Cor, Placa, Nome as 'Nome do Cliente', CpfCnpj" +
                " from CAD_Cliente as cliente inner join CAD_Veiculo as veiculo on cliente.Id = veiculo.Cliente";


            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
            btnExcluirVeiculo.Enabled = true;
            btnAlterarVeiculo.Enabled = true;
            txtBoxModelo.Enabled = true;
            txtBoxPlaca.Enabled = true;
            cmbBoxTipoVeiculo.Enabled = true;
            txtBoxCor.Enabled = true;
            cmbBoxCliente.Enabled = true;
            btnCadVeiculo.Enabled = false;
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            VeiculoOp veic = new VeiculoOp();
            veic.Id = int.Parse(txtBoxIdVeiculo.Text);




            veic = veic.ConsultaVeiculo(veic.Id);

            if (veic == null)
            {
                MessageBox.Show("Erro ao excluir: O Veiculo não foi encontrado (404)!");
                return;
            }

            bool retorno = veic.ExcluirVeiculo();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }
            btnListarVeiculo.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

            //passa para um método responsável por preencher todos os textboxes  
            PreencherDtGridView(row);
        }
        public void PreencherDtGridView(DataGridViewRow row)
        {
            txtBoxIdVeiculo.Text = row.Cells["Id"].Value.ToString();
            txtBoxModelo.Text = row.Cells["Modelo"].Value.ToString();
            txtBoxCor.Text = row.Cells["Cor"].Value.ToString();
            txtBoxPlaca.Text = row.Cells["Placa"].Value.ToString();
            cmbBoxCliente.Text = row.Cells["Nome do Cliente"].Value.ToString();
            cmbBoxTipoVeiculo.Text = row.Cells["Tipo de Veiculo"].Value.ToString();

        }

        private void btnNovoVeiculo_Click(object sender, EventArgs e)
        {
            btnAlterarVeiculo.Enabled = false;
            btnExcluirVeiculo.Enabled = false;
            btnCadVeiculo.Enabled = true;
            txtBoxModelo.Enabled = true;
            txtBoxPlaca.Enabled = true;
            cmbBoxTipoVeiculo.Enabled = true;
            txtBoxCor.Enabled = true;
            cmbBoxCliente.Enabled = true;
            txtBoxModelo.Clear();
            txtBoxPlaca.Clear();
            txtBoxCor.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
