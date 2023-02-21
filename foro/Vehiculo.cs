using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Unidad_01.foro
{
    internal class Vehiculo
    {
        private string _marca;
        private string _modelo;
        private string _color;
        private int _año;
        private int _kilometraje;
        private int _precio;
        private int _aceleracion;

        public Vehiculo(string marca, string modelo, string color, int año, int kilometraje, int precio, int _aceleracion)
        {
            this._marca = marca;
            this._modelo = modelo;
            this._color = color;
            this._año = año;
            this._kilometraje = kilometraje;
            this._precio = precio;
            this._aceleracion = _aceleracion;
        }

        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Color { get => _color; set => _color = value; }
        public int Año { get => _año; set => _año = value; }
        public int Kilometraje { get => _kilometraje; set => _kilometraje = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Aceleracion { get => _aceleracion; set => _aceleracion = value; }

        public void acelerar(int aceleracion)
        {
            aceleracion = 0;
            aceleracion += 10;

            Console.WriteLine("Acelerando");
            Console.WriteLine(aceleracion);
        }

        public void desacelerar(int aceleracion)
        {
            aceleracion = 0;
            aceleracion -= 10;

            Console.WriteLine("Acelerando");
            Console.WriteLine(aceleracion);
        }
        public override string ToString()
        {
            return "Marca: " + _marca + " Modelo: " + _modelo + " Color: " + _color + " Año: " + _año + " Kilometraje: " + _kilometraje + " Precio: " + _precio + "aceleracion: " + " km/h";
        }
    }
}
