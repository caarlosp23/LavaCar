using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lava
{
    public partial class FormCadCliente : XtraForm
    {
        public FormCadCliente()
        {
            InitializeComponent();
            txtBoxId.Enabled = false;
            DesativaELimpaCampos();
        }

        public void DesativaELimpaCampos()
        {
            button2.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            button7.Enabled = false;
            txtBoxCPFCNPJ.Enabled = false;
            txtBoxNome.Enabled = false;
            txtBoxTelefone.Enabled = false;
            txtBoxEmail.Enabled = false;
            txtBoxCep.Enabled = false;
            txtBoxRua.Enabled = false;
            txtBoxNumero.Enabled = false;
            txtBoxBairro.Enabled = false;
            txtBoxCidade.Enabled = false;
            txtBoxComplemento.Enabled = false;
            txtBoxEstado.Enabled = false;
            cmbBoxIdentificacao.Enabled = false;

            txtBoxId.Clear();
            txtBoxCPFCNPJ.Clear();
            txtBoxNome.Clear();
            txtBoxTelefone.Clear();
            txtBoxEmail.Clear();
            txtBoxCep.Clear();
            txtBoxRua.Clear();
            txtBoxNumero.Clear();
            txtBoxBairro.Clear();
            txtBoxCidade.Clear();
            txtBoxComplemento.Clear();
            txtBoxEstado.Clear();
            txtBoxProcura.Clear();
            cmbBoxIdentificacao.SelectedIndex = 0;
        }
        public void ativaCampos()
        {
            txtBoxCPFCNPJ.Enabled = true;
            txtBoxNome.Enabled = true;
            txtBoxTelefone.Enabled = true;
            txtBoxEmail.Enabled = true;
            txtBoxCep.Enabled = true;
            txtBoxRua.Enabled = true;
            txtBoxNumero.Enabled = true;
            txtBoxBairro.Enabled = true;
            txtBoxCidade.Enabled = true;
            txtBoxComplemento.Enabled = true;
            txtBoxEstado.Enabled = true;
            cmbBoxIdentificacao.Enabled = true;
            button7.Enabled = true;
        }




        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
          
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCadCliente_Click(object sender, EventArgs e)
        {
            
            Conexao bd = new Conexao();
            ClienteOp op = new ClienteOp();


            if (op.BuscaCliente(txtBoxProcura.Text) == null)
            {
                MessageBox.Show("Usuario não encontrado!");
            }
            else
            {
                button2.Enabled = true;
                btnAlterar.Enabled = true;
                ativaCampos();
                txtBoxNome.Text = op.Nome;
                cmbBoxIdentificacao.SelectedIndex = op.Identificacao;
                txtBoxCPFCNPJ.Text = op.CpfCnpj;
                txtBoxTelefone.Text = op.Telefone;
                txtBoxCep.Text = op.CEP;
                txtBoxEmail.Text = op.Email;
                txtBoxRua.Text = op.Rua;
                txtBoxNumero.Text = op.NumeroEndereco;
                txtBoxBairro.Text = op.Bairro;
                txtBoxComplemento.Text = op.Complemento;
                txtBoxCidade.Text = op.Cidade;
                txtBoxEstado.Text = op.Estado;
                txtBoxId.Text = op.Id.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteOp cliente = new ClienteOp();
            cliente.CpfCnpj = txtBoxCPFCNPJ.Text;

            cliente = cliente.BuscaCliente(cliente.CpfCnpj);

            cliente.Id = int.Parse(txtBoxId.Text);

            if (cliente == null)
            {
                MessageBox.Show("Erro ao excluir: O Cliente não foi encontrado (404)!");
                return;
            }

            bool retorno = cliente.excluirCliente();

            if (retorno == true)
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exclusão!");
            }
            DesativaELimpaCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteOp cliente = new ClienteOp();
            cliente.Id = int.Parse(txtBoxId.Text);
            cliente.Nome = txtBoxNome.Text;
            cliente.Identificacao = cmbBoxIdentificacao.SelectedIndex;
            cliente.CpfCnpj = txtBoxCPFCNPJ.Text;
            cliente.Telefone = txtBoxTelefone.Text;
            cliente.Email = txtBoxEmail.Text;
            cliente.CEP = txtBoxCep.Text;
            cliente.Rua = txtBoxRua.Text;
            cliente.NumeroEndereco = txtBoxNumero.Text;
            cliente.Bairro = txtBoxBairro.Text;
            cliente.Complemento = txtBoxComplemento.Text;
            cliente.Cidade = txtBoxCidade.Text;
            cliente.Estado = txtBoxEstado.Text;


            bool retorno = cliente.atualizarCliente();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
            DesativaELimpaCampos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxCep.Text))
            {
                MessageBox.Show("Informe um CEP válido!", "Busca CEP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string strUrl = string.Format("https://viacep.com.br/ws/{0}/json/", txtBoxCep.Text.Trim());
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync(strUrl).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result;
                            ConsultaCep res = JsonConvert.DeserializeObject<ConsultaCep>(result);

                            txtBoxEstado.Text = res.UF;
                            txtBoxRua.Text = res.Logradouro;
                            txtBoxCidade.Text = res.Localidade;
                            txtBoxBairro.Text = res.Bairro;
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Busca CEP",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteOp x = new ClienteOp();
            x.Identificacao = cmbBoxIdentificacao.SelectedIndex;
            x.CpfCnpj = txtBoxCPFCNPJ.Text;
            x.Nome = txtBoxNome.Text;
            x.Telefone = txtBoxTelefone.Text;
            x.CEP = txtBoxCep.Text;
            x.Email = txtBoxEmail.Text;
            x.Rua = txtBoxRua.Text;
            x.NumeroEndereco = txtBoxNumero.Text;
            x.Bairro = txtBoxBairro.Text;
            x.Complemento = txtBoxComplemento.Text;
            x.Cidade = txtBoxCidade.Text;
            x.Estado = txtBoxEstado.Text;
            x.DataHoraCadastro = DateTime.Now;
            x.GravarCliente();
            MessageBox.Show(x.mensagem);
            DesativaELimpaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DesativaELimpaCampos();
            ativaCampos();
            btnLimpar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxId.Clear();
            txtBoxCPFCNPJ.Clear();
            txtBoxNome.Clear();
            txtBoxTelefone.Clear();
            txtBoxEmail.Clear();
            txtBoxCep.Clear();
            txtBoxRua.Clear();
            txtBoxNumero.Clear();
            txtBoxBairro.Clear();
            txtBoxCidade.Clear();
            txtBoxComplemento.Clear();
            txtBoxEstado.Clear();
            txtBoxProcura.Clear();
            cmbBoxIdentificacao.SelectedIndex = 0;
        }
    }
}
