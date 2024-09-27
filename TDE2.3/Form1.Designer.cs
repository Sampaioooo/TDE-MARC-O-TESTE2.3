namespace TDE2._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCliente = new Label();
            txtCliente = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label4 = new Label();
            lblPreço = new Label();
            label7 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            cobProduto = new ComboBox();
            txtQuantidade = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            lblData = new Label();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 23);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(64, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(6, 55);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(547, 27);
            txtCliente.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS DO CLIENTE";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "PRODUTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 23);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 2;
            label4.Text = "QUANTIDADE";
            // 
            // lblPreço
            // 
            lblPreço.AutoSize = true;
            lblPreço.Location = new Point(561, 65);
            lblPreço.Name = "lblPreço";
            lblPreço.Size = new Size(63, 20);
            lblPreço.TabIndex = 3;
            lblPreço.Text = "lblPreço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(561, 23);
            label7.Name = "label7";
            label7.Size = new Size(54, 40);
            label7.TabIndex = 4;
            label7.Text = "PREÇO\r\n\r\n";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(675, 26);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "REGISTRA";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(676, 72);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cobProduto
            // 
            cobProduto.FormattingEnabled = true;
            cobProduto.Location = new Point(6, 57);
            cobProduto.Name = "cobProduto";
            cobProduto.Size = new Size(383, 28);
            cobProduto.TabIndex = 7;
            cobProduto.SelectedIndexChanged += cobProduto_SelectedIndexChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(406, 57);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(132, 27);
            txtQuantidade.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtQuantidade);
            groupBox2.Controls.Add(cobProduto);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblPreço);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 125);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DADOS DO CLIENTE";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(688, 51);
            label3.Name = "label3";
            label3.Size = new Size(72, 31);
            label3.TabIndex = 2;
            label3.Text = "DATA\r\n";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 0;
            label1.Text = "CONTROLE DE VENDAS";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(688, 91);
            lblData.Name = "lblData";
            lblData.Size = new Size(58, 20);
            lblData.TabIndex = 6;
            lblData.Text = "lblData";
            lblData.Click += label6_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PRODUTO";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "QUANTIDADE";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PREÇO";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "SUBTOTAL";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "DESCONTO";
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "LÍQUIDO";
            columnHeader6.Width = 160;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(18, 340);
            listView1.Name = "listView1";
            listView1.Size = new Size(769, 230);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(listView1);
            Controls.Add(lblData);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHora;
        private Label lblLiquido01;
        private Label lblCliente;
        private TextBox txtCliente;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label lblPreço;
        private Label label7;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ComboBox cobProduto;
        private TextBox txtQuantidade;
        private GroupBox groupBox2;
        private Label label3;
        private Label label1;
        private Label lblData;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listView1;
    }
}
