namespace ExercArquivos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public double Total()
        {
            return Valor * Quantidade;

        }

    }
}
