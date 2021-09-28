using dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace dominio
{
    public class AtributosProducto
    {

        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorRecidual { get; set; }
        public decimal VidaUtil { get; set; }
        public DateTime FechaDeAdquicision { get; set; }
        public TipoActivo Activo { get; set; }





    }
}
