using System;
using Miscelania;
using ContaBanco.Info;
using ContaBanco.Input;
using UniversalResources;

class Program
{
    static void Main(string[] args)
    {
        string nome = EntradaDoUsuario.EntrarComNome();
        string pin = EntradaDoUsuario.EntrarComPIN();
        double saldo = EntradaDoUsuario.EntrarComSaldo();

        var p = new DadosBancarios(nome, pin, saldo);
        ConsoleUI.ExibirInformacao("Dados inseridos, bem vindo!");
        ConsoleUI.ContarTempoAntesDeLimparTela();
        Console.Clear();

        while (true)
        {
            MenuPrincipal.ExibirMenu();
            string input = RecursosUniversais.PedirEntrada("Qual é a opção? ");
            switch (input)
            {
                case "1":
                    Console.WriteLine($"Informações da conta:");
                    Console.WriteLine($"Nome: {p.Nome} PIN: {p.PIN}, Saldo: R${FormatadorNumerico.Formatar(p.Saldo)}");
                    ConsoleUI.ExibirInformacao("Fim da informação.");
                    Console.Clear();
                    break;

                case "2":
                    double saque = EntradaDoUsuario.EntrarComSaque();
                    p.Sacar(saque);
                    Console.WriteLine($"Seu saque foi de R${FormatadorNumerico.Formatar(saque)}.");
                    Console.WriteLine($"Seu novo saldo é de R${FormatadorNumerico.Formatar(p.Saldo)}");
                    ConsoleUI.ExibirInformacao("Fim do processo.");
                    Console.Clear();
                    break;
                case "3":
                    double deposito = EntradaDoUsuario.EntrarComDeposito();
                    p.Depositar(deposito);
                    Console.WriteLine($"Seu depósito foi de R${FormatadorNumerico.Formatar(deposito)}.");
                    Console.WriteLine($"Seu novo saldo é de R${FormatadorNumerico.Formatar(p.Saldo)}.");
                    ConsoleUI.ExibirInformacao("Fim do processo.");
                    Console.Clear();
                    break;
                case "4":
                    ConsoleUI.ExibirInformacao("Fim do programa.");
                    return;
                default:
                    ConsoleUI.ExibirErro("Comando inválido, tente de novo.");
                    break;
            }
        }
    }
}
