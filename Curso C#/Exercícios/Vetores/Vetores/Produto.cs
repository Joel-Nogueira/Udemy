namespace Vetores
{
    struct Produto
    {
        public string Nome;
        public double Preco;
        public override string ToString()
        {
            return "Nome: " + Nome + ", Preço: " + Preco;
        }
    }
}
