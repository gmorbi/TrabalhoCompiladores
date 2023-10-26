using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fase2
{
    #region Gramatica
    /*
     * S -> PROGRAM I; B
     * B -> D BEGIN C END
     * D -> VAR L:T;
     * I -> LN
     * N -> 0|1
     * L -> a|b
     * T -> INTEGER|STRING
     * C -> L := N;|READ(L);
     */
    #endregion
    class AnalisadorRecursivo
    {
        public String Texto;
        public String Token;
        public int erro = 0;
        private int indice = 0;
        public String message = "";

        public AnalisadorRecursivo(String Codigo)
        {
            Texto = Codigo;
            erro = 0;
            indice = 0;
            message = message + "\n" +"";
        }
        public void prox_token()
        {           
            String[] tokens = Regex.Matches(Texto, @"\p{L}+|;|:=|\(|\)|\.|\d|:").Cast<Match>().Select(m => m.Value).ToArray();
            Token = tokens[indice];
            indice++;
        }
        public void Programa()
        {
            if (Token.ToUpper()=="PROGRAM")
            {
                prox_token();
                Identificador();
                prox_token();
                Bloco();
                prox_token();
                if (!(Token=="."))
                {
                    erro ++;
                    message = message + "\n" +". esperado, encontrado " + Token;
                }
            }
        }
        public void Identificador()
        {

            Letra();
            if (!(Token ==";"))
                Numero();
        }
        public void Letra()
        {
            if ((Token=="a") || (Token == "b"))
            {
                prox_token();
            }
            else
            {
                erro ++;
                message = message + "\n" +"a ou b esperado, encontrado " + Token;
            }
        }
        public void Numero()
        {
            if ((Token=="0") || (Token=="1"))
            {
                prox_token();
            }else
            {
                erro ++;
                message = message + "\n" +"0 ou 1 esperado, encontrado " + Token;
            }
        }
        public void Bloco()
        {
            Declaracao();
            if (Token.ToUpper() == "BEGIN")
            {
                prox_token();
                Comando();
                prox_token();
                if (!(Token.ToUpper() =="END"))
                {
                    erro ++;
                    message = message + "\n" +"END esperado, encontrado " + Token;
                }
            }
        }
        public void Declaracao()
        {
            if (Token.ToUpper()=="VAR")
            {
                prox_token();
                Letra();
                if (!(Token == ":"))
                    Numero();
                if (Token == ":")
                {
                    prox_token();
                    Tipo();
                    if (!(Token==";"))
                    {
                        erro ++;
                        message = message + "\n" +"; esperado, encontrado " + Token;
                    }
                    prox_token();
                    Declaracao();
                }
            }
            
        }
        public void Comando()
        {
            if (Token.ToUpper() == "READ")
            {
                prox_token();
                if (Token == "(")
                {
                    prox_token();
                    Letra();
                    if (!(Token == ")"))
                    {
                        erro ++;
                        message = message + "\n" +") esperado, encontrado " + Token;
                    }
                    else
                    {
                        prox_token();
                        if (!(Token == ";"))
                        {
                            erro ++;
                            message = message + "\n" +"; esperado, encontrado " + Token;
                        }
                    }

                }
            }
                else
                {
                    Letra();
                    if (Token == ":=")
                    {
                        prox_token();
                        Numero();
                        if (!(Token == ";"))
                        {
                            erro ++;
                            message = message + "\n" +"; esperado, encontrado " + Token;
                        }
                    }
                }
        }
        public void Tipo()
        {
            if ((Token.ToUpper()=="INTEGER") || (Token.ToUpper()=="STRING")){
                prox_token();
            }else
            {
                erro ++;
                message = message + "\n" +"INTEGER ou STRING esperado, encontrado " + Token;
            }
        }
    }
}
