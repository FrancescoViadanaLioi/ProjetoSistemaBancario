using System;

namespace UniversalResources
{
    public static class RecursosUniversais
    {
        public static string PedirEntrada(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;
                else return input;
            }
        }
    }
}