using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

Console.Clear();
Console.Clear();

/* diferenças no GetRecords */
// ReadCsvWithClass();
// ReadCsvWithDynamic();

/*exemplo pontovirgula no csv. csvConfig recebe parâmetros*/
//ReadCsvDifferentDelimiter();

/* escrever um csv */
WriteCsv();

static void WriteCsv()
{
    
    var path = Path.Combine(
       Environment.CurrentDirectory,
       "Saida");

    var di = new DirectoryInfo(path);

    if (!di.Exists)
    {
        di.Create(); // cria diretorio se nao existir
    }

    path = Path.Combine(path, "usuarios.csv");

    var pessoas = new List<Pessoa>{
            new Pessoa()
            {
                Name = "José da Silva",
                Email = "js@gmail.com",
                Telefone = 123456,
            },
            new Pessoa(){
                Name = "Pedro Paiva",
                Email = "pp@gmail.com",
                Telefone = 456789,
            },
            new Pessoa()
            {
                Name = "Maria Antonia",
                Email = "ma@gmail.com",
                Telefone = 123456,
            },
            new Pessoa()
            {
                Name = "Carla Moraes",
                Email = "cms@gmail.com",
                Telefone = 9987411,
            }

       };
    using var sr = new StreamWriter(path);
    var csvConfig = new CsvConfiguration(CultureInfo.InstalledUICulture)
    {
        Delimiter = "|"
    };
    using var csvWriter = new CsvWriter(sr, csvConfig); //csvConfig sobrepõe o original
    csvWriter.WriteRecords(pessoas);
}



static void ReadCsvDifferentDelimiter()
{
    var path = Path.Combine(
         Environment.CurrentDirectory,
         "Entrada",
         "livros-precos-pontovirgula.csv"
         );

    var fi = new FileInfo(path);

    if (!fi.Exists) { throw new FileNotFoundException($"O arquivo {path} não existe"); }

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };

    using var csvReader = new CsvReader(sr, csvConfig);
    csvReader.Context.RegisterClassMap<LivroMap>();

    var registros = csvReader.GetRecords<Livro>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Titulo: {registro.Titulo}");
        Console.WriteLine($"Autor: {registro.Autor}");
        Console.WriteLine($"Preço: {registro.Preco}");
        Console.WriteLine($"Lançamento: {registro.Lancamento}");
        Console.WriteLine($"---------------------");
    }

}

static void ReadCsvWithClass()
{
    var path = Path.Combine(
      Environment.CurrentDirectory,
      "Entrada",
      "novos-usuarios.csv"
      );

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Nome:{registro.Nome}");
        Console.WriteLine($"Email:{registro.Email}");
        Console.WriteLine($"Telefone:{registro.Telefone}");
        Console.WriteLine($"---------------------");
    }
}

static void ReadCsvWithDynamic()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "Produtos.csv"
        );

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture); // ou CultureInfo.GetCultureInfo("pt-BR"), ou pode pegar do so
    var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Nome:{registro.Produto}");
        Console.WriteLine($"Marca:{registro.Marca}");
        Console.WriteLine($"Preço:{registro.Preco}");
        Console.WriteLine($"---------------------");
    }
}