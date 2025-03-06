using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.BLL
{
    public static class Session
    {
        private static string _nomeUsuario;
        private static int _idUsuario;
        private static string _usuarioTipo;

        public static string nomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }

        public static int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public static string UsuarioTipo
        {
            get { return _usuarioTipo; }
            set { _usuarioTipo = value; }
        }
    }
}