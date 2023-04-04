using System;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var listaString = new List<string> { "linha 1", "linha 2", "linha 3" };
            var listaStringContinuacao = new List<string> { "linha 4", "linha 5", "linha 6" };
            var novoCaminhoArquivo = Path.Combine(caminho, "Teste 2" ,"arquivo-teste-stream.txt");

            FileHelper fr = new FileHelper();

            //fr.ListarDiretorios(caminho);
            //fr.ListarArquivosDiretorios(caminho);
            //fr.criarDiretorio(caminhoPathCombine);
            //fr.apagarDiretorio(caminhoPathCombine, true);
            //fr.criarAquivoTexto(caminhoArquivo, "Olá teste de escrita de arquivo!");
            //fr.criarAquivoTextoStream(caminhoArquivo, listaString);
            //fr.criarAquivoTextoStream(caminhoArquivo, listaString);
            //fr.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //fr.lerArquivoStream(caminhoArquivo);
            //fr.moverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //fr.copiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            fr.deletarArquivo(caminhoArquivoTesteCopia);
        }
    }
}