namespace ExemploConstrutores.Models
{
    public class Calculadora
    {

        // Delegate
        public delegate void DelegateCalculadora();

        // Evento
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null) // se houver objetos isncritos neste evento ele executa
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine($"Nenhum inscrito!");
            }

        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}