namespace ExemploPOO.Models
{
    // conta é abstrata, nao pode ser instanciada
    public abstract class Conta
    {
        protected double saldo; //obs: propria classe e classes filhas podem acessar

        public abstract void Creditar(double valor); // nao pode declarar corpo no metodo

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é: R${saldo}");
        }
    }

}