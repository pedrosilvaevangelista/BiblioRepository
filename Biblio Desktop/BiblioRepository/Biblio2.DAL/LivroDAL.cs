using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio2.DTO;

namespace Biblio2.DAL
{
    public class LivroDAL : Conexao
    {
        string msg = "Erro nessa bosta de código dnv";

        //CRUD

        //CREATE
        public void CreateLivro(LivroDTO livro)
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
                    VALUES (
                        @TituloLivro, 
                        @GeneroLivro, 
                        @SinopseLivro, 
                        @AutorLivro, 
                        @DataPublicacaoLivro, 
                        @UrlCapaLivro, 
                        @UrlIconLivro, 
                        @UrlBannerLivro, 
                        @UrlPDFLivro
                    );
                ", conn);

                cmd.Parameters.AddWithValue("@TituloLivro", livro.TituloLivro);
                cmd.Parameters.AddWithValue("@GeneroLivro", livro.GeneroLivro);
                cmd.Parameters.AddWithValue("@SinopseLivro", livro.SinopseLivro);
                cmd.Parameters.AddWithValue("@AutorLivro", livro.AutorLivro);
                cmd.Parameters.AddWithValue("@DataPublicacaoLivro", livro.DataPublicacaoLivro);
                cmd.Parameters.AddWithValue("@UrlCapaLivro", livro.UrlCapaLivro);
                cmd.Parameters.AddWithValue("@UrlIconLivro", livro.UrlIconLivro);
                cmd.Parameters.AddWithValue("@UrlBannerLivro", livro.UrlBannerLivro ?? (object)DBNull.Value); // Permite valores nulos
                cmd.Parameters.AddWithValue("@UrlPDFLivro", livro.UrlPDFLivro);
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
        public List<LivroDTO> GetLivro()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
                    SELECT 
                        L.IdLivro, 
                        L.TituloLivro, 
                        G.DescricaoGenero AS Genero, 
                        L.SinopseLivro, 
                        L.AutorLivro, 
                        L.DataPublicacaoLivro, 
                        L.UrlCapaLivro, 
                        L.UrlIconLivro, 
                        L.UrlBannerLivro, 
                        L.UrlPDFLivro
                    FROM 
                        Livro L
                    INNER JOIN 
                        Genero G ON L.GeneroLivro = G.IdGenero;
                ", conn);
                dr = cmd.ExecuteReader();
                List<LivroDTO> listLivro = new List<LivroDTO>();

