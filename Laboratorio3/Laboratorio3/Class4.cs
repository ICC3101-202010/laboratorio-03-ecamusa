using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Productos
    {
        public string nombre, marca, precio;
        public int stock;
        public Productos(string anombre, string aprecio, string amarca, int astock)
        {
            nombre = anombre;
            precio = aprecio;
            marca = amarca;
            stock=astock;
        }

        public string informacionp(Productos producto)
        {
            return "nombre:" + producto.nombre + " precio:" + producto.precio + " marca:" + producto.marca + " stock:" + producto.stock;
        }
    }



    class Comprar
    {
        public string fecha, hora, clienterut, cajero;

        public Comprar(string aclienterut, string afecha, string ahora,string acajero )
        {
            clienterut = aclienterut;
            fecha = afecha;
            hora = ahora;
            cajero = acajero;
        }

        public string informacioncompra(Comprar compra)
        {
            return "rut del cliente:" + clienterut + " fecha:" + fecha + " hora:" + hora + " cajero:"+cajero;
        }

    }
    class Venta
    {
        public string nombre, marca, num;

        public Venta(string anombre, string amarca, string anum)
        {
            nombre = anombre;
            marca = amarca;
            num = anum;
        }


        public string informacionventa(Venta venta)
        {
            return "nombre producto:" + venta.nombre + " marca:" + venta.marca + " cantidad:" + venta.num;
        }
    }
    class registro
    {
        string rut, fecha, hora, cajero, producto, marca, stock;
        public registro(string arut,string afecha,string ahora, string acajero, string aproducto, string amarca, string astock)
        {
            rut = arut;
            fecha=afecha;
            hora = ahora;
            cajero = acajero;
            producto = aproducto;
            marca = amarca;
            stock = astock;

        }

        public string historial()
        {
            return "rut cliente:" + rut + " fecha:" + fecha + " hora" + hora + " cajero:" + cajero + " producto:" + producto + " marca:" + marca + " cantidad:" + stock;
        }
    }

       


}
