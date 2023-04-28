using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class NegocioMaterias
    {
        public void altaMateria(Materias nuevaMateria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Materias Values(@nombre, @horas)");
                datos.setearParametro("@nombre", nuevaMateria.Nombre);
                datos.setearParametro("@horas", nuevaMateria.Horas);
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

        public List<Materias> listaMaterias()
        {
            List<Materias> lista = new List<Materias>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdMateria, Nombre, Horas from Materias");
                datos.ejectuarLectura();
                while (datos.Lector.Read())
                {
                    Materias auxiliar = new Materias();
                    auxiliar.IdMateria = (int)datos.Lector["IdMateria"];
                    auxiliar.Nombre = (string)datos.Lector["Nombre"];
                    auxiliar.Horas = (int)datos.Lector["Horas"];

                    lista.Add(auxiliar);
                }

                return lista;
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
