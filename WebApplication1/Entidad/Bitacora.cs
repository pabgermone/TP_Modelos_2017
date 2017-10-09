using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Bitacora
    {
        private int _idRegistro;
        private string _Descripcion;
        private string _Usuario;
        private DateTime _Fecha;

        public int idRegistro
        {
            get
            {
                return _idRegistro;
            }
            set
            {
                _idRegistro = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }
        public string Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                _Usuario = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }
    }
}
