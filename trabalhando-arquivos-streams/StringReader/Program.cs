using System.Text;

var sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("e a segunda linha");
sb.AppendLine("e o fim");

var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;

// equivalente ao usar buffer
do
{
    Console.WriteLine(sr.ReadLine());
} while (sr.Peek() >= 0);

/* do
{
    tamanho = sr.Read(buffer);
    Console.WriteLine(string.Join("", buffer));
} while (tamanho >= buffer.Length); */

Console.WriteLine("Aperte enter para encerrar a aplicação");
Console.ReadLine();
Console.Clear();
