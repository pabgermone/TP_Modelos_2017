using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        private int _idProducto;
        private string _Descripcion;
        private int _Valor;
        private int _Cantidad;

        public int idProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                _idProducto = value;
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

        public int Valor
        {
            get
            {
                return _Valor;
            }
            set
            {
                _Valor = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _Cantidad;
            }
            set
            {
                _Cantidad = value;
            }
        }
    }
}
