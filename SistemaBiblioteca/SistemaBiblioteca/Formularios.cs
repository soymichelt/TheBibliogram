using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capadedatos.Models;

namespace SistemaBiblioteca
{
    class Formularios
    {
        public static List<Inventario> libros_a_prestar = new List<Inventario>();

        public static PERSONAL.VISITANTE.frmBuscar buscarvisitante = new PERSONAL.VISITANTE.frmBuscar();
        public static PERSONAL.VISITANTE.frmVisitante visitante = new PERSONAL.VISITANTE.frmVisitante();
        public static PRESTAMO.SALIDA.frmSalida prestamo = new PRESTAMO.SALIDA.frmSalida();
        public static BIBLIOGRAFIA.INVENTARIO.frmBuscar buscarbibliografia = new BIBLIOGRAFIA.INVENTARIO.frmBuscar();
    }
}
