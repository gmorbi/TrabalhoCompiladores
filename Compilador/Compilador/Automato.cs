using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Compilador
{
    public class Automato
    {
        public static bool ValidaPalavraReservada(string comando)
        {
            string palavraReservada;
            return ValidaPalavraReservada(comando, out palavraReservada);
        }
        public static bool ValidaPalavraReservada(string comando, out string palavraReservada)
        {
            palavraReservada = null;
            if (string.IsNullOrEmpty(comando.Trim().ToUpper()))
                return false;

            string[] palavrasReservadas = RetornaListaPalavrasReservadas();

            List<string> retorno = new List<string>();

            palavrasReservadas.ToList().ForEach(pR =>
            {
                if (pR.StartsWith(comando.Trim().ToUpper()))
                    retorno.Add(pR);
            });

            palavraReservada = retorno.FirstOrDefault();
            if (retorno.Count() > 0)
                return true;
            return false;
        }
        public static bool ValidaIdentificador(string comando)
        {
            string[] primeirosCaracteresValidos = new string[]{
                "A", "B", "C", "D", "E", "F", 
                "G", "H", "I", "J", "K", "L", 
                "M", "N", "O", "P", "Q", "R", 
                "S", "T", "U", "V", "W", "X", 
                "Y", "Z", "_"
            };

            List<string> retorno = new List<string>();
            var primeiroCaracter = comando.FirstOrDefault().ToString().ToUpper();

            float output;

            return !RetornaListaPalavrasReservadas().Contains(comando.Trim().ToUpper()) && 
                !float.TryParse(primeiroCaracter, out output) &&
                primeirosCaracteresValidos.Contains(primeiroCaracter) &&
                (!ContemCaracterEspecial(comando))
                ;
        }
        public static bool ValidaNumeroInteiro(string comando)
        {
            char[] numeros = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            foreach(char carater in comando)
            {
                if (!numeros.Contains(carater))
                    return false;
            }
            return true;
            
        }
        public static bool ValidaNumeroReal(string comando)
        {
            float numeroRealValido;
            if(float.TryParse(comando, out numeroRealValido))
                return true;
            return false;
        }
        public static bool ValidaOperadorAritmetico(string comando){
            char[] operadores = RetornaOperadoresAritmeticos();

            if (string.IsNullOrEmpty(comando))
                return false;

            foreach (char carater in comando)
            {
                if (!operadores.Contains(carater))
                    return false;
            }
            return true;
        }

        public static char[] RetornaOperadoresAritmeticos()
        {
            char[] operadores = new char[] { '/', '*', '-', '+' };

            return operadores;
        }
        public static bool ValidaOperadorRelacional(string comando)
        {
            string[] operadores = new string[] { "=", ">=", ">", "<", "<=", "<>"};
            foreach (string operador in operadores)
            {
                if (operador == comando)
                    return true;
            }
            return false;
        }
        public static bool ValidaSimboloEspecial(char caracter)
        {
            char[] caracteresEspeciais = RetornaCaracteresEspeciais();

            return caracteresEspeciais.Where(cE => cE == caracter).Count() > 0;
        }
        public static bool ValidaAtribuicao(string comando)
        {
            if (comando == ":=")
                return true;
            return false;
        }
        public static bool ValidaFim(string comando)
        {
            if (comando == ".")
                return true;
            return false;
        }

        public static bool ContemCaracterEspecial(string comando)
        {
            char[] caracteresEspeciais = RetornaCaracteresEspeciais();

            bool retorno = false;
            caracteresEspeciais.ToList().ForEach(c =>
                {
                    if (comando.Contains(c))
                        retorno = true;
                });

            return retorno;
        }

        public static bool ContemOperadorAritmetico(string comando)
        {
            char[] operadores = RetornaOperadoresAritmeticos();

            bool retorno = false;
            operadores.ToList().ForEach(c =>
            {
                if (comando.Contains(c))
                    retorno = true;
            });

            return retorno;
        }

        public static bool ContemCaracterFinal(string comando)
        {
            char caracterFinal = '.';
            if (comando.Contains(caracterFinal))
                    return true;
                return false;
        }

        public static string[] RetornaListaPalavrasReservadas()
        {
            string[] palavrasReservadas = new string[]{
            "ABSOLUTE", "ARRAY", "BEGIN", "CASE", "CHAR", "CONST", "DIV", "DO", "DOWTO", "ELSE", "END", "EXTERNAL",
            "FILE", "FOR", "FORWARD", "FUNC", "FUNCTION", "GOTO", "IF", "IMPLEMENTATION", "IN",
            "INTEGER", "INTERFACE", "INTERRUPT", "LABEL", "MAIN", "NIL", "NIT", "OF", "PACKED", "PROC",
            "PROGRAM", "REAL", "RECORD", "REPEAT", "SET", "SHL", "SHR", "STRING", "THEN", "TO", "TYPE", "UNIT",
            "UNTIL", "USES", "VAR", "WHILE", "WITH", "XOR"
            };
            return palavrasReservadas;
        }

        public static char[] RetornaCaracteresEspeciais()
        {
            char[] caracteresEspeciais = new char[]{
                    '=', '(', ')', ',', ';', ':'
                };

            return caracteresEspeciais;
        }

        public static bool ValidaString(string comando)
        {
            Regex regraString = new Regex(@""".*[""]?");
            if(regraString.IsMatch(comando))
                return true;
            return false; 
        }
    }
}
