using System.Globalization;
namespace proj1
{
    public class Produto
    {
        public string Name;
        public double Preco;
        public int Quantidade;
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
            return Name + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
            ", " + Quantidade + " unidade, Total: $ " +
            ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}