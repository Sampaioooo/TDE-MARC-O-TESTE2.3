using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE2._3
{
    public class Vendas
    {

        private string  produto;


        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }


        public int Quantidade { get; set; }


        public double CalcularSubTotal()
        {

            double preco = 10.0;
            return preco * Quantidade;
        }

        public double CalcularDesconto()
        {
            double subTotal = CalcularSubTotal();
            if (subTotal <= 300)
                return 5.0 / 100 * subTotal;
            else if (subTotal > 300 && subTotal <= 500)
                return 10.0 / 100 * subTotal;
            else
                return 12.5 / 100 * subTotal;
        }

        public double CalcularLiquido()
        {
            return CalcularSubTotal() - CalcularDesconto();
        }
    }
}