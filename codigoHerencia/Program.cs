using System;

namespace codigoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Billete hereda las propiedades, funciones, atributos. No es lo mismo que se diga que se puede acceder a ellos. Si algo es declarado private, no se puede acceder, aunque sea hija.
            //recordar que al ser private, solo se puede acceder desde la misma clase, ni los hijos ni los padres son la excepción a esa regla
            Billete billete = new Billete(7, 2, 1000, "Mil", "Verde");
            Console.WriteLine(billete.Ancho);
            Console.WriteLine(billete.Largo);
            Console.WriteLine(billete.Valor);
            Console.WriteLine(billete.ValorEnPalabras);
            Console.WriteLine(billete.Color);

            Moneda moneda = new Moneda(10, 0, 100, "Cien", "Bronce");
            Console.WriteLine(moneda.PesoG);
            Console.WriteLine(moneda.Lados);
            Console.WriteLine(moneda.Valor);
            Console.WriteLine(moneda.ValorEnPalabras);
            Console.WriteLine(moneda.Color);
        }
    }
}
