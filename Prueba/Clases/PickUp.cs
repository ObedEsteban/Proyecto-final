using Prueba.Cosas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Clases
{
    internal class PickUp : VehiculoBase
    {
        public string Llantas { get; set; }
        public string Motor { get; set; }
        public string Radio { get; set; }
        private int Encendido = 0;
        public void Encender1()
        {
            base.Encender();
            Console.WriteLine("Bienvenido a tu vehiculo");
            Encendido = 1;
        }
        public void Abrirventa()
        {
            if (Encendido == 1)
            {
                Console.WriteLine("Abrir ventana");
            }
            else
            {
                Console.WriteLine("No se pueden abrir las ventas o cerrarse");
            }
        }
    }
}
