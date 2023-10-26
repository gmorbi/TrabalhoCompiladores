namespace Compilador
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeArquivo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCadeia = new System.Windows.Forms.Label();
            this.lblCadeiaFormada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompilarTudo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compiladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodigoFonte = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.flagString = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flagFim = new System.Windows.Forms.TextBox();
            this.flagAtrib = new System.Windows.Forms.TextBox();
            this.flagSimbEsp = new System.Windows.Forms.TextBox();
            this.flagOpRelac = new System.Windows.Forms.TextBox();
            this.flagOpArit = new System.Windows.Forms.TextBox();
            this.flagReal = new System.Windows.Forms.TextBox();
            this.flagInt = new System.Windows.Forms.TextBox();
            this.flagId = new System.Windows.Forms.TextBox();
            this.flagPalavra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compiladorBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeArquivo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importação";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.AutoSize = true;
            this.txtNomeArquivo.Location = new System.Drawing.Point(148, 24);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(148, 13);
            this.txtNomeArquivo.TabIndex = 2;
            this.txtNomeArquivo.Text = "Nenhum Arquivo Selecionado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Procurar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 89);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(669, 23);
            this.progressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Progresso";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCadeia);
            this.groupBox2.Controls.Add(this.lblCadeiaFormada);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCompilarTudo);
            this.groupBox2.Controls.Add(this.btnProximo);
            this.groupBox2.Controls.Add(this.btnAnterior);
            this.groupBox2.Controls.Add(this.btnInicio);
            this.groupBox2.Location = new System.Drawing.Point(15, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linha do Tempo";
            // 
            // lblCadeia
            // 
            this.lblCadeia.AutoSize = true;
            this.lblCadeia.Location = new System.Drawing.Point(118, 26);
            this.lblCadeia.Name = "lblCadeia";
            this.lblCadeia.Size = new System.Drawing.Size(0, 13);
            this.lblCadeia.TabIndex = 10;
            // 
            // lblCadeiaFormada
            // 
            this.lblCadeiaFormada.AutoSize = true;
            this.lblCadeiaFormada.Location = new System.Drawing.Point(322, 26);
            this.lblCadeiaFormada.Name = "lblCadeiaFormada";
            this.lblCadeiaFormada.Size = new System.Drawing.Size(0, 13);
            this.lblCadeiaFormada.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cadeia Formada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caracter:";
            // 
            // btnCompilarTudo
            // 
            this.btnCompilarTudo.Enabled = false;
            this.btnCompilarTudo.Location = new System.Drawing.Point(554, 49);
            this.btnCompilarTudo.Name = "btnCompilarTudo";
            this.btnCompilarTudo.Size = new System.Drawing.Size(103, 23);
            this.btnCompilarTudo.TabIndex = 4;
            this.btnCompilarTudo.Text = "Compilar Tudo";
            this.btnCompilarTudo.UseVisualStyleBackColor = true;
            this.btnCompilarTudo.Click += new System.EventHandler(this.btnCompilarTudo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Enabled = false;
            this.btnProximo.Location = new System.Drawing.Point(322, 49);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Próximo >";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(241, 49);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Enabled = false;
            this.btnInicio.Location = new System.Drawing.Point(15, 49);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(15, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(669, 186);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabela de Símbolos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCodigoFonte
            // 
            this.txtCodigoFonte.Location = new System.Drawing.Point(15, 119);
            this.txtCodigoFonte.Name = "txtCodigoFonte";
            this.txtCodigoFonte.ReadOnly = true;
            this.txtCodigoFonte.Size = new System.Drawing.Size(669, 134);
            this.txtCodigoFonte.TabIndex = 5;
            this.txtCodigoFonte.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.flagString);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.flagFim);
            this.groupBox4.Controls.Add(this.flagAtrib);
            this.groupBox4.Controls.Add(this.flagSimbEsp);
            this.groupBox4.Controls.Add(this.flagOpRelac);
            this.groupBox4.Controls.Add(this.flagOpArit);
            this.groupBox4.Controls.Add(this.flagReal);
            this.groupBox4.Controls.Add(this.flagInt);
            this.groupBox4.Controls.Add(this.flagId);
            this.groupBox4.Controls.Add(this.flagPalavra);
            this.groupBox4.Location = new System.Drawing.Point(15, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(669, 74);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Autômatos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "STRING";
            // 
            // flagString
            // 
            this.flagString.Enabled = false;
            this.flagString.Location = new System.Drawing.Point(79, 43);
            this.flagString.Name = "flagString";
            this.flagString.Size = new System.Drawing.Size(40, 20);
            this.flagString.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(608, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "FIM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "ATRIB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "SIMB_ESP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "OP_RELAC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "OP_ARIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "NUM_REAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "NUM_INT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "PLV_ESP";
            // 
            // flagFim
            // 
            this.flagFim.Enabled = false;
            this.flagFim.Location = new System.Drawing.Point(601, 43);
            this.flagFim.Name = "flagFim";
            this.flagFim.Size = new System.Drawing.Size(40, 20);
            this.flagFim.TabIndex = 8;
            // 
            // flagAtrib
            // 
            this.flagAtrib.Enabled = false;
            this.flagAtrib.Location = new System.Drawing.Point(536, 43);
            this.flagAtrib.Name = "flagAtrib";
            this.flagAtrib.Size = new System.Drawing.Size(40, 20);
            this.flagAtrib.TabIndex = 7;
            // 
            // flagSimbEsp
            // 
            this.flagSimbEsp.Enabled = false;
            this.flagSimbEsp.Location = new System.Drawing.Point(471, 43);
            this.flagSimbEsp.Name = "flagSimbEsp";
            this.flagSimbEsp.Size = new System.Drawing.Size(40, 20);
            this.flagSimbEsp.TabIndex = 6;
            // 
            // flagOpRelac
            // 
            this.flagOpRelac.Enabled = false;
            this.flagOpRelac.Location = new System.Drawing.Point(406, 43);
            this.flagOpRelac.Name = "flagOpRelac";
            this.flagOpRelac.Size = new System.Drawing.Size(40, 20);
            this.flagOpRelac.TabIndex = 5;
            // 
            // flagOpArit
            // 
            this.flagOpArit.Enabled = false;
            this.flagOpArit.Location = new System.Drawing.Point(339, 43);
            this.flagOpArit.Name = "flagOpArit";
            this.flagOpArit.Size = new System.Drawing.Size(40, 20);
            this.flagOpArit.TabIndex = 4;
            // 
            // flagReal
            // 
            this.flagReal.Enabled = false;
            this.flagReal.Location = new System.Drawing.Point(274, 43);
            this.flagReal.Name = "flagReal";
            this.flagReal.Size = new System.Drawing.Size(40, 20);
            this.flagReal.TabIndex = 3;
            // 
            // flagInt
            // 
            this.flagInt.Enabled = false;
            this.flagInt.Location = new System.Drawing.Point(209, 43);
            this.flagInt.Name = "flagInt";
            this.flagInt.Size = new System.Drawing.Size(40, 20);
            this.flagInt.TabIndex = 2;
            // 
            // flagId
            // 
            this.flagId.Enabled = false;
            this.flagId.Location = new System.Drawing.Point(144, 43);
            this.flagId.Name = "flagId";
            this.flagId.Size = new System.Drawing.Size(40, 20);
            this.flagId.TabIndex = 1;
            // 
            // flagPalavra
            // 
            this.flagPalavra.Enabled = false;
            this.flagPalavra.Location = new System.Drawing.Point(14, 43);
            this.flagPalavra.Name = "flagPalavra";
            this.flagPalavra.Size = new System.Drawing.Size(40, 20);
            this.flagPalavra.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 631);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtCodigoFonte);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Analisador Léxico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compiladorBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtNomeArquivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCompilarTudo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource compiladorBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCadeiaFormada;
        private System.Windows.Forms.Label lblCadeia;
        private System.Windows.Forms.RichTextBox txtCodigoFonte;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox flagAtrib;
        private System.Windows.Forms.TextBox flagSimbEsp;
        private System.Windows.Forms.TextBox flagOpRelac;
        private System.Windows.Forms.TextBox flagOpArit;
        private System.Windows.Forms.TextBox flagReal;
        private System.Windows.Forms.TextBox flagInt;
        private System.Windows.Forms.TextBox flagId;
        private System.Windows.Forms.TextBox flagPalavra;
        private System.Windows.Forms.TextBox flagFim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flagString;
        private System.Windows.Forms.Label label13;
    }
}

