using dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estructura
{
    public class Model
    {
        AtributosProducto[] ap;

        public void Add(AtributosProducto p)
        {
            if (p == null)
            {
                throw new ArgumentException("Error, el producto no puede ser null.");
            }

            if (ap == null)
            {
                ap = new AtributosProducto[1];
                ap[0] = p;
                return;
            }

            AtributosProducto[] tmp = new AtributosProducto[ap.Length + 1];
            Array.Copy(ap, tmp, ap.Length);
            tmp[tmp.Length - 1] = p;
            ap = tmp;
        }
        public decimal CalcularDepreciacion(decimal a, decimal b, decimal c)
        {
            decimal x = (a - b) / c;

            return x;
        }
      

    }




}
