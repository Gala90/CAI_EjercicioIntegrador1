using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio.Entidades
{
    public class Directivo : Empleado
    {
        public Directivo(int cod, string nombre, string apellido, DateTime fechaIngreso, string tipo, double salario) : base(cod, nombre, apellido, fechaIngreso, tipo, salario)
        {
        }

        public override string GetNombreCompleto()
        {
            return "SR. Director " + this._apellido;
        }
    }
}
