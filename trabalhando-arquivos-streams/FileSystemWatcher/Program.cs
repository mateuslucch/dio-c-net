//var path = @"/mnt/d/programacao/dio_bootcamp/c-net/trabalhando-arquivos-streams/Projeto2/globo";
var path = @"d:\programacao\dio_bootcamp\c-net\trabalhando-arquivos-streams\Projeto2\globo";
using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true; // eventos sejam disparados
fsw.IncludeSubdirectories = true; // subfolders também são lidos

Console.WriteLine($"Monitorando eventos na pasta {path}");
Console.WriteLine("Aperte Enter para encerrar aplicação");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Arquivo {e.Name} criado.");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Arquivo {e.Name} deletado.");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"Arquivo {e.Name} renomeado para {e.Name}.");
}