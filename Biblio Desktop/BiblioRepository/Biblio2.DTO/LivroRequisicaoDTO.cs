using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.DTO
{
    public class LivroRequisicaoDTO
    {
        public int IdLivroRequisicao { get; set; }
        public string TituloLivroRequisicao { get; set; }
        public string GeneroLivroRequisicao { get; set; }
        public string SinopseLivroRequisicao { get; set; }
        public string AutorLivroRequisicao { get; set; }
        public DateTime DataPublicacaoLivroRequisicao { get; set; }
        public string UrlCapaLivroRequisicao { get; set; }
        public string UrlIconLivroRequisicao { get; set; }
        public string UrlBannerLivroRequisicao { get; set; }
        public string UrlPDFLivroRequisicao { get; set; }
    }
}
