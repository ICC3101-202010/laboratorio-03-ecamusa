using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Cliente : Persona
    {  
        public Cliente(string arut,string anombre,string aapellido,string anacimiento ,string anacionalidad): base(arut,anombre,aapellido,anacimiento,anacionalidad)
        {

        }
    }
    class Trabajador
    {   
        public string rut, nombre, apellido, nacimiento, nacionalidad, sueldo, pdetrabajo, htrabajo;
        public Trabajador(string arut, string anombre, string aapellido, string anacimiento, string anacionalidad, string apdetrabajo, string asueldo, string ahtrabajo)
        {
            rut = arut;
            nombre = anombre;
            apellido = aapellido;
            nacimiento = anacimiento;
            nacionalidad = anacionalidad;
            pdetrabajo = apdetrabajo;
            sueldo = asueldo;
            htrabajo = ahtrabajo;
        }
        public string informaciont(Trabajador trabajador)
        {
            return "rut:" + trabajador.rut + " nombre:" + trabajador.nombre + " apellido:" + trabajador.apellido + "  nacimiento:" + trabajador.nacimiento + " nacionalidad:" + trabajador.nacionalidad + " puesto de trabajo:" + trabajador.pdetrabajo + " sueldo:" + trabajador.sueldo + " horario de trabajo:" + trabajador.htrabajo;
        }



    }
}
