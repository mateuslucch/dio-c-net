using ExemploConstrutores.Models;

namespace ExemploConstrutores // Note: actual namespace depends on the project name.
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {

            Matematica m = new Matematica(10, 20);
            m.Somar();

            // // delegate
            // Operacao op = new Operacao(Calculadora.Somar); // alternativa: Operacao op = Calculadora.Somar;
            // op += Calculadora.Subtrair; // adicionando mais um metodo a op 
            // op.Invoke(1, 2); // alternativa: op(1, 2);
            // // vai chamar somar, depois subtrair

            // Pessoa p2 = new Pessoa("Mateus", "Lucchese"); // vai chamar 1º construtor sem parametros            
            // p2.Apresentar();

            // Log log = Log.GetInstance(); // instanciar usando a instancia padrão para construtor privado

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog); // vai retornar mesmo valor de log, usando mesma instancia

            // Aluno p1 =  new Aluno("Mateus", "Lucchese", "Teste");
            // p1.Apresentar();

            // //get-set
            // Data data = new Data();
            // // data.SetMes(13);
            // // data.ApresentarMes();

            // //propriedade
            // data.Mes = 2;
            // System.Console.WriteLine(data.Mes);
            // data.ApresentarMes();
        }
    }
}