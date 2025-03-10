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
    }
}

