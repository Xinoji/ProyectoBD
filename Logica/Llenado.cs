using ProyectoBD.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.Logica
{
    public abstract class Llenado : DbConnection
    {
        public void Correctupdate(int folio, DateTime Fecha,string maquina, string mecanico, decimal parada, decimal reparacion, string descripcion, string operador, string causa, string solucion)
        {
            
        }
        public void Preventupdate(DateTime Fecha, string maquina, string mecanico, decimal parada, decimal reparacion, string descripcion)
        {

        }
        public void insert(DateTime Fecha, string maquina, string mecanico, decimal parada, decimal reparacion, string descripcion, string operador, string causa, string solucion)
        {

        }

    }

    

}
