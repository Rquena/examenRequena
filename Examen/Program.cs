using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class ProductoElectronico
    {
        // Propiedades
        public string Nombre;
        public double Precio;
        public string Marca;

        // Constructor
        public ProductoElectronico(string nombre, double precio, string marca)
        {
            Nombre = nombre;
            Precio = precio;
            Marca = marca;
        }
    }

    // Clase Telefono que hereda de ProductoElectronico
    public class Telefono : ProductoElectronico
    {
        // Propiedad adicional
        public string SistemaOperativo;

        // Constructor
        public Telefono(string nombre, double precio, string marca, string sistemaOperativo)
            : base(nombre, precio, marca)
        {
            SistemaOperativo = sistemaOperativo;
        }
    }

    // Clase Laptop que hereda de ProductoElectronico
    public class Laptop : ProductoElectronico
    {
        // Propiedad adicional
        public int MemoriaRAM;

        // Constructor
        public Laptop(string nombre, double precio, string marca, int memoriaRAM)
            : base(nombre, precio, marca)
        {
            MemoriaRAM = memoriaRAM;
        }
    }

    // Clase Televisor que hereda de ProductoElectronico
    public class Televisor : ProductoElectronico
    {
        // Propiedad adicional
        public string Resolucion;

        // Constructor
        public Televisor(string nombre, double precio, string marca, string resolucion)
            : base(nombre, precio, marca)
        {
            Resolucion = resolucion;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de creación de instancias
            Telefono telefono = new Telefono("iPhone 12", 999.99, "Apple", "iOS");
            Laptop laptop = new Laptop("MacBook Pro", 1499.99, "Apple", 16);
            Televisor televisor = new Televisor("Samsung 4K", 799.99, "Samsung", "3840x2160");

            // Ejemplo de acceso a propiedades
            Console.WriteLine($"Teléfono: {telefono.Nombre}, Sistema Operativo: {telefono.SistemaOperativo}");
            Console.WriteLine($"Laptop: {laptop.Nombre}, Memoria RAM: {laptop.MemoriaRAM} GB");
            Console.WriteLine($"Televisor: {televisor.Nombre}, Resolución: {televisor.Resolucion}");
        }
    }
}



