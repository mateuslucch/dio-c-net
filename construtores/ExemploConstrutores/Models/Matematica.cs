namespace ExemploConstrutores.Models
{
    public class Matematica
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandler; // se comentar isso, eventocalculadora nao vai ter inscritos
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Metodo executados");
        }
    }
}