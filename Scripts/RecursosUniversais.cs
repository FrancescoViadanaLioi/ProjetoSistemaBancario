using System;

namespace UniversalResources
{
    public static class RecursosUniversais
    {
        public static string PedirEntrada(string msg)
        { 
                Console.Write(msg);
                string? input = Console.ReadLine();
                return input!;
        }
    }
}