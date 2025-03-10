using Biblio2.DAL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblio2.BLL.UsuarioBLL;

namespace Biblio2.BLL
{
    public class UsuarioBLL
    {
        //Objetos globais
        UsuarioDTO userDTO = new UsuarioDTO();
        UsuarioDAL userDAL = new UsuarioDAL();

        //CRUD

        //CREATE
        public void CreateUsuarioBLL(UsuarioDTO user)
        {
            userDAL.CreateUsuario(user);
        }

        //READ
        public List<UsuarioDTO> GetUsuarioBLL()
        {
            return userDAL.GetUsuario();
        }

        //UPDATE
        public void UpdateUsuarioBLL(UsuarioDTO user)
        {
            userDAL.UpdateUsuario(user);
        }

        //DELETE
        public void DeleteUsuarioBLL(int idUser)
        {
            userDAL.DeleteUsuario(idUser);
        }

        //FUNÇÕES EXTRAS

        //GetType - pra colocar num DropDown ou ComboBox
        public List<TipoUsuarioDTO> GetTipoUsuarioBLL()
        {
            return userDAL.GetTipoUsuario();
        }

        //Authenticate
        public UsuarioDTO AuthenticateUsuarioBLL(string user, string password)
        {
            return userDAL.AuthenticateUsuario(user, password);

        }

        //SearchById
        public UsuarioDTO SearchByIdUsuarioBLL(int idUser)
        {
            return userDAL.SearchByIdUsuario(idUser);
        }

        //TALVEZ SEJA ADICIONADO

        //SearchByName
        //public UsuarioDTO SearchByNameUsuarioBLL(string nomeUser)
        //{
        //    return userDAL.SearchByNameUsuario(nomeUser);
        //}

        public bool VerificaUsuarioExistenteBLL(string nomeUsuario)
        {
            return userDAL.VerificaUsuarioExistente(nomeUsuario);
        }

    }
}
