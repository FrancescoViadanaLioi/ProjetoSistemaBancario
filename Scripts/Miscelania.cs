using System;
using System.Globalization;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void Exibir(Mensagem mensagem)
        {
            string prefixo = $"{mensagem.Tipo.ToString().ToUpper()}:";
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
        public static void ExibirAlerta(string conteudo)
        {
            var msg = new Mensagem(conteudo, tipo: TipoMensagem.Alerta, esperarTecla: true, limparConsole: false);
            Exibir(msg);
        }
        public static void ExibirErro(string conteudo)
        {
            var msg = new Mensagem(conteudo, tipo: TipoMensagem.Erro, esperarTecla: true, limparConsole: true);
            Exibir(msg);
        }
        public static void ExibirSucesso(string conteudo)
        {
            var msg = new Mensagem(conteudo, tipo: TipoMensagem.Sucesso, esperarTecla: false, limparConsole: false);
            Exibir(msg);
        }
    }
}