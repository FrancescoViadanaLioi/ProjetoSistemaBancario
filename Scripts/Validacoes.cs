using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Validations
{
    public static class ValidacoesDeDados
    {
        public static bool ValidarNome(string nome)
        {
            nome = nome.Trim();
            string padrao = @"^[A-Za-zÀ-ÖØ-öø-ÿ]+(?:[ -][A-Za-zÀ-ÖØ-öø-ÿ]+)*$";
            return !string.IsNullOrWhiteSpace(nome) && nome.Length > 1 && Regex.IsMatch(nome, padrao);
        }
        public static bool ValidarPIN(string senha)
        {
            return Regex.IsMatch(senha ?? "", @"^\d{4}$");
        }
        public static bool TryParseValorPositivo(string? input, out double valorPositivo)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out valorPositivo) && valorPositivo >= 0;
        }
        public static bool ValidarSaldoPositivo(double saldo, out double saldoValidado)
        {
            saldoValidado = saldo;
            return saldo >= 0;
        }
        public static bool ValidarSaque(double saque, out double saqueValidado)
        {
            return ValidarValorPositivo(saque, out saqueValidado);
        }
        public static bool ValidarDeposito(double deposito, out double depositoValidado)
        {
            return ValidarValorPositivo(deposito, out depositoValidado);
        }
        private static bool ValidarValorPositivo(double valor, out double valorValidado)
        {
            valorValidado = valor;
            return valor > 0;
        }
    }
}