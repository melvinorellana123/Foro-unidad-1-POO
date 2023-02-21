using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Unidad_01.foro
{
    internal class Carro : Vehiculo
    {
        private int numeroPuertas;
        private bool cuatrox4;
        public Carro(string marca, string modelo, string color, int año, int kilometraje, int precio,int _aceleracion, int numeroPuertas, bool cuatrox4) : base(marca, modelo, color, año, kilometraje, precio, _aceleracion)
        {
            this.numeroPuertas = numeroPuertas;
            this.cuatrox4 = cuatrox4;
        }

        



        public override string ToString()
        {
            return base.ToString() + " Numero de puertas: " + numeroPuertas + " Cuatro por cuatro: " + cuatrox4;
        }

    }
}

