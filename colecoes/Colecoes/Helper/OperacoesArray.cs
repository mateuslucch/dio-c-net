namespace Colecoes.Helper
{
    public class OperacoesArray
    {

        public void OrdenarBubbleSort(ref int[] array)  // ref: nao vai retornar outro array
        {
            int temp = 0;
            int numeroChecagens = 0;
            for (int i = 0; i < array.Length; i++)
            {

                System.Console.WriteLine($"Teste {i + 1}");
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    numeroChecagens++;
                    System.Console.WriteLine($"Checando {array[j]} com {array[j + 1]}");

                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }

                    var linha = string.Join(", ", array);
                    System.Console.WriteLine($"Novo array: {linha}");
                }
            }
            System.Console.WriteLine($"Numero comparações:{numeroChecagens}");
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array); // unir valores do array em uma string
            System.Console.WriteLine(linha);

            // for (int i = 0; i < array.Length; i++) { System.Console.WriteLine(array[i]); }
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, 5);
        }

        public bool Existe(int[] array, int valorChecado)
        {
            return Array.Exists(array, elemento => elemento == valorChecado); // varredura, elemento é o valor a ser testado
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento >= valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

         

    }
}