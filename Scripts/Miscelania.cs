using System;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void Exibir(Mensagem mensagem)
        {
            string prefixo = $"{mensagem.Tipo.ToString().ToUpper()}: ";
            Console.WriteLine($"{prefixo} {mensagem.Conteudo}");

            if (mensagem.EsperarTecla)
            {
                Console.WriteLine("(Pressione qualquer tecla para continuar)");
                Console.ReadKey();
            }
            if (mensagem.LimparConsole)
            {
                Console.Clear();
            }
        }
    }
}