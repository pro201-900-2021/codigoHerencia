using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoHerencia
{
    class Dinero
    {
        private int valor;
        private string valorEnPalabras;
        private string color;

        public Dinero(int valor, string valorEnPalabras, string color)
        {
            this.valor = valor;
            this.valorEnPalabras = valorEnPalabras;
            this.color = color;
        }

        public Dinero(int valor, string valorEnPalabras)
        {
            this.valor = valor;
            this.valorEnPalabras = valorEnPalabras;
            this.color = "No Hay color";
        }

        public int Valor { get => valor; set => valor = value; }
        public string ValorEnPalabras { get => valorEnPalabras; set => valorEnPalabras = value; }
        public string Color { get => color; set => color = value; }
    }
}
