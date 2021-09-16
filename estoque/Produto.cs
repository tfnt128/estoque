using System.Globalization;

namespace estoque
{
    class Produto
    {
        //criando os atributos com properties
        private string _nome;
        private double _preco;
        private int _quant; 

        //construtor vazio
        public Produto()
        {
        }

        //criando o construtor
        public Produto(string nome, double preco, int quant)
        {
            _nome = nome;
            _preco = preco;
            _quant = quant;
        }

        //utilização das properties
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

        //utilização das properties
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quant; }
        }

        //criando métodos
        public double valorTotalEmEstoque()
        {
            return _preco * _quant;
        }
        public void adcionarProdutos(int quantidade)
        {
            _quant += quantidade;
        }
        public void removerProdutos(int quantidade)
        {
            _quant -= quantidade;
        }

        //criando tostring
        public override string ToString()
        {
            return _nome + ", R$" + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + _quant + " Unidades, Total: " + (_preco * _quant).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
