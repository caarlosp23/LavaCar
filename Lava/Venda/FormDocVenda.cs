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
    public partial class FormDocVenda : Form
    {
        public FormDocVenda()
        {
            InitializeComponent();
            txtBoxIdVenda.Enabled = false;
            preencherCmbServico();
            preencherCmbCliente();
        }

        public void preencherCmbServico()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=LavaCarlos; User ID=usuario; password=senha;language=Portuguese; Trusted_Connection=true");
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,servico  from cad_servico";
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbBoxServico.DisplayMember = "servico";
                cmbBoxServico.DataSource = dt;
                cmbBoxServico.ValueMember = "id";

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void preencherCmbCliente()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=LavaCarlos; User ID=usuario; password=senha;language=Portuguese; Trusted_Connection=true");
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,nome from cad_cliente";
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
        private void btnVenda_Click(object sender, EventArgs e)
        {
            VendaOp x = new VendaOp();
            x.Numero = txtBoxNumeroVenda.Text;
            x.Servico = cmbBoxServico.SelectedValue.ToString();
            x.Cliente = cmbBoxCliente.SelectedValue.ToString();
            x.Total = decimal.Parse(txtBoxTotal.Text);

            x.GravarVenda();
            
           
            MessageBox.Show(x.mensagem);

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDocVenda_Load(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            string sql = "selecT venda.id as 'ID',venda.Numero, servico.Servico as 'Serviço', cliente.Nome as 'Nome do Cliente', venda.Total, venda.Data From doc_venda as venda " +
                "inner join cad_cliente as cliente on cliente.id = venda.cliente inner join CAD_Servico as servico  on " +
                "servico.id = venda.Servico";


            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            string sql = "selecT  venda.id as 'ID',venda.Numero, servico.Servico as 'Serviço', cliente.Nome as 'Nome do Cliente', venda.Total, venda.Data From doc_venda as venda " +
                "inner join cad_cliente as cliente on cliente.id = venda.cliente inner join CAD_Servico as servico  on " +
                "servico.id = venda.Servico";


            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }
        
        public void PreencherDtGridView(DataGridViewRow row)
        {
            txtBoxIdVenda.Text = row.Cells["Id"].Value.ToString();
            txtBoxNumeroVenda.Text = row.Cells["Numero"].Value.ToString();
            cmbBoxServico.Text = row.Cells["Serviço"].Value.ToString();
            cmbBoxCliente.Text = row.Cells["Nome Do Cliente"].Value.ToString();
            txtBoxTotal.Text = row.Cells["Total"].Value.ToString();
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

            //passa para um método responsável por preencher todos os textboxes  
            PreencherDtGridView(row);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            VendaOp veic = new VendaOp();
            veic.ID = int.Parse(txtBoxIdVenda.Text);




            veic = veic.ConsultaVenda(veic.ID);
            if (veic == null)
            {
                MessageBox.Show("Erro ao excluir: a venda não foi encontrada (404)!");
                return;
            }

            bool retorno = veic.ExcluirVenda();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }
        }
    }
   

}     

     