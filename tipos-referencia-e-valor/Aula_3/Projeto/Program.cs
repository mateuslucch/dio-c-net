using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "Mateus";
        p1.Idade = 38;
        p1.EnderecoPessoa = new Endereco()
        {
            Logradouro = "Rua Ex",
            Numero = 300,
            Cep = "0000",
            Cidade = "São Paulo",
        };

        WriteLine("Fim");
    }
}
