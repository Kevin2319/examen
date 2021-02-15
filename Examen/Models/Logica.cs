using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class Logica
    {
        public AUTOMOVIL auto(string id)
        {
            try
            {
                using (examenEntities db = new examenEntities())
                {
                    var marca = db.AUTOMOVIL.Where(x => x.MARCA == id).FirstOrDefault();
                    return marca;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DIRECCIONES codigo(string id)
        {
            try
            {
                using (examenEntities db = new examenEntities())
                {
                    var cp = db.DIRECCIONES.Where(x => x.CODIGO_POSTAL == id).FirstOrDefault();
                    return cp;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertCoche(ADMINISTRADOR objeto)
        {
            try
            {
                
                using (examenEntities db = new examenEntities())
                {
                  
                    db.ADMINISTRADOR.Add(objeto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}