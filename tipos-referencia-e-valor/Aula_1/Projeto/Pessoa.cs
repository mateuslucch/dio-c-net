namespace Projeto
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }

        // ja passa os valores quando uma Pessoa é atribuida a outra 
        public Pessoa Clone()
        {
            return new Pessoa()
            {
                Nome = this.Nome,
                Idade = this.Idade,
                Documento = this.Documento
            };
        }
    }
}