using System;
using Validations;

namespace ContaBanco.Info
{
    public class DadosBancarios
    {
        private string _nome;
        private string _pin;
        private double _saldo;

        public string Nome => _nome;
        public string PIN => _pin;
        public double Saldo => _saldo;

        public DadosBancarios(string nome, string pin, double saldo)
        {
            if (!ValidacoesDeDados.ValidarNome(nome))
            {
                throw new ArgumentException("O nome é inválido.");
            }
            if (!ValidacoesDeDados.ValidarPIN(pin))
            {
                throw new ArgumentException("O pin é inválido.");
            }
            if (!ValidacoesDeDados.ValidarSaldoPositivo(saldo, out double saldoValidado))
            {
                throw new ArgumentException("O saldo é inválido. Se você digitou números, verifique se são maiores que zero.");
            }
                _nome = nome;
                _pin = pin;
                _saldo = saldoValidado;
        }
        public void Sacar(double saque)
        {
            if (!ValidacoesDeDados.ValidarSaque(saque, out double saqueValidado))
            {
                throw new ArgumentException("Verifique se o saque é um número real maior do que 0.");
            }
            if (saque > _saldo)
            {
                throw new ArgumentException("O saque é maior do que o saldo. Operação cancelada.");
            }
            _saldo -= saque;
        }
        public void Depositar(double deposito)
        {
            if (!ValidacoesDeDados.ValidarDeposito(deposito, out double depositoValidado))
            {
                throw new ArgumentException("O depósito deve ser um número positivo.");
            }
            _saldo += deposito;
        }
    }
}