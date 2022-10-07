using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntento.Modelo
{
    internal class Pantalon: Prenda
    {
        private string clase;
        private int stock;
        private string calidad;
        public Pantalon(string clase, int stock, string calidad, double precio) : base("Pantalón"+clase+calidad, precio)
        {
            this.Clase = clase;
            this.Stock = stock;
            this.Calidad = calidad;       
        }

        public string Clase { get => clase; set => clase = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Calidad { get => calidad; set => calidad = value; }

        public override double obtenerPrecio()
        {
            double precio = base.PrecioBase;
            if (this.clase == "Chupín")
            {
                precio -= precio * 0.12;
                if (this.calidad == "Premium")
                {
                    precio += precio * 0.30;
                }
            }
            else
            {
                if (this.calidad == "Premium")
                {
                    precio += precio * 0.30;
                }
            }
            return precio;
        }
    }
}
