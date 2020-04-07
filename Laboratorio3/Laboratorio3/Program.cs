using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {  
            Funciones cuchufli = new Funciones();


            Console.WriteLine("bienvenido al supermercado");
            Console.WriteLine("1)agregar cliente");
            Console.WriteLine("2)agregar trabajador");
            Console.WriteLine("3)ver clientes");
            Console.WriteLine("4)ver trabajadores");
            Console.WriteLine("5)modificar trabajador");
            Console.WriteLine("6)agregar producto");
            Console.WriteLine("7)ver productos");
            Console.WriteLine("8)comprar");
            Console.WriteLine("9)registro");
            Console.WriteLine("10)salir");
            string num;
            num = "1";
            while (num != "10")
            {
                string numero;
                numero = Console.ReadLine();

                switch(numero)
                {
                    case "1":
                        string rut, nombre, apellido, nacimiento, nacionalidad;
                        Console.WriteLine("ingrese rut:");
                        rut = Console.ReadLine();
                        Console.WriteLine("ingrese nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("ingrese apellido:");
                        apellido = Console.ReadLine();
                        Console.WriteLine("ingrese fecha de nacimiento:");
                        nacimiento = Console.ReadLine();
                        Console.WriteLine("ingrese nacionalidad:");
                        nacionalidad = Console.ReadLine();

                        Cliente cliente2 = new Cliente(rut, nombre, apellido, nacimiento, nacionalidad);
                        cuchufli.agregarpersona(cliente2);

                        break;

                    case "2":
                        string  pdetrabajo, sueldo, htrabajo;
                        Console.WriteLine("ingrese rut:");
                        rut = Console.ReadLine();
                        Console.WriteLine("ingrese nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("ingrese apellido:");
                        apellido = Console.ReadLine();
                        Console.WriteLine("ingrese fecha de nacimiento:");
                        nacimiento = Console.ReadLine();
                        Console.WriteLine("ingrese nacionalidad:");
                        nacionalidad = Console.ReadLine();
                        Console.WriteLine("ingrese puesto de trabajo:");
                        pdetrabajo = Console.ReadLine();
                        Console.WriteLine("ingrese sueldo:");
                        sueldo = Console.ReadLine();
                        Console.WriteLine("ingrese horario:");
                        htrabajo = Console.ReadLine();
                        Trabajador trabajador2 = new Trabajador(rut, nombre, apellido, nacimiento, nacionalidad, pdetrabajo, sueldo, htrabajo);
                        cuchufli.agregartrabajador(trabajador2);

                        break;

                    case "3":
                        cuchufli.verpersonas();

                        break;
                    case "4":
                        cuchufli.vertrabajadores();

                        break;
                    case "5":
                        cuchufli.cambiarpuesto();

                        break;
                    case "6":
                        string np, marca, precio;
                        int stock;

                        Console.WriteLine("ingrese nombre del producto:");
                        np = Console.ReadLine();
                        Console.WriteLine("ingrese precio del producto:");
                        precio = Console.ReadLine();
                        Console.WriteLine("ingrese marca del producto:");
                        marca = Console.ReadLine();
                        Console.WriteLine("ingrese cantidad del producto:");
                        stock = Convert.ToInt32(Console.ReadLine());
                        Productos producto1 = new Productos(np, precio, marca, stock);
                        cuchufli.agregarproducto(producto1);

                        break;
                    case "7":
                        cuchufli.verproductos();

                        break;
                    case "8":
                        cuchufli.comprar();

                        break;
                    case "9":
                        cuchufli.registro();
                        break;
                    case "10":
                        break;
                                     


                }
                if (numero == "10")
                    break;

            }


            }
    }
}
