using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Unidad_01.foro
{
    internal class Motocicleta: Vehiculo
    {
        private string _cilindrada;

        public Motocicleta(string marca, string modelo, string color, int año, int kilometraje, int precio,int _aceleracion, in string cilindrada) : base(marca, modelo, color, año, kilometraje, precio, _aceleracion)
        {
            this._cilindrada = cilindrada;
        }

        public string Cilindrada { get => _cilindrada; set => _cilindrada = value; }

        public override string ToString()
        {
            return base.ToString() + " Cilindrada: " + _cilindrada;
        }
    }
    

    }

