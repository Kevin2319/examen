using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class ADMON
    {
        public int ID { get; set; }
        public string MARCA { get; set; }
        public string SUBMARCA { get; set; }
        public string TIPO { get; set; }
        public string MODELO { get; set; }
        public string DESCRIPCION { get; set; }
        public string CODIGO_POSTAL { get; set; }
        public string ESTADO { get; set; }
        public string MUNICIPIO { get; set; }
        public string COLONIA { get; set; }
        public Nullable<System.DateTime> FECHA_NACIMIENTO { get; set; }
        public string GENERO { get; set; }
    }
}