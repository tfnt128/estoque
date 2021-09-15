using System.Globalization;

namespace estoque
{
    class Produto
    {
        //criando as propriedades
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quant { get; private set; }

        //construtor vazio
        public Produto()
        {
        }

        //criando o construtor
        public Produto(string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quant = quant;
        }

        public string nome
        {
            get { return nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    nome = value;
                }
            }
        }


        //criando métodos
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

        //criando tostring
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quant + " Unidades, Total: " + (Preco * Quant).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
