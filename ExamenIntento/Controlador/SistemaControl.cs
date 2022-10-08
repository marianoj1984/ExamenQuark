using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenIntento.Modelo;

namespace ExamenIntento.Controlador
{
    internal class SistemaControl
    {
        private Tienda nuevatienda;
        private Vendedor nuevoVendedor;
        public SistemaControl(string nomTienda, string dirTienda, string nombreVend, string apeVend, int idVend)
        {
            CargarTienda(nomTienda, dirTienda);
            CargarVendedor(nombreVend, apeVend, idVend);
        }
        private void CargarTienda(string nombreTienda, string direccion)
        {
            this.nuevatienda = new Tienda(nombreTienda, direccion);
        }
        private void CargarVendedor(string nombre, string apellido, int cod)
        {
            this.nuevoVendedor = new Vendedor(nombre, apellido, cod);
        }
        public void CargarCamisa(string cuello, string manga, int stock, string calidad, double precio)
        {
            Camisa camisa = new Camisa(cuello, manga, stock, calidad, precio);
            this.nuevatienda.agregarPrenda(camisa);
        }
        public void CargarPantalon(string clase, int stock, string calidad, double precio)
        {
            Pantalon pantalon = new Pantalon(clase, stock, calidad, precio);
            this.nuevatienda.agregarPrenda(pantalon);
        }
        public Camisa VerCamisa(string cuello, string manga, string calidad)
        {
            return this.nuevatienda.verCamisa(cuello, manga, calidad);
        }
        public Pantalon VerPantalon(string clase, string calidad)
        {
            return this.nuevatienda.verPantalon(clase, calidad);
        }
        public Tienda VerTienda()
        {
            return this.nuevatienda;
        }
        public Vendedor VerVendedor()
        {
            return this.nuevoVendedor;
        }
        public double cotizar(Prenda prenda, int cant)
        {
            return this.nuevoVendedor.cotizar(prenda, cant);
        }
        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
