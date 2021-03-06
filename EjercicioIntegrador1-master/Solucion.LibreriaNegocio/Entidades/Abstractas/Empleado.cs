﻿using Solucion.LibreriaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public abstract class Empleado : Persona
    {
        private int _legajo;
        private Salario _ultimoSalario;
        private DateTime _fechaIngreso;
        private string _tipo;        
        private string _materia;

        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }
        public int Legajo { get => _legajo; set => _legajo = value; }
        public Salario UltimoSalario { get => _ultimoSalario; set => _ultimoSalario = value; }

 
        public string Tipo { get => _tipo; set => _tipo = value; }

        public string Materia { get => _materia; set => _materia = value; }






        public override string GetNombreCompleto()
        {
            return this.Apellido;
        }



        public override string GetCredencial()
        {
            string ficha = string.Format("Empleado {0} - {1} - {2}", this.Legajo, GetNombreCompleto(), "Salario: " + this._ultimoSalario.GetSalarioNeto());


            if (this.Tipo.ToUpper() == "D")
            {
                string ficha2 = string.Format("Empleado {0} - {1} - {2} - {3}", this.Legajo, GetNombreCompleto(), "Salario: " + this._ultimoSalario.GetSalarioNeto(), "Materia: " + this.Materia);

                return ficha2;

            }
            else
            {
                return ficha;
            }


        }

        public Empleado(int cod, string nombre, string apellido, DateTime fechaIngreso, string tipo, double bruto)
        {
            this.Legajo = cod;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._fechaIngreso = fechaIngreso;
            this._tipo = tipo;
            this._ultimoSalario = new Salario(bruto);
            


        }


        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Empleado))
            {
                return false;
            }
            return (this.Legajo == ((Empleado)obj).Legajo);

        }
    }
}

