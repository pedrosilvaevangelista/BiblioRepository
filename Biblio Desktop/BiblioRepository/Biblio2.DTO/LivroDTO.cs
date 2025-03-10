using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.DTO
{
    public class LivroDTO
    {
        public int IdLivro { get; set; }
        public string TituloLivro { get; set; }
        public string GeneroLivro { get; set; }
        public string SinopseLivro { get; set; }
        public string AutorLivro { get; set; }
        public DateTime DataPublicacaoLivro { get; set; }
        public string UrlCapaLivro { get; set; }
        public string UrlIconLivro { get; set; }
        public string UrlBannerLivro { get; set; }
        public string UrlPDFLivro { get; set; }
    }
}
