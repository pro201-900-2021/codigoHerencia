using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoHerencia
{
    class Billete : Dinero //Dos puntos seguido de la clase, es la sintaxis para heredar de una clase
    {
        private int largo;
        private int ancho;

        //la palabra reservada "base" apunta al constructor del padre del que queremos hacer uso al generar el constructor del hijo
        public Billete(int largo, int ancho, int valor, string valorEnPalabras, string color) : base(valor, valorEnPalabras, color)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public int Largo { get => largo; set => largo = value; }
        public int Ancho { get => ancho; set => ancho = value; }
    }
}
