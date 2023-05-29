using Prueba.Cosas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Clases
{
    internal class SUV : VehiculoBase
    {
        public string Pequeño { get; set; }
        public string Seguro { get; set; }
        public string Economico { get; set; }

        private int Encendido = 0;
        private int capo = 0;
        public void EncenderSUV()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("Se ha encendido el suv");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("El auto ya esta apagado");
            }
        }
        public void Abrircapo()
        {
            if (capo == 0)
            {
                Console.WriteLine("Abrir capo");
                capo = 1;
            }
            else
            {
                Console.WriteLine("El capo ya esta abierto");
            }
        }
    }
}
