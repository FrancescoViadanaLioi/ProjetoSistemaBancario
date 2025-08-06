using System;
using Validations;
using Miscelania;
using UniversalResources;
using System.Diagnostics;

namespace ContaBanco.Input
{
    public static class EntradaDoUsuario
    {
        public static string EntrarComNome()
        {
            while (true)
            {
                string input = RecursosUniversais.PedirEntrada("Digite o seu nome: ");
                if (ValidacoesDeDados.ValidarNome(input)) return input;
                ConsoleUI.ExibirErro("Verifique se o nome tem somente letras e mais de um caracter.");
            }
        }
        public static string EntrarComPIN()
        {
            while (true)
            {
                string input = RecursosUniversais.PedirEntrada("Digite o PIN de 4 dígitos: ");
                if (input != null && ValidacoesDeDados.ValidarPIN(input)) return input;
                ConsoleUI.ExibirErro("Verifique se o PIN não ultrapassa e nem tem menos do que 4 dígitos.");
            }
        }
        public static double EntrarComSaldo()
        {
            while (true)
            {
                string input = RecursosUniversais.PedirEntrada("Qual será o saldo inicial? R$");
                if (input != null && ValidacoesDeDados.TryParseValorPositivo(input, out double saldo)) return saldo;
                ConsoleUI.ExibirErro("Verifique se o número é positivo, um saldo inicial negativo não é possível.");
            }
        }
        public static double EntrarComSaque()
        {
            while (true)
            {
                string input = RecursosUniversais.PedirEntrada("Quanto você quer Sacar? R$");
                if (input != null && ValidacoesDeDados.TryParseValorPositivo(input, out double saque)) return saque;
                ConsoleUI.ExibirErro("O saque deve ser um número real positivo.");
            }
        }
        public static double EntrarComDeposito()
        {
            while (true)
            {
                string input = RecursosUniversais.PedirEntrada("Quanto você vai depositar? R$");
                if (input != null && ValidacoesDeDados.TryParseValorPositivo(input, out double deposito)) return deposito;
                ConsoleUI.ExibirErro("O depósito deve ser um número real positivo.");
            }
        }
    }
}