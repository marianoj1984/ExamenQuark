using ExamenIntento.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntento.Modelo
{
    internal class Cotizaciones
    {
        private static int num_id;
        private string fecha;
        private string hora;
        private int codVendedor;
        private Prenda prenda;
        private int cantidad;
        private double resultado;

        public Cotizaciones(string fecha, string hora, int cod_Solicitante, Prenda prenda, int cantidad)
        {
            Cotizaciones.Num_id = Num_id + 1;
            this.Fecha = fecha;
            this.Hora = hora;
            this.CodVendedor = cod_Solicitante;
            this.Prenda = prenda;
            this.Cantidad = cantidad;
            this.Resultado = prenda.obtenerPrecio() * cantidad;
        }

        public static int Num_id { get => num_id; set => num_id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int CodVendedor { get => codVendedor; set => codVendedor = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        internal Prenda Prenda { get => prenda; set => prenda = value; }
    }
}
            

