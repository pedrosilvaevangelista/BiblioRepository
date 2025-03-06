using Biblio2.DAL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.BLL
{
    public class LivroBLL
    {
        //Objetos globais
        LivroDAL livroDAL = new LivroDAL();

        //CRUD

        //CREATE
        public void CreateLivroBLL(LivroDTO livro)
        {
            livroDAL.CreateLivro(livro);
        }

        //READ
        public List<LivroDTO> GetLivroBLL()
        {
            return livroDAL.GetLivro();
        }

        //UPDATE
        public void UpdateLivroBLL(LivroDTO livro)
        {
            livroDAL.UpdateLivro(livro);
        }

        //DELETE
        public void DeleteLivroBLL(int idLivro)
        {
            livroDAL.DeleteLivro(idLivro);
        }

        //FUNÇÕES EXTRAS

        //GetGenderLivro
        public List<GeneroDTO> GetGeneroLivroBLL()
        {
            return livroDAL.GetGeneroLivro();
        }

        //FilterByGenero
        public List<LivroDTO> FilterByGeneroBLL(string genero)
        {
            return livroDAL.FilterByGenero(genero);
        }

        //SearchById
        public LivroDTO SearchByIdLivroBLL(int idLivro)
        {
            return livroDAL.SearchByIdLivro(idLivro);
        }

        //SearchByTitulo
        public List<LivroDTO> SearchByTituloLivroBLL(string tituloLivro)
        {
            return livroDAL.SearchByTituloLivro(tituloLivro);
        }

        //SearchByAutor
        public List<LivroDTO> SearchByAutorLivroBLL(string autorLivro)
        {
            return livroDAL.SearchByAutorLivro(autorLivro);
        }
    }
}
