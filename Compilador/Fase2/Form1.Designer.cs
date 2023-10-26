namespace Fase2
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.compiladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCompilarTudo = new System.Windows.Forms.Button();
            this.txtCodigoFonte = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compiladorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompilarTudo);
            this.groupBox1.Controls.Add(this.txtNomeArquivo);
            this.groupBox1.Controls.Add(this.btnProcurar);
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
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(21, 19);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(108, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar Arquivo";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnCompilarTudo
            // 
            this.btnCompilarTudo.Location = new System.Drawing.Point(548, 19);
            this.btnCompilarTudo.Name = "btnCompilarTudo";
            this.btnCompilarTudo.Size = new System.Drawing.Size(103, 23);
            this.btnCompilarTudo.TabIndex = 5;
            this.btnCompilarTudo.Text = "Compilar";
            this.btnCompilarTudo.UseVisualStyleBackColor = true;
            this.btnCompilarTudo.Click += new System.EventHandler(this.btnCompilarTudo_Click);
            // 
            // txtCodigoFonte
            // 
            this.txtCodigoFonte.Location = new System.Drawing.Point(15, 72);
            this.txtCodigoFonte.Multiline = true;
            this.txtCodigoFonte.Name = "txtCodigoFonte";
            this.txtCodigoFonte.Size = new System.Drawing.Size(669, 165);
            this.txtCodigoFonte.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 308);
            this.Controls.Add(this.txtCodigoFonte);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Analisador Recursivo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compiladorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtNomeArquivo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.BindingSource compiladorBindingSource;
        private System.Windows.Forms.Button btnCompilarTudo;
        private System.Windows.Forms.TextBox txtCodigoFonte;
    }
}

