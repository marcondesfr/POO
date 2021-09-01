using System.Globalization;
namespace proj1
{
    public class Produto
    {
        private string _name;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string name, double preco, int quantidade) {
            _name = name;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome {
            get { return _name; }
            set { if ( value != null && value.Length > 1 ) {
                value = _name;
            }}
        }
        public void SetNome(string nome) {
            if ( nome != null && nome.Length > 1) {
            _name = nome;
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }
        
        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _name + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
            ", " + Quantidade + " unidade, Total: $ " +
            ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}