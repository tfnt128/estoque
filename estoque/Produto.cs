using System.Globalization;

namespace estoque
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quant { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quant = quant;
        }
        public double valorTotalEmEstoque()
        {
            return Preco * Quant;
        }
        public void adcionarProdutos(int quantidade)
        {
            Quant += quantidade;
        }
        public void removerProdutos(int quantidade)
        {
            Quant -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quant + " Unidades, Total: " + (Preco * Quant).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
