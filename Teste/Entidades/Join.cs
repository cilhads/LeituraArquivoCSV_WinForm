using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entidades
{
    public class Join
    {
        public int CD_OPERACAO { get; set; }
        public DateTime DT_INICIO { get; set; }
        public DateTime DT_FIM { get; set; }
        public string NM_EMPRESA { get; set; }
        public string NM_EMPRESA_RAZAO_SOCIAL { get; set; }
        public string NM_ESTRATEGIA { get; set; }
        public string NM_CENTRALIZADOR { get; set; }
        public string NM_GESTOR { get; set; }
        public string NM_SUBGESTOR { get; set; }
        public string NM_SUBPRODUTO { get; set; }
        public string NM_CARACTERISTICA { get; set; }
        public string CD_ATIVO_OBJETO { get; set; }
        public double QUANTIDADE { get; set; }
        public int ID_PRECO { get; set; }
        public int NU_PRAZO_DIAS_CORRIDOS { get; set; }
        public decimal VL_PRECO { get; set; }
    }
}
