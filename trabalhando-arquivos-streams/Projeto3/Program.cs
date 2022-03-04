
var path = @"/mnt/d/programacao/dio_bootcamp/c-net/trabalhando-arquivos-streams/Projeto2/globo";

ReadFolders(path);

static void ReadFolders(string path)
{
    var folders = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
    foreach (var dir in folders)
    {
        var dirInfo = new DirectoryInfo(dir);
        Console.WriteLine($"[Nome]:{dirInfo.Name}");
        Console.WriteLine($"[Raiz]:{dirInfo.Root}");
        if (dirInfo.Parent != null)
        {
            Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");
        }
    }
    Console.WriteLine("---------------------");
}