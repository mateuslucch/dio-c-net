using static System.Console;
/* 
CreateGlobeDirectory();
CreateFile();

var origin = Path.Combine(Environment.CurrentDirectory, "globo", "America-do-sul", "brasil.txt");
var destiny = Path.Combine(Environment.CurrentDirectory, "globo", "America-do-sul", "Brasil", "brasil.txt");

//MoveFile(origin, destiny);
//CopyFile(origin, destiny);
 */

var path = Path.Combine(Environment.CurrentDirectory, "globo");
ReadFiles(path);

static void ReadFiles(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]:{fileInfo.Name}");
        Console.WriteLine($"[Tamanho]:{fileInfo.Length}");
        Console.WriteLine($"[Ultimo acesso]:{fileInfo.LastAccessTime}");
        Console.WriteLine($"[Pasta]:{fileInfo.DirectoryName}");
        Console.WriteLine("-----------------");
    }
}

static void MoveFile(string pathOrigin, string pathDestiny)
{
    if (File.Exists(pathDestiny))
    {
        WriteLine("Arquivo já existente no destino");
        return;
    }
    File.Move(pathOrigin, pathDestiny);
}

static void CopyFile(string pathOrigin, string pathDestiny)
{
    if (File.Exists(pathDestiny))
    {
        WriteLine("Arquivo já existente no destino");
        return;
    }
    File.Copy(pathOrigin, pathDestiny);
}

static void CreateFile()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213M");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados Atualizados em: 20/04/2100");
    }
}

static void CreateGlobeDirectory()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmericaNorte = dirGlobo.CreateSubdirectory("America-do-norte");
        var dirAmericaSul = dirGlobo.CreateSubdirectory("America-do-sul");
        var dirAmericaCentral = dirGlobo.CreateSubdirectory("America-central");

        dirAmericaNorte.CreateSubdirectory("USA");
        dirAmericaNorte.CreateSubdirectory("Mexico");
        dirAmericaNorte.CreateSubdirectory("Canada");

        dirAmericaCentral.CreateSubdirectory("Costa-Rica");
        dirAmericaCentral.CreateSubdirectory("Panama");

        dirAmericaSul.CreateSubdirectory("Brasil");
        dirAmericaSul.CreateSubdirectory("Argentina");
        dirAmericaSul.CreateSubdirectory("Paraguai");
    }
    else { WriteLine("Diretório existente"); }
}
