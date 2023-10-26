using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace Compilador
{
    public partial class Form1 : Form
    {
        Compilador compilador;
        bool aspas = false;
        bool novaGravacao = true;
        Dictionary<string, List<string>> dataGridDict;
        int ponteiro;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Formatação Inicial
            txtNomeArquivo.Text = "Nenhum Arquivo Selecionado";
            btnInicio.Enabled = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            novaGravacao = true;
            compilador = null;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Arquivo de Texto (*.txt)|*.txt";
            dlg.InitialDirectory = "C:\\";
            dlg.Title = "Selecione um arquivo para ser compilado";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtNomeArquivo.Text = dlg.FileName;
                btnInicio.Enabled = true;
                compilador = new Compilador(dlg.FileName);
                compilador.Scanning();

                if (compilador.codigoRestante.Count() > 0)
                {
                    txtCodigoFonte.Text = compilador.codigoFonte;
                    btnInicio.Enabled = true;
                }
            }
            dataGridDict = new Dictionary<string, List<string>>();
            dataGridDict.Add("<PLV_RES>", new List<string>());
            dataGridDict.Add("<STRING>", new List<string>());
            dataGridDict.Add("<ID>", new List<string>());
            dataGridDict.Add("<NUM_INT>", new List<string>());
            dataGridDict.Add("<NUM_REAL>", new List<string>());
            dataGridDict.Add("<OP_ARIT>", new List<string>());
            dataGridDict.Add("<OP_RELAC>", new List<string>());
            dataGridDict.Add("<SIMB_ESP>", new List<string>());
            dataGridDict.Add("<ATRIB>", new List<string>());
            dataGridDict.Add("<FIM>", new List<string>());

            dataGridView1.Columns.Add("tipoToken", "Tipo de Token");
            dataGridView1.Columns.Add("listaToken", "Tokens identificados");

            AtualizaDataGrid();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            bool fimToken = false;
            compilador.Avancar();
            AtualizaFlags();

            if (!aspas && Automato.ContemCaracterEspecial(compilador.token))
            {
                bool todosCaracteresSaoSimbolos = true;
                compilador.token.ToList().ForEach(c =>
                {
                    if (!Automato.ValidaSimboloEspecial(c) && c != ' ')
                        todosCaracteresSaoSimbolos = false;
                });
                if (!todosCaracteresSaoSimbolos)
                {
                    if (!Automato.ValidaNumeroReal(compilador.token))
                    {
                        compilador.Recuar();
                        fimToken = true;
                    }
                }
                else
                {
                    if (compilador.caracter != ':')
                        fimToken = true;
                }
                    
            }
            else if (!aspas && (!Automato.ValidaNumeroReal(compilador.token) && Automato.ContemCaracterFinal(compilador.token)))
            {
                if(!(compilador.codigoRestante.Length == 0 && compilador.token == "."))
                    compilador.Recuar();
                fimToken = true;
            }

            if (!aspas && (Automato.ValidaOperadorAritmetico(compilador.token) || Automato.ValidaFim(compilador.token)))
            {
                fimToken = true;
            }

            if ((!aspas && compilador.caracter == ' ') || fimToken)
            {
                //Fim da cadeia. Identifica qual automato identificou o token
                var regex = new Regex(Regex.Escape(compilador.token.Trim()));
                var separadorTokens = (compilador.caracter == ' ') ? " " : ""; //apenas para dar espaço quando houver sido dado espaço

                string palavraReservada;
                if (Automato.ValidaPalavraReservada(compilador.token, out palavraReservada) && palavraReservada == compilador.token.Trim().ToUpper())
                {
                    var token = "<PLV_RES>";
                    txtCodigoFonte.Text = regex.Replace(txtCodigoFonte.Text, token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (compilador.token.LastOrDefault() == '"' && Automato.ValidaString(compilador.token))
                {
                    var token = "<STRING>";
                    txtCodigoFonte.Text = regex.Replace(txtCodigoFonte.Text, token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaIdentificador(compilador.token))
                {
                    var token = "<ID>";
                    txtCodigoFonte.Text = regex.Replace(txtCodigoFonte.Text, token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaNumeroInteiro(compilador.token))
                {
                    var token = "<NUM_INT>";
                    txtCodigoFonte.Text = regex.Replace(txtCodigoFonte.Text, token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaNumeroReal(compilador.token))
                {
                    var token = "<NUM_REAL>";
                    txtCodigoFonte.Text = regex.Replace(txtCodigoFonte.Text, token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaAtribuicao(compilador.token))
                {
                    var token = "<ATRIB>";
                    txtCodigoFonte.Text = regex.Replace(txtCodigoFonte.Text, token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaOperadorRelacional(compilador.token.Trim()))
                {
                    var token = "<OP_RELAC>";
                    txtCodigoFonte.Text = txtCodigoFonte.Text.Substring(0, ponteiro) +
                    regex.Replace(txtCodigoFonte.Text.Substring(ponteiro), token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaOperadorAritmetico(compilador.token.Trim()))
                {
                    var token = "<OP_ARIT>";
                    txtCodigoFonte.Text = txtCodigoFonte.Text.Substring(0, ponteiro) +
                    regex.Replace(txtCodigoFonte.Text.Substring(ponteiro), token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaFim(compilador.token))
                {
                    var token = "<FIM>";
                    txtCodigoFonte.Text = txtCodigoFonte.Text.Substring(0, ponteiro) +
                    regex.Replace(txtCodigoFonte.Text.Substring(ponteiro), token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }
                else if (Automato.ValidaSimboloEspecial(compilador.token.Trim().FirstOrDefault()))
                {
                    //Ultimo caso
                    var token = "<SIMB_ESP>";
                    txtCodigoFonte.Text = regex.Replace(txtCodigoFonte.Text, token + separadorTokens, 1);
                    dataGridDict[token].Add(compilador.token);
                    ponteiro += txtCodigoFonte.Text.Substring(ponteiro).IndexOf(token) + token.Length;
                }

                AtualizaDataGrid();
                if(!string.IsNullOrEmpty(compilador.token))
                    compilador.ultimoToken = compilador.token;
                compilador.token = "";
            }
            else
            {
                if (!string.IsNullOrEmpty(compilador.token) && compilador.token.Length > 0)
                {
                    if (compilador.caracter == '"')
                    {
                        if (aspas)
                            aspas = false;
                        else
                            aspas = true;
                    }
                    txtCodigoFonte.SelectionStart = ponteiro + txtCodigoFonte.Text.Substring(ponteiro).IndexOf(compilador.token);
                    txtCodigoFonte.SelectionLength = compilador.token.Length;
                    txtCodigoFonte.Focus();
                }
                else
                {
                    //Fim do Arquivo
                    MessageBox.Show("Fim da compilação. Salvando arquivo.");
                    System.IO.StreamWriter file = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\" + "resultado.txt");
                    string texto = "";
                    dataGridDict.Keys.ToList().ForEach(k =>
                    {
                        texto += string.Format("{0} ::= {1}\r\n", k, string.Join(" | ", dataGridDict[k].GroupBy(token => token).Select(k2 => k2.First().Trim())));
                    });
                    file.WriteLine(texto);
                    file.Close();
                    MessageBox.Show(string.Format("Arquivo de Saída salvo em {0}", AppDomain.CurrentDomain.BaseDirectory));
                    btnProximo.Enabled = false;
                    btnCompilarTudo.Enabled = false;
                }
            }

            if ((string.IsNullOrEmpty(compilador.token) && compilador.codigoRestante.Length == 0) && novaGravacao)
            {
                //Fim do Arquivo
                MessageBox.Show("Fim da compilação. Salvando arquivo.");
                System.IO.StreamWriter file = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\" + string.Format("resultado_{0}.txt", DateTime.Now.ToString("yyyyMMddHHmmss")));
                string texto = "";
                dataGridDict.Keys.ToList().ForEach(k =>
                {
                    texto += string.Format("{0} ::= {1}\r\n", k, string.Join(" | ", dataGridDict[k].GroupBy(token => token).Select(k2 => k2.First().Trim())));
                });
                file.WriteLine(texto);
                file.Close();
                MessageBox.Show(string.Format("Arquivo de Saída salvo em {0}", AppDomain.CurrentDomain.BaseDirectory));
                btnProximo.Enabled = false;
                btnCompilarTudo.Enabled = false;
                novaGravacao = false;
            }

            lblCadeia.Text = compilador.caracter.ToString();
            lblCadeiaFormada.Text = compilador.token;
            progressBar.Value = progressBar.Maximum - compilador.codigoRestante.Length;
        }

        private void AtualizaFlags()
        {
            if (Automato.ValidaPalavraReservada(compilador.token))
                flagPalavra.BackColor = Color.Green;
            else
                flagPalavra.BackColor = Color.Red;

            if (Automato.ValidaString(compilador.token))
                flagString.BackColor = Color.Green;
            else
                flagString.BackColor = Color.Red;

            if (Automato.ValidaIdentificador(compilador.token))
                flagId.BackColor = Color.Green;
            else
                flagId.BackColor = Color.Red;

            if (Automato.ValidaNumeroInteiro(compilador.token))
                flagInt.BackColor = Color.Green;
            else
                flagInt.BackColor = Color.Red;

            if (Automato.ValidaNumeroReal(compilador.token))
                flagReal.BackColor = Color.Green;
            else
                flagReal.BackColor = Color.Red;

            if (Automato.ValidaOperadorAritmetico(compilador.token))
                flagOpArit.BackColor = Color.Green;
            else
                flagOpArit.BackColor = Color.Red;

            if (Automato.ValidaOperadorRelacional(compilador.token))
                flagOpRelac.BackColor = Color.Green;
            else
                flagOpRelac.BackColor = Color.Red;

            if (Automato.ContemCaracterEspecial(compilador.token))
                flagSimbEsp.BackColor = Color.Green;
            else
                flagSimbEsp.BackColor = Color.Red;

            if (Automato.ValidaAtribuicao(compilador.token))
                flagAtrib.BackColor = Color.Green;
            else
                flagAtrib.BackColor = Color.Red;

            if (Automato.ValidaFim(compilador.token))
                flagFim.BackColor = Color.Green;
            else
                flagFim.BackColor = Color.Red;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            btnInicio.Enabled = false;
            btnProximo.Enabled = true;
            btnProximo.Focus();
            btnCompilarTudo.Enabled = true;
            progressBar.Maximum = compilador.codigoRestante.Length;
            ponteiro = 0;
            btnProximo_Click(sender, e);
        }

        private void AtualizaDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridDict.Keys.ToList().ForEach(k =>
            {
                dataGridView1.Rows.Add(new Object[] { k, string.Join(" ", dataGridDict[k]) });
            });
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Update();
        }

        public static string ReplaceLastOccurrence(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }

        private void btnCompilarTudo_Click(object sender, EventArgs e)
        {
            while (compilador.codigoRestante.Length > 0)
            {
                btnProximo_Click(sender, e);
            }
            btnProximo_Click(sender, e);
        }
    }
}
