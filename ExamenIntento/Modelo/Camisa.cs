using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntento.Modelo
{
    internal class Camisa: Prenda
    {
        private string cuello;
        private string mangas;
        private int stock;
        private string calidad;
        public Camisa(string cuello, string mangas, int stock, string calidad, double precio) : base("Camisa"+cuello+mangas+calidad, precio)
        {
            this.Cuello = cuello;
            this.Mangas = mangas;
            this.Stock = stock;
            this.Calidad = calidad;
        }

        public string Cuello { get => cuello; set => cuello = value; }
        public string Mangas { get => mangas; set => mangas = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Calidad { get => calidad; set => calidad = value; }

        public override double obtenerPrecio()
        {
            double precio = base.PrecioBase;
            if (this.mangas == "M/C")
            {
                precio -= precio * 0.1;
                if (this.cuello == "Mao")
                {
                    precio += precio * 0.03;
                }
            }
            else
            {
                if (this.cuello == "Mao")
                {
                    precio += precio * 0.03;
                }
            }
            if (this.calidad == "Premium")
            {
                precio += precio * 0.3;
            }

            return precio;
        }

    }
}
