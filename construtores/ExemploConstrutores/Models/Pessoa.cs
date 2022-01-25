namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;

        // public Pessoa() // construtor vazio
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine($"Construtor classe pessoa");
        }

        public void Apresentar()
        {
            //this.sobrenome = "teste"; // vai dar erro, nao pode alterar aqui (readonly)
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }

    }
}