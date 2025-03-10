using Biblio2.DAL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.BLL
{
    public class LivroFavoritoBLL
    {
        LivroFavoritoDAL favoritoDAL = new LivroFavoritoDAL();


        // CREATE: Adiciona um livro aos favoritos
        public void AddLivroFavoritoBLL(LivroFavoritoDTO favorito)
        {
            favoritoDAL.AddLivroFavorito(favorito);
        }

        // READ: Recupera a lista de livros favoritos de um usuário
        public List<LivroFavoritoDTO> GetLivroFavoritosBLL(int usuarioId)
        {
            return favoritoDAL.GetLivroFavoritos(usuarioId);
        }

        // DELETE: Remove um livro favorito pelo IdFavorito
        public void DeleteLivroFavoritoBLL(int idFavorito)
        {
            favoritoDAL.DeleteLivroFavorito(idFavorito);
        }

        // Verifica se um livro já está nos favoritos do usuário
        public bool IsLivroFavoritoBLL(int usuarioId, int livroId)
        {
            return favoritoDAL.IsLivroFavorito(usuarioId, livroId);
        }

        // Recupera o ID do registro de favorito para um determinado usuário e livro
        public int GetIdFavoritoBLL(int usuarioId, int livroId)
        {
            return favoritoDAL.GetIdFavorito(usuarioId, livroId);
        }
    }
}