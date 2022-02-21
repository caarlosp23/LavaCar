
namespace Lava
{
    partial class FormDocVenda
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
            this.txtBoxIdVenda = new System.Windows.Forms.TextBox();
            this.txtBoxNumeroVenda = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.cmbBoxServico = new System.Windows.Forms.ComboBox();
            this.cmbBoxCliente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // txtBoxIdVenda
            // 
            this.txtBoxIdVenda.Location = new System.Drawing.Point(94, 38);
            this.txtBoxIdVenda.Name = "txtBoxIdVenda";
            this.txtBoxIdVenda.Size = new System.Drawing.Size(33, 20);
            this.txtBoxIdVenda.TabIndex = 6;
            // 
            // txtBoxNumeroVenda
            // 
            this.txtBoxNumeroVenda.Location = new System.Drawing.Point(94, 64);
            this.txtBoxNumeroVenda.Name = "txtBoxNumeroVenda";
            this.txtBoxNumeroVenda.Size = new System.Drawing.Size(33, 20);
            this.txtBoxNumeroVenda.TabIndex = 7;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(316, 65);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotal.TabIndex = 10;
            // 
            // cmbBoxServico
            // 
            this.cmbBoxServico.FormattingEnabled = true;
            this.cmbBoxServico.Location = new System.Drawing.Point(94, 90);
            this.cmbBoxServico.Name = "cmbBoxServico";
            this.cmbBoxServico.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxServico.TabIndex = 12;
            // 
            // cmbBoxCliente
            // 
            this.cmbBoxCliente.FormattingEnabled = true;
            this.cmbBoxCliente.Location = new System.Drawing.Point(316, 38);
            this.cmbBoxCliente.Name = "cmbBoxCliente";
            this.cmbBoxCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxCliente.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 391);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(480, 36);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(75, 23);
            this.btnVenda.TabIndex = 15;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(480, 65);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDocVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbBoxCliente);
            this.Controls.Add(this.cmbBoxServico);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxNumeroVenda);
            this.Controls.Add(this.txtBoxIdVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDocVenda";
            this.Text = "FormDocVenda";
            this.Load += new System.EventHandler(this.FormDocVenda_Load);
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
        private System.Windows.Forms.TextBox txtBoxIdVenda;
        private System.Windows.Forms.TextBox txtBoxNumeroVenda;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.ComboBox cmbBoxServico;
        private System.Windows.Forms.ComboBox cmbBoxCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
    }
}