using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Persona
    {   
        public string rut, nombre, apellido, nacimiento, nacionalidad;
        public Persona(string arut, string anombre, string aapellido, string anacimiento, string anacionalidad)
        {
            rut = arut;
            nombre = anombre;
            apellido = aapellido;
            nacimiento = anacimiento;
            nacionalidad = anacionalidad;
        }
        public string informacion(Persona persona)
        {
            return "rut:" + persona.rut + " nombre:" + persona.nombre + " apellido:" + persona.apellido + " nacimiento" + persona.nacimiento + " nacionalidad" + persona.nacionalidad;
        }


    }
}
