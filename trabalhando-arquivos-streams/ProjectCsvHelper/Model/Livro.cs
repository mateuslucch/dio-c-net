using CsvHelper.Configuration.Attributes;

public class Livro
{
    // [Name()],[Format()]... datanotation, substituidos por classe de mapping (LivroMap.cs)

    //[Name("titulo")] // nome original no csv
    // [Index(0)]  // cada linha é como um array, index 0 vai ser primeiro valor (caso nao tenha cabeçalho)
    public string? Titulo { get; set; }
    //[Name("autor")]
    public string? Autor { get; set; }    
    //[Name("preço")]
    //[CultureInfo("pt-BR")] // padrao br, aqui troca ponto por virgula
    public decimal Preco { get; set; }
    //[Name("lançamento")]
    //[Format("dd/MM/yyyy")]
    public DateOnly Lancamento { get; set; } //obs: DateOnly reconhec sistema americano mm/dd/aaaa
}