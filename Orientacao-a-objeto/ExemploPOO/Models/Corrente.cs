namespace ExemploPOO.Models
{
    public class Corrente : Conta  // obs: creditar deve ser implementada
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor;
        }
    }
}