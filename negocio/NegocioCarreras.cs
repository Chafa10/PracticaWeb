using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class NegocioCarreras
    {
        public List<Carreras> listaCarreras()
        {
            List<Carreras> lista = new List<Carreras>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Expediente, Nombre, Modalidad, HorasTotales , EstadoDeLaCarrera from Carreras");
                datos.ejectuarLectura();

                while (datos.Lector.Read())
                {
                    Carreras aux = new Carreras();
                    aux.Expediente = (int)datos.Lector["Expediente"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Modalidad = (string)datos.Lector["Modalidad"];
                    aux.HorasTotales = (int)datos.Lector["HorasTotales"];
                    aux.EstadoDeLaCarrera = (bool)datos.Lector["EstadoDeLaCarrera"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public void agregarCarrera(Carreras nuevaCarrera)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Carreras Values(@nombre, @modalidad, @horasTotales, @estadoDeLaCarrera)");
                datos.setearParametro("@nombre", nuevaCarrera.Nombre);
                datos.setearParametro("@modalidad", nuevaCarrera.Modalidad);
                datos.setearParametro("@horasTotales", nuevaCarrera.HorasTotales);
                datos.setearParametro("@estadoDeLaCarrera", nuevaCarrera.EstadoDeLaCarrera);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
