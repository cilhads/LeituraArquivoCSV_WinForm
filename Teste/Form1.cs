using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Teste.Entidades;
using System.Linq;
using System.Text;

namespace Teste
{
    public partial class Form1 : Form
    {
        private IEnumerable<Operacoes> listOperacoes = new List<Operacoes>();
        private IEnumerable<DadosMercado> listDadosMercado = new List<DadosMercado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofUpload.ShowDialog() == DialogResult.OK)
            {
                this.txtDadosMercado.Text = this.ofUpload.FileName;
                //faz tratamento de botão
                if (!string.IsNullOrEmpty(this.txtOperacoes.Text))
                    this.btnImportar.Enabled = true;
                //preenche os dados 
                string[] csv = File.ReadAllLines(this.txtDadosMercado.Text);
                //remove a linha do cabeçalho
                csv = csv.Where(x => !x.Contains("ID_PRECO")).ToArray();

                listDadosMercado = from linha in csv
                                   let dados = linha.Split(';')
                                   select new DadosMercado()
                                   {
                                       ID_PRECO = Convert.ToInt32(dados[0]),
                                       NU_PRAZO_DIAS_CORRIDOS = Convert.ToInt32(dados[1]),
                                       VL_PRECO = Convert.ToDecimal(dados[2])
                                   };

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnImportar.Enabled = false;
        }

        private void btnOperacoes_Click(object sender, EventArgs e)
        {
            if (ofUpload.ShowDialog() == DialogResult.OK)
            {
                this.txtOperacoes.Text = this.ofUpload.FileName;
                if (!string.IsNullOrEmpty(this.txtDadosMercado.Text))
                    this.btnImportar.Enabled = true;

                //preenche os dados 
                string[] csv = File.ReadAllLines(this.txtOperacoes.Text);
                //remove a linha do cabeçalho
                csv = csv.Where(x => !x.Contains("ID_PRECO")).ToArray();

                listOperacoes = from linha in csv
                                let dados = linha.Split(';')
                                select new Operacoes()
                                {
                                    CD_OPERACAO = Convert.ToInt32(dados[0]),
                                    DT_INICIO = Convert.ToDateTime(dados[1]),
                                    DT_FIM = Convert.ToDateTime(dados[2]),
                                    NM_EMPRESA = dados[3],
                                    NM_EMPRESA_RAZAO_SOCIAL = dados[4],
                                    NM_ESTRATEGIA = dados[5],
                                    NM_CENTRALIZADOR = dados[6],
                                    NM_GESTOR = dados[7],
                                    NM_SUBGESTOR = dados[8],
                                    NM_SUBPRODUTO = dados[9],
                                    NM_CARACTERISTICA = dados[10],
                                    CD_ATIVO_OBJETO = dados[11],
                                    QUANTIDADE = Convert.ToDouble(dados[12]),
                                    ID_PRECO = Convert.ToInt32(dados[13]),
                                    NU_PRAZO_DIAS_CORRIDOS = Convert.ToDateTime(dados[2]).Subtract(Convert.ToDateTime(dados[1])).Days

                                };
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            sDownload.ShowDialog();

            if (sDownload.FileName != "")
            {
                var joins = (from a in listDadosMercado
                             join b in listOperacoes
                             on new
                             {
                                 a.ID_PRECO,
                                 a.NU_PRAZO_DIAS_CORRIDOS
                             }
                             equals new
                             {
                                 b.ID_PRECO,
                                 b.NU_PRAZO_DIAS_CORRIDOS
                             }
                             orderby b.NM_SUBPRODUTO
                             select new Join
                             {
                                 CD_OPERACAO = b.CD_OPERACAO,
                                 DT_INICIO = b.DT_INICIO,
                                 DT_FIM = b.DT_FIM,
                                 NM_EMPRESA = b.NM_EMPRESA,
                                 NM_EMPRESA_RAZAO_SOCIAL = b.NM_EMPRESA_RAZAO_SOCIAL,
                                 NM_ESTRATEGIA = b.NM_ESTRATEGIA,
                                 NM_CENTRALIZADOR = b.NM_CENTRALIZADOR,
                                 NM_GESTOR = b.NM_GESTOR,
                                 NM_SUBGESTOR = b.NM_SUBGESTOR,
                                 NM_SUBPRODUTO = b.NM_SUBPRODUTO,
                                 NM_CARACTERISTICA = b.NM_CARACTERISTICA,
                                 CD_ATIVO_OBJETO = b.CD_ATIVO_OBJETO,
                                 QUANTIDADE = b.QUANTIDADE,
                                 ID_PRECO = b.ID_PRECO,
                                 NU_PRAZO_DIAS_CORRIDOS = b.NU_PRAZO_DIAS_CORRIDOS,
                                 VL_PRECO = a.VL_PRECO
                             }).ToList();


                var resultado = (from j in joins
                                 group j by new { j.NM_SUBPRODUTO } into agrupado
                                 select new Resultado
                                 {
                                     NM_SUBPRODUTO = agrupado.Key.NM_SUBPRODUTO,
                                     VL_RESULTADO = agrupado.Sum(j => j.VL_PRECO)
                                 });

                StreamWriter arqSaida = new StreamWriter(sDownload.FileName);


                arqSaida.WriteLine("NM_SUBPRODUTO;VL_RESULTADO;");

                foreach (Resultado item in resultado)
                {
                    arqSaida.WriteLine(string.Format("{0};{1};", item.NM_SUBPRODUTO, item.VL_RESULTADO));
                }
                                
                arqSaida.Close();

                if (MessageBox.Show("Arquivo CSV Salvo\r\nDeseja abrir o arquivo?" +
                    "", "Arquivo CSV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("Excel", sDownload.FileName);
                }

            }

        }
    }
}
