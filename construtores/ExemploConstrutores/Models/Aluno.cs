namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        // aluno deve obedecer as regras da classe pessoa
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine($"Cosntrutor classe Aluno");
        }

    }
}