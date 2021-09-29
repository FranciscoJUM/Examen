using dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
        public decimal CalculardepreporAsd(decimal a, decimal c)
        {
            decimal numero = (c * (c + 1)) / 2;

            decimal final = c / numero;

            decimal año1 = (a * final) / 100;



            return año1; }
        public decimal CalculardepreporAsd2(decimal a, decimal c)
        {  
                decimal num = ((c - 1) * (c  ))/ 2;
            if (num == 0) 
            { return 0; }
                decimal fi = (c - 1) / num;

                decimal año2 = (a * fi) / 100;


                return año2;
           
               
            }
       
        }
    
    }





