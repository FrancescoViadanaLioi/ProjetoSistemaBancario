using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Validations
{
    public static class ValidacoesDeDados
    {
        public static bool ValidarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) return false;
            nome = nome.Trim();
            string padrao = @"^[A-Za-zÀ-ÖØ-öø-ÿ]+(?:[ -][A-Za-zÀ-ÖØ-öø-ÿ]+)*$";
            return nome.Length > 1 && Regex.IsMatch(nome, padrao);
        }
        public static bool ValidarPIN(string senha)
        {
            return Regex.IsMatch(senha ?? "", @"^\d{4}$");
        }
        public static bool ValidarSaque(double saque, out double saqueValidado)
        {
            saqueValidado = saque;
            return saqueValidado > 1;
        }
    }
}