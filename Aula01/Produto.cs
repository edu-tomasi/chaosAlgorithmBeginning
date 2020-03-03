namespace chaosAlgorithmBeginning.Aula01
{
    internal class Produto 
    {
        private string _nome;
        private double _preco;

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public double getPreco() => _preco;
        public string getNome() => _nome;
        
    }
}