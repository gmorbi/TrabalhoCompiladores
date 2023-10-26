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
using comp = Compilador.Compilador;

namespace Fase2
{
    public partial class Form1 : Form
    {
        AnalisadorRecursivo AnalisadorRecursivo;       
        int ponteiro;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Formatação Inicial
            txtNomeArquivo.Text = "Nenhum Arquivo Selecionado";

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Arquivo de Texto (*.txt)|*.txt";
            dlg.InitialDirectory = "C:\\";
            dlg.Title = "Selecione um arquivo para ser compilado";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtNomeArquivo.Text = dlg.FileName;
                comp compilador = new comp(dlg.FileName);
                compilador.Scanning();
                if (compilador.codigoRestante.Count() > 0)
                {
                    txtCodigoFonte.Text = compilador.codigoFonte;
                }
            }
        }

        private void btnCompilarTudo_Click(object sender, EventArgs e)
        {
            AnalisadorRecursivo = new AnalisadorRecursivo(txtCodigoFonte.Text);
            AnalisadorRecursivo.prox_token();
            AnalisadorRecursivo.Programa();
            if (AnalisadorRecursivo.Token == "." && AnalisadorRecursivo.erro == 0)
            {
                MessageBox.Show("SUCESSO!");
            }
            else
            {
                MessageBox.Show("ERRO: " + AnalisadorRecursivo.message);
            }
        }
    }
}
