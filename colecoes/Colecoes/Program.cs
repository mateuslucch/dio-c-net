using System;
using Colecoes.Helper;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[10] { 100, 1, 6, 9, 0, 8, 4, 6, 8, 1 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(",", arrayNumeros)}");
            System.Console.WriteLine($"Array unico: {string.Join(",", arrayUnico)}");



            // var numerosParesQuery =
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine($"Numeros pares query: {string.Join(",", numerosParesQuery)}");
            // System.Console.WriteLine($"Numeros pares método: {string.Join(",", numerosParesMetodo)}");


            // // DICIONARIOS
            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // string valorProcurado = "SC";
            // System.Console.WriteLine($"Valor procurado atual: {valorProcurado}");

            // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não encontrada");
            // }


            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // estados[valorProcurado] = "BA - teste atualização";
            // System.Console.WriteLine(estados[valorProcurado]);

            // PILHA            
            // Stack<string> pilhaLivros = new Stack<string>();
            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Código Limpo");

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }
            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");


            // FILA
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Mateus");
            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Andre");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()}");
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // LISTAS
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>() { "SP", "TO", "AM" };
            // string[] estadosArray = new String[2] { "SC", "MT" };
            // estados.Add("RS");
            // estados.Add("MG");
            // estados.Add("BA");

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // System.Console.WriteLine($"Removendo o elemento");
            // estados.Remove("MG");

            // estados.AddRange(estadosArray);

            // estados.Insert(1,"RJ");
            // opLista.ImprimirListaString(estados);

            // ARRAYS
            // OperacoesArray operacao = new OperacoesArray();

            // int[] array = new int[6] { 6, 3, 8, 1, 9, 6 };
            // int[] arrayCopia = new int[10];

            // System.Console.WriteLine($"Array original: ");
            // operacao.ImprimirArray(array);

            // string[] arrayString = operacao.ConverterParaArrayString(array);


            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // operacao.RedimensionarArray(ref array, 12);
            // System.Console.WriteLine($"Nova capacidade: {array.Length}");
            // operacao.ImprimirArray(array);

            //int valorProcurado = 8;

            // int indice = operacao.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}");
            // }
            // else { System.Console.WriteLine($"Valor não existente no array"); }


            // int valorAchado = operacao.ObterValor(array, valorProcurado);

            // if (valorAchado > 0) { System.Console.WriteLine("Encontrei o valor"); }
            // else { System.Console.WriteLine($"Não encontrei o valor"); }

            // bool todosMaiorQue = operacao.TodosMaiorQue(array, valorProcurado);

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine($"todos os valores são maior que {valorProcurado}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Existe valores que nao sao maiores que {valorProcurado}");
            // }

            // bool existe = operacao.Existe(array, valorProcurado); // (arra, valor a ser buscado)
            // if (existe)
            // {
            //     System.Console.WriteLine($"Encontrei o valor {valorProcurado}.");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Valor {valorProcurado} não existente no array.");
            // }

            // System.Console.WriteLine("Array antes da cópia");
            // operacao.ImprimirArray(arrayCopia);

            // System.Console.WriteLine("Array após cópia");
            // operacao.Copiar(ref array, ref arrayCopia);
            // operacao.ImprimirArray(arrayCopia);


            // // ordenando array
            // //operacao.Ordenar(ref array);
            //  operacao.OrdenarBubbleSort(ref array);

            // System.Console.WriteLine($"Array oordenado: ");
            // operacao.ImprimirArray(array);


            // tipos arrays (linear, matriz)
            // // array multidimensional(matriz)
            // int[,] matriz = new int[4, 2]
            // {
            //         {8,8} // linha 0
            //         ,{56,5}
            //         ,{12,7}
            //         ,{25,4}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++) // getlength pega dimensao do array (0 para linhas)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++) // GetLength(1) para coluna
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30"); // converte string em int

            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // foreach (int valor in arrayInteiros)
            // {
            //     System.Console.WriteLine(valor);
            // }

        }
    }
}
