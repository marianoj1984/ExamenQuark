using ExamenIntento.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntento.Modelo
{
    internal class Vendedor
    {
        private string Nombre;
        private string Apellido;
        private int cod_id;
        private List<Cotizaciones> listaCotizaciones = new List<Cotizaciones>();

        public Vendedor(string nombre, string apellido, int cod_id)
        {
            Nombre1 = nombre;
            Apellido1 = apellido;
            this.Cod_id = cod_id;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public int Cod_id { get => cod_id; set => cod_id = value; }
        public List<Cotizaciones> ListaCotizaciones { get => listaCotizaciones; set => listaCotizaciones = value; }

        public double cotizar(Prenda prenda, int cantidad)
        {
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            string hora = DateTime.Now.ToString("hh:mm:ss tt");
            Cotizaciones cotiz_aux = new Cotizaciones(fecha, hora, this.Cod_id, prenda, cantidad);
            listaCotizaciones.Add(cotiz_aux);
            return cotiz_aux.Resultado;
        }
    }
}
