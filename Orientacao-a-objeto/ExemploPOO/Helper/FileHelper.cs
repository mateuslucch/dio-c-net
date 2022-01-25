namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            string[] retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            string[] retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories); //(caminho, tipo/extensão(*=todos, *.txt=todos txt...), forma de busca)

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }

        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);

        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            //WriteAllText cria arquivo com conteudo, sobrescreve existente se nao tiver condicional
            if (File.Exists(caminho))
            {
                System.Console.WriteLine("Arquivo existente!");
                return;
            }
            File.WriteAllText(caminho, conteudo); //caminho = caminho+nomearquivo
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho)) // com "using", quando termina, stream é removida da memoria
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo); // adiciona conteudo no final do arquivo, se nao existir, cria arquivo novo

        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho)) // equivalente, mas com stream
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        //LEITURA ARQUIVO:        
        // CARREGA TODO CONTEUDO NA MEMORIA
        public void LerArquivo(string caminho)
        {
            string[] conteudo = File.ReadAllLines(caminho); // retorna array de strings

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        //NÃO CARREGA TODO CONTEUDO NA MEMORIA - RECOMENDAVEL
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        //mover copiar e apagar arquivo

        public void MoverArquivo(string caminho, string destino, bool sobrescrever)
        {
            File.Move(caminho, destino, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string destino, bool sobrescrever)
        {
            File.Copy(caminho, destino, sobrescrever); // faz copia de arquivo, nao substitui existente (usar sobrecarga de sobrescrever (caminho,destino,overwrite=true))
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

    }
}