using static System.Console;

Console.Clear();

//ReadCsv();
CreateCsv();

WriteLine("\n\n Pressione [enter] para finalizar");
ReadLine();

void CreateCsv()
{
    var path = Path.Combine(
       Environment.CurrentDirectory,
       "Saida"
       );

    var pessoas = new List<Persons>{
            new Persons()
            {
                Name = "José da Silva",
                Email = "js@gmail.com",
                Telefone = 123456,
                BirthDate = new DateOnly(year: 1970, month: 2, day: 14)
            },
            new Persons(){
                Name = "Pedro Paiva",
                Email = "pp@gmail.com",
                Telefone = 456789,
                BirthDate = new DateOnly(year: 2002, month: 4, day: 20)
            },
            new Persons()
            {
                Name = "Maria Antonia",
                Email = "ma@gmail.com",
                Telefone = 123456,
                BirthDate = new DateOnly(year: 1982, month: 12, day: 4)
            },
            new Persons()
            {
                Name = "Carla Moraes",
                Email = "cms@gmail.com",
                Telefone = 9987411,
                BirthDate = new DateOnly(year: 2000, month: 7, day: 20)
            }
};

    var di = new DirectoryInfo(path);
    if (!di.Exists)
    {
        di.Create();
    }
    path = Path.Combine(path, "usuarios.csv");

    using var sw = new StreamWriter(path); // lembrar, dar flush se nao for usar using
    sw.WriteLine("nome,email,telefone,nascimento");
    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Name},{pessoa.Email},{pessoa.Telefone},{pessoa.BirthDate}";
        sw.WriteLine(linha);
    }


}

static void ReadCsv()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "usuarios-exportacao.csv");

    if (!File.Exists(path))
    {
        WriteLine($"{path} não existe.");
    }
    else
    {
        using var sr = new StreamReader(path);

        var cabecalho = sr.ReadLine()?.Split(',');

        while (true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if (registro == null) break;
            for (int i = 0; i < registro.Length; i++)
            {
                WriteLine($"{cabecalho?[i]}: {registro[i]}");
            }
            WriteLine("---------------");
        }
    }
}