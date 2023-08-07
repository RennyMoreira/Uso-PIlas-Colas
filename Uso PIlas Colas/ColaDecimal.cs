using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_PIlas_Colas
{
    public class ColaDecimal //Clase
    {
        private List<decimal> datos;

        public ColaDecimal()
        {
            datos = new List<decimal>();
        }

        public int Cantidad
        {
            get { return datos.Count; }

        }

        public decimal Encolar(decimal n)
        {
            datos.Add(n);
            return n;
        }

        public decimal Descencolar()
        {
            decimal dato = datos[0];
            datos.RemoveAt(0);
            return dato;
        }
    }
}
