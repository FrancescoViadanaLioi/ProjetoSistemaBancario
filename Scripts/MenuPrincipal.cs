using System;
using Miscelania;

namespace Miscelania
{
    public static class MenuPrincipal
    {
        public static void ExibirMenu()
        {
            ExibirCabecalho();
            ExibirOpcoes();
        }
        private static void ExibirCabecalho()
        {
            ColocarTracinhos();
            Console.Write("MENU PRINCIPAL");
            ColocarTracinhos();
            Console.WriteLine();
        }
        private static void ExibirOpcoes()
        {
            Console.WriteLine("1 - Exibir informações da conta");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Depositar");
            Console.WriteLine("4 - Sair");
        }
        private static void ColocarTracinhos()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Write("-");
            }
        }
    }
}