namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            foreach (var item in lista)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}