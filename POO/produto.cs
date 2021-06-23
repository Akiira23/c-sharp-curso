namespace POO
{
    public class Produto 
    {
        private int codigo;
        private string nome;
        private double preco;
        public int Codigo {set => codigo = value;}
        public string Nome {set => nome = value;}
        public double Preco {set => preco = value;}

        public int getCodigo()
        {
            return this.codigo;
        }
        public string getNome()
        {
            return this.nome;
        }
        public double getPreco()
        {
            return this.preco;
        }
    }
}