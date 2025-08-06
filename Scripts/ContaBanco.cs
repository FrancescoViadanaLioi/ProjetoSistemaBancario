using Miscelania;
using System;
using Validations;
namespace ContaBanco.Info
{
    public class DadosBancarios
    {
        private string _nome = "";
        private string _pin = "";
        private double _saldo = 0;
        public string Nome => _nome;
        public string PIN => _pin;
        public double Saldo => _saldo;
        public DadosBancarios(string nome, string pin, double saldo)
        {
            if (!ValidacoesDeDados.ValidarNome(nome))
            {
                ConsoleUI.ExibirErro("O nome é inválido.");
                return;
            }
            if (!ValidacoesDeDados.ValidarPIN(pin))
            {
                ConsoleUI.ExibirErro("O pin é inválido.");
                return;
            }
            if (!ValidacoesDeDados.ValidarSaldoPositivo(saldo, out double saldoValidado))
            {
                ConsoleUI.ExibirErro("O saldo é inválido. Se você digitou números, verifique se são maiores que zero.");
                return;
            }
            _nome = nome;
            _pin = pin;
            _saldo = saldoValidado;
        }
        public void Sacar(double saque)
        {
            if (!ValidacoesDeDados.ValidarSaque(saque, out double saqueValidado))
            {
                ConsoleUI.ExibirErro("Verifique se o saque é um número real maior do que 0.");
                return;
            }
            if (saque > _saldo)
            {
                ConsoleUI.ExibirErro("O saque não pode ser maior do que o saldo.");
                return;
            }
            _saldo -= saque;
        }
        public void Depositar(double deposito)
        {
            if (!ValidacoesDeDados.ValidarDeposito(deposito, out double depositoValidado))
            {
                ConsoleUI.ExibirErro("O depósito deve ser um número positivo.");
                return;
            }
            _saldo += deposito;
        }
    }
}