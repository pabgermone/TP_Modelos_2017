using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        private int _idUsuario;
        private string _Nombres;
        private string _Contraseña;
        private int _Rol;

        public string Contraseña
        {
            get
            {
                return _Contraseña;
            }
            set
            {
                _Contraseña = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombres;
            }
            set
            {
                _Nombres = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return _idUsuario;
            }
            set
            {
                _idUsuario = value;
            }
        }

        public int Rol
        {
            get
            {
                return _Rol;
            }
            set
            {
                _Rol = value;
            }
        }
    }
}
