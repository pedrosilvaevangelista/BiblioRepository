using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.DAL
{
    public class UsuarioDAL : Conexao
    {
        string msg = "Erro nessa bosta de código dnv";

        //CRUD

        //CREATE - Criar usuário
        public void CreateUsuario(UsuarioDTO user)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Usuario (NomeUsuario, EmailUsuario, SenhaUsuario, UrlFotoPerfil, UsuarioTipo) VALUES (@NomeUsuario, @EmailUsuario, @SenhaUsuario, @UrlFotoPerfil, @UsuarioTipo);", conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", user.NomeUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuario", user.EmailUsuario);
                cmd.Parameters.AddWithValue("@SenhaUsuario", user.SenhaUsuario);
                cmd.Parameters.AddWithValue("@UrlFotoPerfil", user.UrlFotoPerfil);
                cmd.Parameters.AddWithValue("@UsuarioTipo", user.UsuarioTipo);
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

        //READ - Pegar usuário
        public List<UsuarioDTO> GetUsuario()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario, NomeUsuario, EmailUsuario, SenhaUsuario, UrlFotoPerfil, DescricaoTipoUsuario FROM Usuario INNER JOIN TipoUsuario ON Usuario.UsuarioTipo = TipoUsuario.IdTipoUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> listUser = new List<UsuarioDTO>();

                while (dr.Read())
                {
                    UsuarioDTO user = new UsuarioDTO();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.NomeUsuario = dr["NomeUsuario"].ToString();
                    user.EmailUsuario = dr["EmailUsuario"].ToString();
                    user.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    user.UrlFotoPerfil = dr["UrlFotoPerfil"].ToString();
                    user.UsuarioTipo = dr["DescricaoTipoUsuario"].ToString();
                    listUser.Add(user);
                }
                return listUser;
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

        //UPDATE - Atualiza o usuário
        public void UpdateUsuario(UsuarioDTO user)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(@"
                    UPDATE Usuario
                        SET NomeUsuario = @NomeUsuario, 
                        EmailUsuario = @EmailUsuario, 
                        SenhaUsuario = @SenhaUsuario,
                        UrlFotoPerfil = @UrlFotoPerfil,
                        UsuarioTipo = @UsuarioTipo
                    WHERE IdUsuario = @IdUsuario", conn);

                cmd.Parameters.AddWithValue("@NomeUsuario", user.NomeUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuario", user.EmailUsuario);
                cmd.Parameters.AddWithValue("@SenhaUsuario", user.SenhaUsuario);
                cmd.Parameters.AddWithValue("@UrlFotoPerfil", user.UrlFotoPerfil);
                cmd.Parameters.AddWithValue("@UsuarioTipo", user.UsuarioTipo);
                //passando o id para condicao WHERE do comando sql
                cmd.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
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

        //DELETE - Deleta o usuário
        public void DeleteUsuario(int idUser)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUser);
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

        //GetTipo - Pega o tipo do usuário
        public List<TipoUsuarioDTO> GetTipoUsuario()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM TipoUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<TipoUsuarioDTO> listUser = new List<TipoUsuarioDTO>();

                while (dr.Read())
                {
                    TipoUsuarioDTO userTipo = new TipoUsuarioDTO();
                    userTipo.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
                    userTipo.DescricaoTipoUsuario = dr["DescricaoTipoUsuario"].ToString();

                    listUser.Add(userTipo);
                }
                return listUser;
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

        //Authenticate - Autentica o usuário, geralmente pra uma tela de login
        public UsuarioDTO AuthenticateUsuario(string nomeUser, string senhaUser)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE NomeUsuario = @nomeUsuario AND SenhaUsuario = @senhaUsuario;", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUser);
                cmd.Parameters.AddWithValue("@senhaUsuario", senhaUser);
                dr = cmd.ExecuteReader();
                UsuarioDTO user = null;

                if (dr.Read())
                {
                    user = new UsuarioDTO();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.NomeUsuario = dr["NomeUsuario"].ToString();
                    user.EmailUsuario = dr["EmailUsuario"].ToString();
                    user.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    user.UrlFotoPerfil = dr["UrlFotoPerfil"].ToString();
                    user.UsuarioTipo = dr["UsuarioTipo"].ToString();
                }
                return user;
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

        //SearchById - Procurar usuário pelo ID
        public UsuarioDTO SearchByIdUsuario(int idUser)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUser);
                dr = cmd.ExecuteReader();
                UsuarioDTO user = null;

                if (dr.Read())
                {
                    user = new UsuarioDTO();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.NomeUsuario = dr["NomeUsuario"].ToString();
                    user.EmailUsuario = dr["EmailUsuario"].ToString();
                    user.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    user.UrlFotoPerfil = dr["UrlFotoPerfil"].ToString();
                    user.UsuarioTipo = dr["UsuarioTipo"].ToString();
                }
                return user;
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

        public bool VerificaUsuarioExistente(string nomeUsuario)
        {
            bool usuarioExistente = false; // Variável para armazenar o resultado
            try
            {
                Conectar(); // Método para abrir a conexão com o banco de dados
                cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE NomeUsuario = @NomeUsuario;", conn); // Substitua "Usuarios" pelo nome da sua tabela
                cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario); // Adiciona o parâmetro

                int count = (int)cmd.ExecuteScalar(); // Executa a consulta e obtém o número de usuários
                usuarioExistente = count > 0; // Se count for maior que 0, o usuário existe
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao verificar usuário existente - {ex.Message}"); // Mensagem de erro
            }
            finally
            {
                Desconectar(); // Método para fechar a conexão com o banco de dados
            }

            return usuarioExistente; // Retorna o resultado da verificação
        }
    }
}
