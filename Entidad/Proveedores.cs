using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Proveedores
    {
        private int _idProveedor;
        private string _Descripcion;
        private string _DVH;
        private string _Direccion;

        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion = value;
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

        public string DVH
        {
            get
            {
                return _DVH;
            }
            set
            {
                _DVH = value;
            }

        }

        public int idProveedor
        {
            get
            {
                return _idProveedor;
            }
            set
            {
                _idProveedor = value;
            }
        }
    }
}
