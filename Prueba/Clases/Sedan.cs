using Prueba.Cosas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Clases
{
    internal class Sedan : VehiculoBase
    {
        public string Gabinete { get; set; }
        public string Sillones { get; set; }
        public string Aceite { get; set; }
        private int Encendido = 0;
        private int baul = 0;
        public void EncenderSedan()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("El sedan se ha encendido");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("El sedan esta apagado");
            }
        }
        public void Abrirbaul()
        {
            if (baul == 0)
            {
                Console.WriteLine("Abir baul");
                baul = 1;
            }
            else
            {
                Console.WriteLine("El baul ya esta abierto");
            }
        }
        public void Cerrarbaul()
        {
            if (baul == 1)
            {
                Console.WriteLine("Cerrar bahul");
                baul = 0;
            }
            else
            {
                Console.WriteLine("El baul ya esta cerrado");
            }
        }
    }
}
