using System;

namespace Miscelania
{
    public enum TipoMensagem
    {
        Alerta,
        Erro,
        Informacao,
        Sucesso
    }
    public class Mensagem
    {
        public string Conteudo { get; }
        public TipoMensagem Tipo { get; }
        public bool EsperarTecla { get; }
        public bool LimparConsole { get; }

        public Mensagem(string conteudo, TipoMensagem tipo, bool esperarTecla, bool limparConsole)
        {
            Conteudo = conteudo;
            Tipo = tipo;
            EsperarTecla = esperarTecla;
            LimparConsole = limparConsole;
        }
    }
}