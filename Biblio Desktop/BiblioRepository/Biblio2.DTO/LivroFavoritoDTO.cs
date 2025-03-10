using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.DTO
{
    public class LivroFavoritoDTO
    {
        public int IdFavorito { get; set; }
        public int UsuarioId { get; set; }
        public int LivroId { get; set; }
        public string TituloLivro { get; set; }
        public string AutorLivro { get; set; }
        public string UrlCapaLivro { get; set; }
        public string UrlIconLivro { get; set; }
    }
}
