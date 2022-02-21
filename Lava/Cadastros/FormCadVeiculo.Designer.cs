
namespace Lava
{
    partial class FormCadVeiculo
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxIdVeiculo = new System.Windows.Forms.TextBox();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.txtBoxPlaca = new System.Windows.Forms.TextBox();
            this.txtBoxCor = new System.Windows.Forms.TextBox();
            this.cmbBoxTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.cmbBoxCliente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovoVeiculo = new System.Windows.Forms.Button();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.btnListarVeiculo = new System.Windows.Forms.Button();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.btnLimparVeiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Veiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente";
            // 
            // txtBoxIdVeiculo
            // 
            this.txtBoxIdVeiculo.Location = new System.Drawing.Point(98, 38);
            this.txtBoxIdVeiculo.Name = "txtBoxIdVeiculo";
            this.txtBoxIdVeiculo.Size = new System.Drawing.Size(38, 20);
            this.txtBoxIdVeiculo.TabIndex = 6;
            this.txtBoxIdVeiculo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Location = new System.Drawing.Point(98, 64);
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModelo.TabIndex = 7;
            // 
            // txtBoxPlaca
            // 
            this.txtBoxPlaca.Location = new System.Drawing.Point(98, 90);
            this.txtBoxPlaca.Name = "txtBoxPlaca";
            this.txtBoxPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPlaca.TabIndex = 8;
            // 
            // txtBoxCor
            // 
            this.txtBoxCor.Location = new System.Drawing.Point(353, 64);
            this.txtBoxCor.Name = "txtBoxCor";
            this.txtBoxCor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCor.TabIndex = 9;
            // 
            // cmbBoxTipoVeiculo
            // 
            this.cmbBoxTipoVeiculo.FormattingEnabled = true;
            this.cmbBoxTipoVeiculo.Items.AddRange(new object[] {
            "",
            "MOTOCICLETA",
            "AUTOMOVEL",
            "CAMINHÃO"});
            this.cmbBoxTipoVeiculo.Location = new System.Drawing.Point(353, 37);
            this.cmbBoxTipoVeiculo.Name = "cmbBoxTipoVeiculo";
            this.cmbBoxTipoVeiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTipoVeiculo.TabIndex = 10;
            // 
            // cmbBoxCliente
            // 
            this.cmbBoxCliente.FormattingEnabled = true;
            this.cmbBoxCliente.Location = new System.Drawing.Point(353, 90);
            this.cmbBoxCliente.Name = "cmbBoxCliente";
            this.cmbBoxCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxCliente.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 382);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNovoVeiculo
            // 
            this.btnNovoVeiculo.Location = new System.Drawing.Point(526, 31);
            this.btnNovoVeiculo.Name = "btnNovoVeiculo";
            this.btnNovoVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnNovoVeiculo.TabIndex = 13;
            this.btnNovoVeiculo.Text = "Novo";
            this.btnNovoVeiculo.UseVisualStyleBackColor = true;
            this.btnNovoVeiculo.Click += new System.EventHandler(this.btnNovoVeiculo_Click);
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Location = new System.Drawing.Point(526, 60);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnCadVeiculo.TabIndex = 14;
            this.btnCadVeiculo.Text = "Cadastrar";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // btnListarVeiculo
            // 
            this.btnListarVeiculo.Location = new System.Drawing.Point(526, 93);
            this.btnListarVeiculo.Name = "btnListarVeiculo";
            this.btnListarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnListarVeiculo.TabIndex = 15;
            this.btnListarVeiculo.Text = "Listar";
            this.btnListarVeiculo.UseVisualStyleBackColor = true;
            this.btnListarVeiculo.Click += new System.EventHandler(this.btnListarVeiculo_Click);
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(616, 60);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarVeiculo.TabIndex = 16;
            this.btnAlterarVeiculo.Text = "Alterar";
            this.btnAlterarVeiculo.UseVisualStyleBackColor = true;
            this.btnAlterarVeiculo.Click += new System.EventHandler(this.btnAlterarVeiculo_Click);
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(616, 92);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirVeiculo.TabIndex = 17;
            this.btnExcluirVeiculo.Text = "Excluir";
            this.btnExcluirVeiculo.UseVisualStyleBackColor = true;
            this.btnExcluirVeiculo.Click += new System.EventHandler(this.btnExcluirVeiculo_Click);
            // 
            // btnLimparVeiculo
            // 
            this.btnLimparVeiculo.Location = new System.Drawing.Point(616, 31);
            this.btnLimparVeiculo.Name = "btnLimparVeiculo";
            this.btnLimparVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnLimparVeiculo.TabIndex = 18;
            this.btnLimparVeiculo.Text = "Limpar";
            this.btnLimparVeiculo.UseVisualStyleBackColor = true;
            // 
            // FormCadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 530);
            this.Controls.Add(this.btnLimparVeiculo);
            this.Controls.Add(this.btnExcluirVeiculo);
            this.Controls.Add(this.btnAlterarVeiculo);
            this.Controls.Add(this.btnListarVeiculo);
            this.Controls.Add(this.btnCadVeiculo);
            this.Controls.Add(this.btnNovoVeiculo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbBoxCliente);
            this.Controls.Add(this.cmbBoxTipoVeiculo);
            this.Controls.Add(this.txtBoxCor);
            this.Controls.Add(this.txtBoxPlaca);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.txtBoxIdVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadVeiculo";
            this.Text = "FormCadVeiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxIdVeiculo;
        private System.Windows.Forms.TextBox txtBoxModelo;
        private System.Windows.Forms.TextBox txtBoxPlaca;
        private System.Windows.Forms.TextBox txtBoxCor;
        private System.Windows.Forms.ComboBox cmbBoxTipoVeiculo;
        private System.Windows.Forms.ComboBox cmbBoxCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovoVeiculo;
        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnListarVeiculo;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.Button btnLimparVeiculo;
    }
}