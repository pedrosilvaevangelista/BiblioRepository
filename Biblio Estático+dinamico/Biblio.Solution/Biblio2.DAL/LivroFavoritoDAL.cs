using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.DAL
{
    public class LivroFavoritoDAL : Conexao
    {
        public void AddLivroFavorito(LivroFavoritoDTO favorito)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
                    INSERT INTO LivroFavorito (UsuarioId, LivroId)
                    VALUES (@UsuarioId, @LivroId);
                ", conn);
                cmd.Parameters.AddWithValue("@UsuarioId", favorito.UsuarioId);
                cmd.Parameters.AddWithValue("@LivroId", favorito.LivroId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar livro favorito: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<LivroFavoritoDTO> GetLivroFavoritos(int usuarioId)
        {
            List<LivroFavoritoDTO> listaFavoritos = new List<LivroFavoritoDTO>();
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
            SELECT LF.IdFavorito, LF.UsuarioId, LF.LivroId, 
                   L.TituloLivro, L.AutorLivro, L.UrlCapaLivro, L.UrlIconLivro
            FROM LivroFavorito LF
            INNER JOIN Livro L ON LF.LivroId = L.IdLivro
            WHERE LF.UsuarioId = @UsuarioId;
        ", conn);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    LivroFavoritoDTO favorito = new LivroFavoritoDTO
                    {
                        IdFavorito = Convert.ToInt32(dr["IdFavorito"]),
                        UsuarioId = Convert.ToInt32(dr["UsuarioId"]),
                        LivroId = Convert.ToInt32(dr["LivroId"]),
                        TituloLivro = dr["TituloLivro"].ToString(),
                        AutorLivro = dr["AutorLivro"].ToString(),
                        UrlCapaLivro = dr["UrlCapaLivro"].ToString(),
                        // Novo campo
                        UrlIconLivro = dr["UrlIconLivro"].ToString()
                    };
                    listaFavoritos.Add(favorito);
                }
                return listaFavoritos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar livros favoritos: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        // Método para remover um favorito
        public void DeleteLivroFavorito(int idFavorito)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM LivroFavorito WHERE IdFavorito = @IdFavorito", conn);
                cmd.Parameters.AddWithValue("@IdFavorito", idFavorito);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover livro favorito: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        // Método para verificar se um livro já é favorito para um usuário
        public bool IsLivroFavorito(int usuarioId, int livroId)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT COUNT(*) FROM LivroFavorito WHERE UsuarioId = @UsuarioId AND LivroId = @LivroId", conn);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@LivroId", livroId);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar se livro é favorito: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        // Método para obter o Id do registro de favorito de um usuário para um livro
        public int GetIdFavorito(int usuarioId, int livroId)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdFavorito FROM LivroFavorito WHERE UsuarioId = @UsuarioId AND LivroId = @LivroId", conn);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@LivroId", livroId);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o ID do favorito: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}