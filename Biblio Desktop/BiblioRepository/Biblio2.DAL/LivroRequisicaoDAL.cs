using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.DAL
{
    public class LivroRequisicaoDAL : Conexao
    {
        string msg = "Erro ao criar requisição de livro";

        //CRUD parcial - CREATE, READ & DELETE

        //CREATE
        public void CreateLivroRequisicao(LivroRequisicaoDTO livro)
        {
            try
            {
                Conectar();
                string sql = @"
                    INSERT INTO LivroRequisicao (
                        TituloLivroRequisicao, 
                        GeneroLivroRequisicao, 
                        SinopseLivroRequisicao, 
                        AutorLivroRequisicao, 
                        DataPublicacaoLivroRequisicao, 
                        UrlCapaLivroRequisicao, 
                        UrlIconLivroRequisicao, 
                        UrlBannerLivroRequisicao, 
                        UrlPDFLivroRequisicao
                    ) VALUES (
                        @TituloLivroRequisicao, 
                        @GeneroLivroRequisicao, 
                        @SinopseLivroRequisicao, 
                        @AutorLivroRequisicao, 
                        @DataPublicacaoLivroRequisicao, 
                        @UrlCapaLivroRequisicao, 
                        @UrlIconLivroRequisicao, 
                        @UrlBannerLivroRequisicao, 
                        @UrlPDFLivroRequisicao
                    );";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TituloLivroRequisicao", livro.TituloLivroRequisicao);
                cmd.Parameters.AddWithValue("@GeneroLivroRequisicao", livro.GeneroLivroRequisicao);
                cmd.Parameters.AddWithValue("@SinopseLivroRequisicao", livro.SinopseLivroRequisicao);
                cmd.Parameters.AddWithValue("@AutorLivroRequisicao", livro.AutorLivroRequisicao);
                cmd.Parameters.AddWithValue("@DataPublicacaoLivroRequisicao", livro.DataPublicacaoLivroRequisicao);
                cmd.Parameters.AddWithValue("@UrlCapaLivroRequisicao", livro.UrlCapaLivroRequisicao);
                cmd.Parameters.AddWithValue("@UrlIconLivroRequisicao", livro.UrlIconLivroRequisicao);
                if (string.IsNullOrEmpty(livro.UrlBannerLivroRequisicao))
                    cmd.Parameters.AddWithValue("@UrlBannerLivroRequisicao", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@UrlBannerLivroRequisicao", livro.UrlBannerLivroRequisicao);
                cmd.Parameters.AddWithValue("@UrlPDFLivroRequisicao", livro.UrlPDFLivroRequisicao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //READ
        public List<LivroRequisicaoDTO> GetLivroRequisicao()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
                    SELECT 
                        LR.IdLivroRequisicao, 
                        LR.TituloLivroRequisicao, 
                        G.DescricaoGenero AS Genero, 
                        LR.SinopseLivroRequisicao, 
                        LR.AutorLivroRequisicao, 
                        LR.DataPublicacaoLivroRequisicao, 
                        LR.UrlCapaLivroRequisicao, 
                        LR.UrlIconLivroRequisicao, 
                        LR.UrlBannerLivroRequisicao, 
                        LR.UrlPDFLivroRequisicao
                    FROM 
                        LivroRequisicao LR
                    INNER JOIN 
                        Genero G ON LR.GeneroLivroRequisicao = G.IdGenero;
                ", conn);
                dr = cmd.ExecuteReader();
                List<LivroRequisicaoDTO> listLivro = new List<LivroRequisicaoDTO>();

                while (dr.Read())
                {
                    LivroRequisicaoDTO livro = new LivroRequisicaoDTO();
                    livro.IdLivroRequisicao = Convert.ToInt32(dr["IdLivroRequisicao"]);
                    livro.TituloLivroRequisicao = dr["TituloLivroRequisicao"].ToString();
                    livro.GeneroLivroRequisicao = dr["Genero"].ToString();
                    livro.SinopseLivroRequisicao = dr["SinopseLivroRequisicao"].ToString();
                    livro.AutorLivroRequisicao = dr["AutorLivroRequisicao"].ToString();
                    livro.DataPublicacaoLivroRequisicao = Convert.ToDateTime(dr["DataPublicacaoLivroRequisicao"]);
                    livro.UrlCapaLivroRequisicao = dr["UrlCapaLivroRequisicao"].ToString();
                    livro.UrlIconLivroRequisicao = dr["UrlIconLivroRequisicao"].ToString();
                    livro.UrlBannerLivroRequisicao = dr["UrlBannerLivroRequisicao"].ToString();
                    livro.UrlPDFLivroRequisicao = dr["UrlPDFLivroRequisicao"].ToString();
                    listLivro.Add(livro);
                }
                return listLivro;
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //DELETE
        public void DeleteLivroRequisicao(int idLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM LivroRequisicao WHERE IdLivroRequisicao = @IdLivroRequisicao", conn);
                cmd.Parameters.AddWithValue("@IdLivroRequisicao", idLivro);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //FUNÇÕES ESPECIAIS

        //GetGenero - Mesma coisa do LivroDAL, mas no LivroRequisicaoDAL
        public List<GeneroDTO> GetGeneroLivroRequisicao()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Genero;", conn);
                dr = cmd.ExecuteReader();
                List<GeneroDTO> listGenero = new List<GeneroDTO>();

                while (dr.Read())
                {
                    GeneroDTO livroGenero = new GeneroDTO();
                    livroGenero.IdGenero = Convert.ToInt32(dr["IdGenero"]);
                    livroGenero.DescricaoGenero = dr["DescricaoGenero"].ToString();

                    listGenero.Add(livroGenero);
                }
                return listGenero;
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //SearchById
        public LivroRequisicaoDTO SearchByIdLivroRequisicao(int idLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM LivroRequisicao WHERE IdLivroRequisicao = @IdLivroRequisicao", conn);
                cmd.Parameters.AddWithValue("@IdLivroRequisicao", idLivro);
                dr = cmd.ExecuteReader();
                LivroRequisicaoDTO livro = new LivroRequisicaoDTO();

                while (dr.Read())
                {
                    livro.IdLivroRequisicao = Convert.ToInt32(dr["IdLivroRequisicao"]);
                    livro.TituloLivroRequisicao = dr["TituloLivroRequisicao"].ToString();
                    livro.GeneroLivroRequisicao = dr["GeneroLivroRequisicao"].ToString();
                    livro.SinopseLivroRequisicao = dr["SinopseLivroRequisicao"].ToString();
                    livro.AutorLivroRequisicao = dr["AutorLivroRequisicao"].ToString();
                    livro.DataPublicacaoLivroRequisicao = Convert.ToDateTime(dr["DataPublicacaoLivroRequisicao"]);
                    livro.UrlCapaLivroRequisicao = dr["UrlCapaLivroRequisicao"].ToString();
                    livro.UrlIconLivroRequisicao = dr["UrlIconLivroRequisicao"].ToString();
                    livro.UrlBannerLivroRequisicao = dr["UrlBannerLivroRequisicao"].ToString();
                    livro.UrlPDFLivroRequisicao = dr["UrlPDFLivroRequisicao"].ToString();
                }
                return livro;
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //ApproveLivroRequisicao
        public void ApproveLivroRequisicao(int idLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
                    INSERT INTO Livro (
                        TituloLivro, 
                        GeneroLivro, 
                        SinopseLivro, 
                        AutorLivro, 
                        DataPublicacaoLivro, 
                        UrlCapaLivro, 
                        UrlIconLivro, 
                        UrlBannerLivro, 
                        UrlPDFLivro
                    )
                    SELECT 
                        TituloLivroRequisicao, 
                        GeneroLivroRequisicao, 
                        SinopseLivroRequisicao, 
                        AutorLivroRequisicao, 
                        DataPublicacaoLivroRequisicao, 
                        UrlCapaLivroRequisicao, 
                        UrlIconLivroRequisicao, 
                        UrlBannerLivroRequisicao, 
                        UrlPDFLivroRequisicao
                    FROM 
                        LivroRequisicao
                    WHERE 
                        IdLivroRequisicao = @IdLivroRequisicao;

                    DELETE FROM LivroRequisicao 
                    WHERE IdLivroRequisicao = @IdLivroRequisicao;
                ", conn);

                cmd.Parameters.AddWithValue("@IdLivroRequisicao", idLivro);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}

