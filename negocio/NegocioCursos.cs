using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class NegocioCursos
    {
        public void agregarCurso(Cursos nuevoCurso)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Cursos Values(@nombre, @expedienteCarrera, @caracteristica)");
                datos.setearParametro("@nombre",nuevoCurso.Nombre);
                datos.setearParametro("@expedienteCarrera", nuevoCurso.ExpedienteCarrera);
                datos.setearParametro("@caracteristica", nuevoCurso.Caracteristica);

                datos.ejecutarAccion();
               
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
