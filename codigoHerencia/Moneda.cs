using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoHerencia
{
    class Moneda : Dinero
        //Dos puntos seguido de la clase, es la sintaxis para heredar de una clase
    {
        private int pesoG;
        private int lados;

        //la palabra reservada "base" apunta al constructor del padre del que queremos hacer uso al generar el constructor del hijo
        public Moneda(int pesoG, int lados, int valor, string valorEnPalabras, string color) : base(valor, valorEnPalabras, color)
        {
            this.pesoG = pesoG;
            this.lados = lados;
        }

        public Moneda(int pesoG, int lados, int valor, string valorEnPalabras) : base(valor, valorEnPalabras)
        {
            this.pesoG = pesoG;
            this.lados = lados;
        }

        public int PesoG { get => pesoG; set => pesoG = value; }
        public int Lados { get => lados; set => lados = value; }
    }
}
