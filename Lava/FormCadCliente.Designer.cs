
namespace Lava
{
    partial class FormCadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCliente));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCPFCNPJ = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxCep = new System.Windows.Forms.TextBox();
            this.txtBoxRua = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.txtBoxComplemento = new System.Windows.Forms.TextBox();
            this.txtBoxCidade = new System.Windows.Forms.TextBox();
            this.txtBoxEstado = new System.Windows.Forms.TextBox();
            this.btnBuscarCadCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtBoxProcura = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxIdentificacao = new System.Windows.Forms.ComboBox();
            this.txtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(104, 96);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(52, 21);
            this.txtBoxId.TabIndex = 1;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(104, 150);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(271, 21);
            this.txtBoxNome.TabIndex = 3;
            // 
            // txtBoxCPFCNPJ
            // 
            this.txtBoxCPFCNPJ.Location = new System.Drawing.Point(256, 120);
            this.txtBoxCPFCNPJ.Name = "txtBoxCPFCNPJ";
            this.txtBoxCPFCNPJ.Size = new System.Drawing.Size(119, 21);
            this.txtBoxCPFCNPJ.TabIndex = 2;
            this.txtBoxCPFCNPJ.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(256, 177);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(119, 21);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxCep
            // 
            this.txtBoxCep.Location = new System.Drawing.Point(104, 204);
            this.txtBoxCep.Name = "txtBoxCep";
            this.txtBoxCep.Size = new System.Drawing.Size(100, 21);
            this.txtBoxCep.TabIndex = 6;
            // 
            // txtBoxRua
            // 
            this.txtBoxRua.Location = new System.Drawing.Point(104, 231);
            this.txtBoxRua.Name = "txtBoxRua";
            this.txtBoxRua.Size = new System.Drawing.Size(100, 21);
            this.txtBoxRua.TabIndex = 7;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(256, 231);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(49, 21);
            this.txtBoxNumero.TabIndex = 8;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.Location = new System.Drawing.Point(104, 258);
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(100, 21);
            this.txtBoxBairro.TabIndex = 9;
            // 
            // txtBoxComplemento
            // 
            this.txtBoxComplemento.Location = new System.Drawing.Point(104, 285);
            this.txtBoxComplemento.Name = "txtBoxComplemento";
            this.txtBoxComplemento.Size = new System.Drawing.Size(100, 21);
            this.txtBoxComplemento.TabIndex = 11;
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.Location = new System.Drawing.Point(256, 258);
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(100, 21);
            this.txtBoxCidade.TabIndex = 10;
            // 
            // txtBoxEstado
            // 
            this.txtBoxEstado.Location = new System.Drawing.Point(256, 288);
            this.txtBoxEstado.Name = "txtBoxEstado";
            this.txtBoxEstado.Size = new System.Drawing.Size(100, 21);
            this.txtBoxEstado.TabIndex = 12;
            // 
            // btnBuscarCadCliente
            // 
            this.btnBuscarCadCliente.Location = new System.Drawing.Point(153, 40);
            this.btnBuscarCadCliente.Name = "btnBuscarCadCliente";
            this.btnBuscarCadCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCadCliente.TabIndex = 14;
            this.btnBuscarCadCliente.Text = "Buscar";
            this.btnBuscarCadCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCadCliente.Click += new System.EventHandler(this.btnBuscarCadCliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(315, 40);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(153, 340);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(234, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(315, 340);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(25, 96);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(17, 13);
            this.Id.TabIndex = 20;
            this.Id.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "CPF/CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Rua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "N°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Estado";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(210, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 33;
            this.button7.Text = "Busca CEP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtBoxProcura
            // 
            this.txtBoxProcura.Location = new System.Drawing.Point(47, 40);
            this.txtBoxProcura.Name = "txtBoxProcura";
            this.txtBoxProcura.Size = new System.Drawing.Size(100, 21);
            this.txtBoxProcura.TabIndex = 34;
            // 
            // cmbBoxIdentificacao
            // 
            this.cmbBoxIdentificacao.FormattingEnabled = true;
            this.cmbBoxIdentificacao.Items.AddRange(new object[] {
            "",
            "CPF",
            "CNPJ"});
            this.cmbBoxIdentificacao.Location = new System.Drawing.Point(104, 123);
            this.cmbBoxIdentificacao.Name = "cmbBoxIdentificacao";
            this.cmbBoxIdentificacao.Size = new System.Drawing.Size(52, 21);
            this.cmbBoxIdentificacao.TabIndex = 1;
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Location = new System.Drawing.Point(104, 177);
            this.txtBoxTelefone.Mask = "(00)900000-9999";
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(100, 21);
            this.txtBoxTelefone.TabIndex = 4;
            // 
            // FormCadCliente
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 422);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.cmbBoxIdentificacao);
            this.Controls.Add(this.txtBoxProcura);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscarCadCliente);
            this.Controls.Add(this.txtBoxEstado);
            this.Controls.Add(this.txtBoxCidade);
            this.Controls.Add(this.txtBoxComplemento);
            this.Controls.Add(this.txtBoxBairro);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.txtBoxRua);
            this.Controls.Add(this.txtBoxCep);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxCPFCNPJ);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxId);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormCadCliente.IconOptions.LargeImage")));
            this.Name = "FormCadCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCPFCNPJ;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxCep;
        private System.Windows.Forms.TextBox txtBoxRua;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.TextBox txtBoxComplemento;
        private System.Windows.Forms.TextBox txtBoxCidade;
        private System.Windows.Forms.TextBox txtBoxEstado;
        private System.Windows.Forms.Button btnBuscarCadCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MaskedTextBox txtBoxProcura;
        private System.Windows.Forms.ComboBox cmbBoxIdentificacao;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefone;
    }
}