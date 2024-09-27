using System.Collections;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms

namespace TDE2._3
{
    public partial class Form1 : Form
    {
        static string[] produtos = { "Teclado", "Impressora", "Monitor", "Mouse" };

        ArrayList aProduto = new ArrayList(produtos);

        Vendas objV = new Vendas();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarData();
            MosntrarHora();
            LimparCampos();
            PreencherProduto();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objV.Produto = cobProduto.Text;
            objV.Quantidade = int.Parse(txtQuantidade.Text);

            ListViewItem fila = new ListViewItem(objV.Produto);
            fila.SubItems.Add(objV.Quantidade.ToString());
            fila.SubItems.Add(objV.Quantidade.ToString("C"));
            fila.SubItems.Add(objV.CalcularSubTotal.ToString("C"));
            fila.SubItems.Add(objV.CalcularSubTotal.ToString("C"));
        }

        private void cobProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            objV.Produto = cobProduto.Text;
            lblPreço.Text = objV.AtribuirPreço().ToString("c");
        }
        private void MostrarData()
        {
            lblData.Text = DateTime.Now.ToShortDateString();
        }
        private void MosntrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortDateString();
        }
        private void LimparCampos()
        {
            txtCliente.Clear();
            cobProduto.Text = "Selecione um Produto";
            txtQuantidade.Clear();
            lblPreço.Text = "0,00";
            txtCliente.Focus();

        }


        private void PreencherProduto()
        {

            foreach (var p in aProduto)
            {
                cobProduto.Items.Add(p);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Você quer sair?", "Vendas", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimparCampos();
            }
        }

        private void lblPreço_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
