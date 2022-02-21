
namespace Lava
{
    partial class FormCadServico
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
            this.txtBoxIdServico = new System.Windows.Forms.TextBox();
            this.txtBoxServico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCusto = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxVenda = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovoServico = new System.Windows.Forms.Button();
            this.btnCadServico = new System.Windows.Forms.Button();
            this.btnListarServico = new System.Windows.Forms.Button();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.btnAlterarServico = new System.Windows.Forms.Button();
            this.btnLimparServico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Custo";
            // 
            // txtBoxIdServico
            // 
            this.txtBoxIdServico.Location = new System.Drawing.Point(94, 23);
            this.txtBoxIdServico.Name = "txtBoxIdServico";
            this.txtBoxIdServico.Size = new System.Drawing.Size(31, 20);
            this.txtBoxIdServico.TabIndex = 3;
            // 
            // txtBoxServico
            // 
            this.txtBoxServico.Location = new System.Drawing.Point(94, 49);
            this.txtBoxServico.Name = "txtBoxServico";
            this.txtBoxServico.Size = new System.Drawing.Size(100, 20);
            this.txtBoxServico.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço Venda";
            // 
            // txtBoxCusto
            // 
            this.txtBoxCusto.Location = new System.Drawing.Point(94, 78);
            this.txtBoxCusto.Name = "txtBoxCusto";
            this.txtBoxCusto.Size = new System.Drawing.Size(40, 20);
            this.txtBoxCusto.TabIndex = 7;
            this.txtBoxCusto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.txtBoxCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // txtBoxVenda
            // 
            this.txtBoxVenda.Location = new System.Drawing.Point(94, 104);
            this.txtBoxVenda.Name = "txtBoxVenda";
            this.txtBoxVenda.Size = new System.Drawing.Size(40, 20);
            this.txtBoxVenda.TabIndex = 8;
            this.txtBoxVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxVenda_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(24, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 260);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNovoServico
            // 
            this.btnNovoServico.Location = new System.Drawing.Point(309, 26);
            this.btnNovoServico.Name = "btnNovoServico";
            this.btnNovoServico.Size = new System.Drawing.Size(75, 23);
            this.btnNovoServico.TabIndex = 10;
            this.btnNovoServico.Text = "Novo";
            this.btnNovoServico.UseVisualStyleBackColor = true;
            this.btnNovoServico.Click += new System.EventHandler(this.btnNovoServico_Click);
            // 
            // btnCadServico
            // 
            this.btnCadServico.Location = new System.Drawing.Point(309, 55);
            this.btnCadServico.Name = "btnCadServico";
            this.btnCadServico.Size = new System.Drawing.Size(75, 23);
            this.btnCadServico.TabIndex = 11;
            this.btnCadServico.Text = "Cadastrar";
            this.btnCadServico.UseVisualStyleBackColor = true;
            this.btnCadServico.Click += new System.EventHandler(this.btnCadServico_Click);
            // 
            // btnListarServico
            // 
            this.btnListarServico.Location = new System.Drawing.Point(309, 84);
            this.btnListarServico.Name = "btnListarServico";
            this.btnListarServico.Size = new System.Drawing.Size(75, 23);
            this.btnListarServico.TabIndex = 12;
            this.btnListarServico.Text = "Listar";
            this.btnListarServico.UseVisualStyleBackColor = true;
            this.btnListarServico.Click += new System.EventHandler(this.btnListarServico_Click);
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.Location = new System.Drawing.Point(412, 84);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirServico.TabIndex = 15;
            this.btnExcluirServico.Text = "Excluir";
            this.btnExcluirServico.UseVisualStyleBackColor = true;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // btnAlterarServico
            // 
            this.btnAlterarServico.Location = new System.Drawing.Point(412, 55);
            this.btnAlterarServico.Name = "btnAlterarServico";
            this.btnAlterarServico.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarServico.TabIndex = 14;
            this.btnAlterarServico.Text = "Alterar";
            this.btnAlterarServico.UseVisualStyleBackColor = true;
            this.btnAlterarServico.Click += new System.EventHandler(this.btnAlterarServico_Click);
            // 
            // btnLimparServico
            // 
            this.btnLimparServico.Location = new System.Drawing.Point(412, 26);
            this.btnLimparServico.Name = "btnLimparServico";
            this.btnLimparServico.Size = new System.Drawing.Size(75, 23);
            this.btnLimparServico.TabIndex = 13;
            this.btnLimparServico.Text = "Limpar";
            this.btnLimparServico.UseVisualStyleBackColor = true;
            // 
            // FormCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 419);
            this.Controls.Add(this.btnExcluirServico);
            this.Controls.Add(this.btnAlterarServico);
            this.Controls.Add(this.btnLimparServico);
            this.Controls.Add(this.btnListarServico);
            this.Controls.Add(this.btnCadServico);
            this.Controls.Add(this.btnNovoServico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxVenda);
            this.Controls.Add(this.txtBoxCusto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxServico);
            this.Controls.Add(this.txtBoxIdServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadServico";
            this.Text = "FormCadServico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxIdServico;
        private System.Windows.Forms.TextBox txtBoxServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtBoxCusto;
        private System.Windows.Forms.MaskedTextBox txtBoxVenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovoServico;
        private System.Windows.Forms.Button btnCadServico;
        private System.Windows.Forms.Button btnListarServico;
        private System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.Button btnAlterarServico;
        private System.Windows.Forms.Button btnLimparServico;
    }
}