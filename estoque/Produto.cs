using System.Globalization;

namespace estoque
{
    class Produto
    {
        //criando as propriedades
        public string Nome;
        public double Preco;
        public int Quant;

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

        //Utilizando o Get e Set
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
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
