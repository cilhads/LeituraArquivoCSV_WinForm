namespace Teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofUpload = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnOperacoes = new System.Windows.Forms.Button();
            this.btnUploadArquivoDados = new System.Windows.Forms.Button();
            this.txtOperacoes = new System.Windows.Forms.TextBox();
            this.txtDadosMercado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sDownload = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofUpload
            // 
            this.ofUpload.FileName = "openFileDialog1";
            this.ofUpload.Filter = "Arquivos do Excel|*.csv";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 185);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportar);
            this.panel1.Controls.Add(this.btnOperacoes);
            this.panel1.Controls.Add(this.btnUploadArquivoDados);
            this.panel1.Controls.Add(this.txtOperacoes);
            this.panel1.Controls.Add(this.txtDadosMercado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 185);
            this.panel1.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(12, 146);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(164, 23);
            this.btnImportar.TabIndex = 12;
            this.btnImportar.Text = "Gerar Arquivo CSV";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.Location = new System.Drawing.Point(475, 112);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(75, 23);
            this.btnOperacoes.TabIndex = 11;
            this.btnOperacoes.Text = "Upload";
            this.btnOperacoes.UseVisualStyleBackColor = true;
            this.btnOperacoes.Click += new System.EventHandler(this.btnOperacoes_Click);
            // 
            // btnUploadArquivoDados
            // 
            this.btnUploadArquivoDados.Location = new System.Drawing.Point(475, 39);
            this.btnUploadArquivoDados.Name = "btnUploadArquivoDados";
            this.btnUploadArquivoDados.Size = new System.Drawing.Size(75, 23);
            this.btnUploadArquivoDados.TabIndex = 10;
            this.btnUploadArquivoDados.Text = "Upload";
            this.btnUploadArquivoDados.UseVisualStyleBackColor = true;
            this.btnUploadArquivoDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOperacoes
            // 
            this.txtOperacoes.Location = new System.Drawing.Point(12, 112);
            this.txtOperacoes.Name = "txtOperacoes";
            this.txtOperacoes.ReadOnly = true;
            this.txtOperacoes.Size = new System.Drawing.Size(457, 22);
            this.txtOperacoes.TabIndex = 9;
            // 
            // txtDadosMercado
            // 
            this.txtDadosMercado.Location = new System.Drawing.Point(12, 39);
            this.txtDadosMercado.Name = "txtDadosMercado";
            this.txtDadosMercado.ReadOnly = true;
            this.txtDadosMercado.Size = new System.Drawing.Size(457, 22);
            this.txtDadosMercado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arquivo Operações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arquivo Dados Mercacdo";
            // 
            // sDownload
            // 
            this.sDownload.Filter = "Arquivo Excel|*.csv";
            this.sDownload.Title = "Salvar arquivo CSV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 185);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Teste Arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofUpload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnOperacoes;
        private System.Windows.Forms.Button btnUploadArquivoDados;
        private System.Windows.Forms.TextBox txtOperacoes;
        private System.Windows.Forms.TextBox txtDadosMercado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sDownload;
    }
}

