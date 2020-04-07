using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Funciones
    {
        public Funciones()
        {

        }

        List<List<string>> listagrande = new List<List<string>>();
        public List<string> listatrabajo(Trabajador trabajador)
        {
            List<string> trabajo = new List<string>();
            trabajo.Add(trabajador.rut);
            trabajo.Add(trabajador.nombre);
            trabajo.Add(trabajador.apellido);
            trabajo.Add(trabajador.nacimiento);
            trabajo.Add(trabajador.nacionalidad);
            trabajo.Add(trabajador.pdetrabajo);
            trabajo.Add(trabajador.sueldo);
            trabajo.Add(trabajador.htrabajo);
            listagrande.Add(trabajo);
            return trabajo;
        }

        List<string> trabajadorchico = new List<string>();
        List<List<string>> trabajadorgrande = new List<List<string>>();
        List<string> trabajadores = new List<string>();


        public bool agregartrabajador(Trabajador trabajador)
        {
            if (trabajadorchico.Contains(trabajador.rut))
                return false;
            else
                trabajadorchico.Add(trabajador.rut);
            trabajadorchico.Add(trabajador.nombre);
            trabajadorchico.Add(trabajador.apellido);
            trabajadorchico.Add(trabajador.nacimiento);
            trabajadorchico.Add(trabajador.nacionalidad);
            trabajadorchico.Add(trabajador.pdetrabajo);
            trabajadorchico.Add(trabajador.sueldo);
            trabajadorchico.Add(trabajador.htrabajo);
            trabajadorgrande.Add(trabajadorchico);
            trabajadores.Add(trabajador.informaciont(trabajador));

            return true;


        }

        public void vertrabajadores()
        {
            foreach (var a in trabajadores)
                Console.WriteLine(a);
        }

        public void cambiarpuesto()
        {
            string rut, nombre, apellido, nacimiento, nacionalidad, pdetrabajo, sueldo, htrabajo;
            int num, num2, i, z;
            i = 0;
            z = 0;
            num = trabajadorgrande.Count();
            num2 = trabajadorgrande.Count();
            Console.WriteLine("ingrese rut del trabajador a modificar:");
            string rutt;
            rutt = Console.ReadLine();


            while (i != num)
            {
                if (trabajadorgrande[i][0] == rutt)
                {
                    Console.WriteLine(trabajadorgrande[0][1]);
                    Console.WriteLine(trabajadorgrande[i].Count);
                    trabajadorgrande[i].RemoveAt(trabajadorgrande[i].Count - 1);
                    trabajadorgrande[i].RemoveAt(trabajadorgrande[i].Count - 1);
                    trabajadorgrande[i].RemoveAt(trabajadorgrande[i].Count - 1);

                    Console.WriteLine("ingrese nuevo puesto de trabajo:");
                    trabajadorgrande[i].Add(Console.ReadLine());
                    Console.WriteLine("ingrese nuevo sueldo:");
                    trabajadorgrande[i].Add(Console.ReadLine());
                    Console.WriteLine("ingrese nuevo horario:");
                    trabajadorgrande[i].Add(Console.ReadLine());
                    i++;
                }
                else
                    i++;


            }

            trabajadores.Clear();

            Console.WriteLine(trabajadorgrande[z].Count());
            while (z != num2)
            {

                rut = trabajadorgrande[z][0];
                nombre = trabajadorgrande[z][1];
                apellido = trabajadorgrande[z][2];
                nacimiento = trabajadorgrande[z][3];
                nacionalidad = trabajadorgrande[z][4];
                pdetrabajo = trabajadorgrande[z][5];
                sueldo = trabajadorgrande[z][6];
                htrabajo = trabajadorgrande[z][7];
                Trabajador trabajador1 = new Trabajador(rut, nombre, apellido, nacimiento, nacionalidad, pdetrabajo, sueldo, htrabajo);
                trabajadores.Add(trabajador1.informaciont(trabajador1));
                z++;

            }






        }




        List<string> personachica = new List<string>();
        List<List<string>> personasgrande = new List<List<string>>();
        List<string> personas = new List<string>();

        public bool agregarpersona(Persona persona)
        {
            if (personachica.Contains(persona.rut))
                return false;
            else
                personachica.Add(persona.rut);
            personachica.Add(persona.nombre);
            personachica.Add(persona.apellido);
            personachica.Add(persona.nacimiento);
            personachica.Add(persona.nacionalidad);
            personasgrande.Add(personachica);
            personas.Add(persona.informacion(persona));

            return true;


        }
        public void verpersonas()
        {
            foreach (var a in personas)
                Console.WriteLine(a);



        }



        List<string> productochico = new List<string>();
        List<string> productos = new List<string>();
        List<List<string>> productogrande = new List<List<string>>();

        public bool agregarproducto(Productos producto)
        {
            if (productochico.Contains(producto.nombre) && productochico.Contains(producto.marca))
                return false;
            else
                productochico.Add(producto.nombre);
            productochico.Add(producto.precio);
            productochico.Add(producto.marca);
            productochico.Add(Convert.ToString(producto.stock));
            productogrande.Add(productochico);
            productos.Add(producto.informacionp(producto));
            return true;
        }

        public void verproductos()
        {
            foreach (var a in productos)
                Console.WriteLine(a);

        }

        List<string> informacioncompra = new List<string>();
        List<List<string>> informaciongrande = new List<List<string>>();
        List<string> registros = new List<string>();
        List<List<string>> registrosgrande = new List<List<string>>();
        public void comprar()
        {
            string nombre, fecha, hora, marca, restastring, ncant, rutcliente, cajero,nombre2,marca2,precio2;
            int resta,num,num2,i,z,cant,cantf,stock2;

            Console.WriteLine("ingrese rut del cliente:");
            rutcliente = Console.ReadLine();
            Console.WriteLine("ingrese fecha:");
            fecha = Console.ReadLine();
            Console.WriteLine("ingrese hora");
            hora = Console.ReadLine();
            Console.WriteLine("ingrese cajero:");
            cajero = Console.ReadLine();
            Console.WriteLine("ingrese nombre del producto:");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese marca del producto:");
            marca = Console.ReadLine();
            Console.WriteLine("ingrese el numero de las unidades  que quiere:");
            restastring = Console.ReadLine();
            resta = Convert.ToInt32(restastring);
            num = productogrande.Count();
            num2=productogrande.Count();
            i = 0;
            z = 0;
            registros.Add(rutcliente);
            registros.Add(fecha);
            registros.Add(hora);
            registros.Add(cajero);
            registros.Add(nombre);
            registros.Add(marca);
            registros.Add(restastring);
            registrosgrande.Add(registros);



            Comprar compra1 = new Comprar(rutcliente, fecha, hora, cajero);
            List<string> informacioncompra2 = new List<string>();
            informacioncompra.Add(compra1.informacioncompra(compra1));


            Venta venta1 = new Venta(nombre, marca, Convert.ToString(resta));
            informacioncompra2.Add(venta1.informacionventa(venta1));
            


            while (i != num)
            {
                if (productogrande[i][0] == nombre && productogrande[i][2] == marca)
                {
                    cant = Convert.ToInt32(productogrande[i][3]);
                    productogrande[i].RemoveAt(productogrande[i].Count - 1);
                    cantf = cant - resta;
                    ncant = Convert.ToString(cantf);
                    productogrande[i].Add(ncant);
                    if (cantf <= 0)
                    {
                        Console.WriteLine( "el producto se acabo o lleva mas producto de lo que hay");
                    }
                    i++;


                }
                else
                    i++;

            }
            productos.Clear();
            while (z!=num2)
            {   nombre2 = productogrande[z][0];
                precio2 = productogrande[z][1];
                marca2 = productogrande[z][2];
                stock2 = Convert.ToInt32(productogrande[z][3]);
                Productos producto1 = new Productos(nombre2, precio2, marca2, stock2);
                productos.Add(producto1.informacionp(producto1));
                z++;



            }

            
          
            

       





        }

        List<string> registrof = new List<string>();
        public void registro()
        {
            int i,num;
            string rut, fecha, hora,cajero, producto, marca, cantidad;
            num = registrosgrande.Count();
            i = 0;

            
            while (i!= num)
            {
                rut = registrosgrande[i][0];
                fecha = registrosgrande[i][1];
                hora = registrosgrande[i][2];
                cajero = registrosgrande[i][3];
                producto = registrosgrande[i][4];
                marca = registrosgrande[i][5];
                cantidad = registrosgrande[i][6];

                registro registro1 = new registro(rut, fecha, hora, cajero,producto,marca,cantidad);
                registrof.Add(registro1.historial());
                
                i++;



            }
            foreach (var a in registrof)
                Console.WriteLine(a);
        }
    }
}








    
