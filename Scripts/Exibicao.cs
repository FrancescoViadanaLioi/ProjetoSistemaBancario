using System;
using System.Threading;
using System.Globalization;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void Exibir(Mensagem mensagem)
        {
            string prefixo = $"{mensagem.Tipo.ToString().ToUpper()}";
            Console.WriteLine($"{prefixo}! {mensagem.Conteudo}");

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
        public static void ExibirInformacao(string conteudo)
        {
            var msg = new Mensagem(conteudo, tipo: TipoMensagem.Informacao, esperarTecla: true, limparConsole: false);
            Exibir(msg);
        }
        public static void ExibirSucesso(string conteudo)
        {
            var msg = new Mensagem(conteudo, tipo: TipoMensagem.Sucesso, esperarTecla: false, limparConsole: false);
            Exibir(msg);
        }
        public static void ContarTempoAntesDeLimparTela()
        {
            var (left, top) = Console.GetCursorPosition();

            for (int i = 5; i > 0; i--)
            {
                Console.SetCursorPosition(left, top);
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }

            Console.SetCursorPosition(left, top);
            Console.Write("  ");
        }
    }
    public static class FormatadorNumerico
    {
        public static string Formatar(double input)
        {
            return input.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}