                while (dr.Read())
                {
                    LivroDTO livro = new LivroDTO();
                    livro.IdLivro = Convert.ToInt32(dr["IdLivro"]);
                    livro.TituloLivro = dr["TituloLivro"].ToString();
                    livro.GeneroLivro = dr["Genero"].ToString();
                    livro.SinopseLivro = dr["SinopseLivro"].ToString();
                    livro.AutorLivro = dr["AutorLivro"].ToString();
                    livro.DataPublicacaoLivro = Convert.ToDateTime(dr["DataPublicacaoLivro"]);
                    livro.UrlCapaLivro = dr["UrlCapaLivro"].ToString();
                    livro.UrlIconLivro = dr["UrlIconLivro"].ToString();
                    livro.UrlBannerLivro = dr["UrlBannerLivro"].ToString();
                    livro.UrlPDFLivro = dr["UrlPDFLivro"].ToString();
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

        //UPDATE
        public void UpdateLivro(LivroDTO livro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
                    UPDATE Livro
                    SET 
                        TituloLivro = @TituloLivro, 
                        GeneroLivro = @GeneroLivro, 
                        SinopseLivro = @SinopseLivro, 
                        AutorLivro = @AutorLivro, 
                        DataPublicacaoLivro = @DataPublicacaoLivro, 
                        UrlCapaLivro = @UrlCapaLivro, 
                        UrlIconLivro = @UrlIconLivro, 
                        UrlBannerLivro = @UrlBannerLivro, 
                        UrlPDFLivro = @UrlPDFLivro
                    WHERE IdLivro = @IdLivro;
                ", conn);
                cmd.Parameters.AddWithValue("@TituloLivro", livro.TituloLivro);
                cmd.Parameters.AddWithValue("@GeneroLivro", livro.GeneroLivro);
                cmd.Parameters.AddWithValue("@SinopseLivro", livro.SinopseLivro);
                cmd.Parameters.AddWithValue("@AutorLivro", livro.AutorLivro);
                cmd.Parameters.AddWithValue("@DataPublicacaoLivro", livro.DataPublicacaoLivro);
                cmd.Parameters.AddWithValue("@UrlCapaLivro", livro.UrlCapaLivro);
                cmd.Parameters.AddWithValue("@UrlIconLivro", livro.UrlIconLivro);
                cmd.Parameters.AddWithValue("@UrlBannerLivro", livro.UrlBannerLivro ?? (object)DBNull.Value); // Permite valores nulos
                cmd.Parameters.AddWithValue("@UrlPDFLivro", livro.UrlPDFLivro);
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

        //DELETE
        public void DeleteLivro(int idLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Livro WHERE IdLivro = @IdLivro", conn);
                cmd.Parameters.AddWithValue("@IdLivro", idLivro);
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

        //FUNÇÕES EXTRAS

        //GetGeneroLivro - Pegar o gênero disponíveis, pode ser usado em DDL ou ComboBox
        public List<GeneroDTO> GetGeneroLivro()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Genero;", conn);
                dr = cmd.ExecuteReader();
                List<GeneroDTO> listLivro = new List<GeneroDTO>();

                while (dr.Read())
                {
                    GeneroDTO livroGenero = new GeneroDTO();
                    livroGenero.IdGenero = Convert.ToInt32(dr["IdGenero"]);
                    livroGenero.DescricaoGenero = dr["DescricaoGenero"].ToString();

                    listLivro.Add(livroGenero);
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

        //FilterByGenero
        public List<LivroDTO> FilterByGenero(string genero)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
            SELECT 
                L.IdLivro, 
                L.TituloLivro, 
                G.DescricaoGenero AS Genero, 
                L.SinopseLivro, 
                L.AutorLivro, 
                L.DataPublicacaoLivro, 
                L.UrlCapaLivro, 
                L.UrlIconLivro, 
                L.UrlBannerLivro, 
                L.UrlPDFLivro
            FROM Livro L
            INNER JOIN Genero G ON L.GeneroLivro = G.IdGenero
            WHERE L.GeneroLivro = @GeneroLivro;
        ", conn);
                cmd.Parameters.AddWithValue("@GeneroLivro", genero); // Certifique-se de que o parâmetro está correto
                dr = cmd.ExecuteReader();
                List<LivroDTO> listLivro = new List<LivroDTO>();

                while (dr.Read())
                {
                    LivroDTO livro = new LivroDTO();
                    livro.IdLivro = Convert.ToInt32(dr["IdLivro"]);
                    livro.TituloLivro = dr["TituloLivro"].ToString();
                    livro.GeneroLivro = dr["Genero"].ToString();
                    livro.SinopseLivro = dr["SinopseLivro"].ToString();
                    livro.AutorLivro = dr["AutorLivro"].ToString();
                    livro.DataPublicacaoLivro = Convert.ToDateTime(dr["DataPublicacaoLivro"]);
                    livro.UrlCapaLivro = dr["UrlCapaLivro"].ToString();
                    livro.UrlIconLivro = dr["UrlIconLivro"].ToString();
                    livro.UrlBannerLivro = dr["UrlBannerLivro"].ToString();
                    livro.UrlPDFLivro = dr["UrlPDFLivro"].ToString();
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

        public bool VerificarTituloLivro(string tituloLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Livro WHERE TituloLivro = @tituloLivro", conn);
                cmd.Parameters.AddWithValue("@tituloLivro", tituloLivro);

                // Verifica a quantidade de registros encontrados
                int count = (int)cmd.ExecuteScalar();

                // Se count for maior que 0, significa que existe o título do livro duplicado
                return count > 0;
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
        public LivroDTO SearchByIdLivro(int idLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Livro WHERE IdLivro = @IdLivro", conn);
                cmd.Parameters.AddWithValue("@IdLivro", idLivro); // Corrigido o parâmetro para IdLivro
                dr = cmd.ExecuteReader();
                LivroDTO livro = new LivroDTO();

                while (dr.Read())
                {
                    livro = new LivroDTO();
                    livro.IdLivro = Convert.ToInt32(dr["IdLivro"]);
                    livro.TituloLivro = dr["TituloLivro"].ToString();
                    livro.GeneroLivro = dr["GeneroLivro"].ToString();
                    livro.SinopseLivro = dr["SinopseLivro"].ToString();
                    livro.AutorLivro = dr["AutorLivro"].ToString();
                    livro.DataPublicacaoLivro = Convert.ToDateTime(dr["DataPublicacaoLivro"]);
                    livro.UrlCapaLivro = dr["UrlCapaLivro"].ToString();
                    livro.UrlIconLivro = dr["UrlIconLivro"].ToString();
                    livro.UrlBannerLivro = dr["UrlBannerLivro"].ToString();
                    livro.UrlPDFLivro = dr["UrlPDFLivro"].ToString();
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

        public List<LivroDTO> SearchByTituloLivro(string tituloLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
            SELECT 
                L.IdLivro, 
                L.TituloLivro, 
                G.DescricaoGenero AS Genero, 
                L.SinopseLivro, 
                L.AutorLivro, 
                L.DataPublicacaoLivro, 
                L.UrlCapaLivro, 
                L.UrlIconLivro, 
                L.UrlBannerLivro, 
                L.UrlPDFLivro
            FROM Livro L
            INNER JOIN Genero G ON L.GeneroLivro = G.IdGenero
            WHERE L.TituloLivro LIKE '%' + @TituloLivro + '%';
        ", conn);
                cmd.Parameters.AddWithValue("@TituloLivro", tituloLivro);
                dr = cmd.ExecuteReader();

                List<LivroDTO> listaLivros = new List<LivroDTO>();

                while (dr.Read())
                {
                    LivroDTO livro = new LivroDTO();
                    livro.IdLivro = Convert.ToInt32(dr["IdLivro"]);
                    livro.TituloLivro = dr["TituloLivro"].ToString();
                    livro.GeneroLivro = dr["Genero"].ToString(); // Ajuste para 'Genero'
                    livro.SinopseLivro = dr["SinopseLivro"].ToString();
                    livro.AutorLivro = dr["AutorLivro"].ToString();
                    livro.DataPublicacaoLivro = Convert.ToDateTime(dr["DataPublicacaoLivro"]);
                    livro.UrlCapaLivro = dr["UrlCapaLivro"].ToString();
                    livro.UrlIconLivro = dr["UrlIconLivro"].ToString();
                    livro.UrlBannerLivro = dr["UrlBannerLivro"].ToString();
                    livro.UrlPDFLivro = dr["UrlPDFLivro"].ToString();

                    listaLivros.Add(livro);
                }
                return listaLivros;
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

        //SearchByAutor
        public List<LivroDTO> SearchByAutorLivro(string autorLivro)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
                    SELECT 
                        L.IdLivro, 
                        L.TituloLivro, 
                        G.DescricaoGenero AS Genero, 
                        L.SinopseLivro, 
                        L.AutorLivro, 
                        L.DataPublicacaoLivro, 
                        L.UrlCapaLivro, 
                        L.UrlIconLivro, 
                        L.UrlBannerLivro, 
                        L.UrlPDFLivro
                    FROM Livro L
                    INNER JOIN Genero G ON L.GeneroLivro = G.IdGenero
                    WHERE L.AutorLivro LIKE '%' + @AutorLivro + '%';
                ", conn);
                cmd.Parameters.AddWithValue("@AutorLivro", autorLivro);
                dr = cmd.ExecuteReader();
                List<LivroDTO> listLivro = new List<LivroDTO>();

                while (dr.Read())
                {
                    LivroDTO livro = new LivroDTO();
                    livro.IdLivro = Convert.ToInt32(dr["IdLivro"]);
                    livro.TituloLivro = dr["TituloLivro"].ToString();
                    livro.GeneroLivro = dr["Genero"].ToString(); // Ajuste para 'Genero'
                    livro.SinopseLivro = dr["SinopseLivro"].ToString();
                    livro.AutorLivro = dr["AutorLivro"].ToString();
                    livro.DataPublicacaoLivro = Convert.ToDateTime(dr["DataPublicacaoLivro"]);
                    livro.UrlCapaLivro = dr["UrlCapaLivro"].ToString();
                    livro.UrlIconLivro = dr["UrlIconLivro"].ToString();
                    livro.UrlBannerLivro = dr["UrlBannerLivro"].ToString();
                    livro.UrlPDFLivro = dr["UrlPDFLivro"].ToString();
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
    }
}