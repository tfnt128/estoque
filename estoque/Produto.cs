using System.Globalization;

namespace estoque
{
    class Produto
    {
        //criando as propriedades com autoproperties
        public string _nome;
        public double Preco { get; private set; }
        public int Quant { get; private set; }

        //construtor vazio
        public Produto()
        {
        }

        //criando o construtor
        public Produto(string nome, double preco, int quant)
        {
            _nome = nome;
            Preco = preco;
            Quant = quant;
        }

        //fazendo get e set do nome
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
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
