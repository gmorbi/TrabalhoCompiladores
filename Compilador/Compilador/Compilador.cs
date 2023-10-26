using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compilador
{
    public class Compilador
    {
        public string caminhoArquivo;
        public string codigoFonte;
        public string codigoRestante;
        public string token;
        public char caracter;
        public string ultimoToken;

        public Compilador(string nomeArquivo)
        {
            caminhoArquivo = nomeArquivo;
            codigoFonte = System.IO.File.ReadAllText(nomeArquivo);
            codigoRestante = System.IO.File.ReadAllText(nomeArquivo);
        }
        public void Scanning()
        {
            //Remove espaço
            codigoRestante = codigoRestante.Replace("\r", " ").Replace("\n", " ").Replace("  ", " ");
            //Remove comentários
            var inicioComentario = codigoRestante.IndexOf(@"/*");
            var fimComentario = codigoRestante.IndexOf(@"*/");

            if (inicioComentario >= 0)
                if (fimComentario >= 0)
                {
                    while (inicioComentario >= 0 && fimComentario >= 0)
                    {
                        codigoRestante = codigoRestante.Remove(inicioComentario, (fimComentario - inicioComentario + 2));
                        codigoFonte = codigoFonte.Remove(codigoFonte.IndexOf(@"/*"), (codigoFonte.IndexOf(@"*/") - codigoFonte.IndexOf(@"/*") + 2));
                        codigoFonte = codigoFonte.Replace("\r\n\r\n", "\r\n");

                        inicioComentario = codigoRestante.IndexOf(@"/*");
                        fimComentario = codigoRestante.IndexOf(@"*/");
                    }
                }
                else
                {
                    codigoRestante = codigoRestante.Remove(inicioComentario);
                    codigoFonte = codigoFonte.Remove(inicioComentario);
                }
            else
                throw new Exception("Abertura de Comentário Faltando. Fechamento detectado");
        }
        public bool Avancar()
        {
            if (codigoRestante.Length > 0)
            {
                caracter = codigoRestante.FirstOrDefault();
                codigoRestante = codigoRestante.Substring(1);
                token = token + caracter;
                return true;
            }
            return false;
        }

        public bool Recuar()
        {
            if (codigoRestante.Length >= 0)
            {
                if (token.Length == 1)
                    return true;
                codigoRestante = caracter + codigoRestante;
                caracter = token.Substring(1, token.Length-2).LastOrDefault();
                token = token.Substring(0, token.Length-1);
                return true;
            }
            return false;
        }
    }

    public class TabelaSimbolo
    {

    }

    public class Token
    {
    }
}
