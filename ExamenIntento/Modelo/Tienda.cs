using ExamenIntento.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntento.Modelo
{
    internal class Tienda
    {
        private string nombreTienda;
        private string direccion;
        List<Prenda> listaPrendas = new List<Prenda>();

        public Tienda(string nombreTienda, string direccion)
        {
            this.nombreTienda = nombreTienda;
            this.direccion = direccion;
        }

        public void agregarPrenda(Prenda prenda)
        {
            listaPrendas.Add(prenda);
        }
        public Prenda verPrenda(int indice)
        {
            return listaPrendas[indice];
        }
        public Camisa verCamisa(string cuello, string manga, string calidad)
        {
            foreach(Prenda ca in listaPrendas)
            {
                string buscado = "Camisa" + cuello + manga + calidad;
                if(ca.Tipo==buscado)
                {
                    Camisa aux = (Camisa)ca;
                    return aux;
                }
            }
            return null;
        }
        public Pantalon verPantalon(string clase, string calidad)
        {
            foreach (Prenda pa in listaPrendas)
            {
                string buscado = "Pantalón" + clase + calidad;
                if (pa.Tipo == buscado)
                {
                    Pantalon aux = (Pantalon)pa;
                    return aux;
                }
            }
            return null;
        }
        public string NombreTienda { get => nombreTienda; set => nombreTienda = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prenda> ListaPrendas { get => listaPrendas; set => listaPrendas = value; }
    }
}
