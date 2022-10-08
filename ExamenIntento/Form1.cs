using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenIntento.Controlador;
using ExamenIntento.Modelo;


namespace ExamenIntento
{
    public partial class Form1 : Form
    {
        SistemaControl control1 = new SistemaControl("El placard de 007", "Av Santa Fe 1234", "James", "Bond", 007);
   
        public Form1()
        {
            control1.CargarCamisa("Mao", "M/C", 100, "Premium", 100);
            control1.CargarCamisa("Mao", "M/C", 100, "Standar", 100);
            control1.CargarCamisa("Común", "M/C", 150, "Premium", 100);
            control1.CargarCamisa("Común", "M/C", 150, "Standar", 100);
            control1.CargarCamisa("Mao", "M/L", 75, "Premium", 100);
            control1.CargarCamisa("Mao", "M/L", 75, "Standar", 100);
            control1.CargarCamisa("Común", "M/L", 175, "Premium", 100);
            control1.CargarCamisa("Común", "M/L", 175, "Standar", 100);
            control1.CargarPantalon("Chupín", 750, "Premium", 100);
            control1.CargarPantalon("Chupín", 750, "Standar", 100);
            control1.CargarPantalon("Común", 250, "Premium", 100);
            control1.CargarPantalon("Común", 250, "Standar", 100);

            InitializeComponent();
            lblNombreTienda.Text = control1.VerTienda().NombreTienda;
            lblDireccion.Text = control1.VerTienda().Direccion;
            lblNomVendedor.Text = "Vendedor: "+control1.VerVendedor().Nombre1 + " " + control1.VerVendedor().Apellido1;
            lblCod_id.Text ="Cod: "+ Convert.ToString(control1.VerVendedor().Cod_id);
            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Standar").Stock);
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (txtCantidadSolicitada.Text != "")
            {
                int cant = Convert.ToInt16(txtCantidadSolicitada.Text);
                int disponible = Convert.ToInt16(lblUnidadesDispo.Text);
                if (cant > disponible || cant < 0)
                {
                    MessageBox.Show("La cantidad solicitada NO puede se mayor al stock disponible, vuelva a intentar");
                }
                else
                {

                    if (radioCamisa.Checked)
                    {

                        if (checkMangaCorta.Checked)
                        {
                            if (checkCuelloMao.Checked)
                            {
                                if (radioPremium.Checked)
                                {
                                    lblResultado.Text ="$ "+ Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Mao", "M/C", "Premium"),cant));
                                }
                                else
                                {
                                    lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Mao", "M/C", "Standar"), cant));
                                }
                                
                            }
                            else
                            {
                                if (radioPremium.Checked)
                                {
                                    lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Común", "M/C", "Premium"), cant));
                                }
                                else
                                {
                                    lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Común", "M/C", "Standar"), cant));
                                }
                                
                            }
                        }
                        else
                        {
                            if (checkCuelloMao.Checked)
                            {
                                if (radioPremium.Checked)
                                {
                                    lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Mao", "M/L", "Premium"), cant));
                                }
                                else
                                {
                                    lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Mao", "M/L", "Standar"), cant));
                                }
                                
                            }
                            else
                            {
                                if (radioPremium.Checked)
                                {
                                    lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Común", "M/L", "Premium"), cant));
                                }
                                else
                                {
                                    lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerCamisa("Común", "M/L", "Standar"), cant));
                                }
                                
                            }
                        }
                    }
                    else
                    {

                            if (checkChupin.Checked)
                            {
                                if (radioPremium.Checked)
                                {
                                lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerPantalon("Chupín", "Premium"), cant));
                                }
                                else
                                {
                                lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerPantalon("Chupín", "Standar"), cant));
                                }
                                
                            }
                            else
                            {
                                if (radioPremium.Checked)
                                {
                                lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerPantalon("Común", "Premium"), cant));
                            }
                            else
                            {
                                lblResultado.Text = "$ " + Convert.ToString(control1.VerVendedor().cotizar(control1.VerPantalon("Común", "Standar"), cant));
                            }
                                
                            }
                        

                    }
                }
            }
            
        }

        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCamisa.Checked)
            {
                grupoTipoPantalon.Enabled = false;
                grupoTipoCamisa.Enabled = true;
                if (checkMangaCorta.Checked)
                {
                    if (checkCuelloMao.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao","M/C","Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Standar").Stock);
                        }
                        
                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Standar").Stock);
                        }
                        
                    }
                }
                else
                {
                    if (checkCuelloMao.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Standar").Stock);
                        }
                        
                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Standar").Stock);
                        }
                        
                    }
                }
            }
        }

        private void radioPantalon_CheckedChanged(object sender, EventArgs e)
        {
           if (radioPantalon.Checked)
            {
                grupoTipoPantalon.Enabled = true;
                grupoTipoCamisa.Enabled = false;
                lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Standar").Stock);
                if (checkChupin.Checked)
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Standar").Stock);
                    }
                    
                }
                else
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Premium").Stock);
                    }
                }
            }
        }

        private void checkMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMangaCorta.Checked)
            {
                if (checkCuelloMao.Checked)
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Standar").Stock);
                    }
                    
                }
                else
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Standar").Stock);
                    }
                    
                }
            }
            else
            {
                if (checkCuelloMao.Checked)
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Standar").Stock);
                    }
                    
                }
                else
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Standar").Stock);
                    }
                    
                }
            }

        }

        private void checkCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMangaCorta.Checked)
            {
                if (checkCuelloMao.Checked)
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Standar").Stock);
                    }

                }
                else
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Standar").Stock);
                    }

                }
            }
            else
            {
                if (checkCuelloMao.Checked)
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Standar").Stock);
                    }

                }
                else
                {
                    if (radioPremium.Checked)
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Premium").Stock);
                    }
                    else
                    {
                        lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Standar").Stock);
                    }

                }
            }
        }

        private void checkChupin_CheckedChanged(object sender, EventArgs e)
        {
            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Standar").Stock);
            if (checkChupin.Checked)
            {
                if (radioPremium.Checked)
                {
                    lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Premium").Stock);
                }
                else
                {
                    lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Standar").Stock);
                }
                
            }
            else
            {
                if (radioPremium.Checked)
                {
                    lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Premium").Stock);
                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            string listaHistorial = "";
            List<Cotizaciones> historial = control1.VerVendedor().ListaCotizaciones;
            int cont = 1;
            foreach(Cotizaciones c in historial)
            {
                listaHistorial +=Convert.ToString(cont)  + "   " + c.Fecha + " : " + c.Hora + "\n Prenda cotizada: " + c.Prenda.Tipo + "\n Cantidad Solicitada: " + c.Cantidad + "\n Resultado Cotizacion: " + c.Resultado+"\n\n\n";
                cont++;
            }
            if (listaHistorial == "")
            {
                listaHistorial = "La lista esta vacía";
            }
            MessageBox.Show(listaHistorial);
        }

        private void radioPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCamisa.Checked)
            {

                if (checkMangaCorta.Checked)
                {
                    if (checkCuelloMao.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Standar").Stock);
                        }
                        
                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Premium").Stock);
                        }
                        
                    }
                }
                else
                {
                    if (checkCuelloMao.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Standar").Stock);
                        }
                        
                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Standar").Stock);
                        }
                        
                    }
                }
            }
            else
            {
                if (radioPantalon.Checked)
                {

                    if (checkChupin.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Standar").Stock);
                        }
                        
                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Standar").Stock);
                        }
                       
                    }
                }

            }
        }

        private void radioStandar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCamisa.Checked)
            {

                if (checkMangaCorta.Checked)
                {
                    if (checkCuelloMao.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/C", "Standar").Stock);
                        }

                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/C", "Premium").Stock);
                        }

                    }
                }
                else
                {
                    if (checkCuelloMao.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Mao", "M/L", "Standar").Stock);
                        }

                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerCamisa("Común", "M/L", "Standar").Stock);
                        }

                    }
                }
            }
            else
            {
                if (radioPantalon.Checked)
                {

                    if (checkChupin.Checked)
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Chupín", "Standar").Stock);
                        }

                    }
                    else
                    {
                        if (radioPremium.Checked)
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Premium").Stock);
                        }
                        else
                        {
                            lblUnidadesDispo.Text = Convert.ToString(control1.VerPantalon("Común", "Standar").Stock);
                        }

                    }
                }

            }
        }

        private void txtCantidadSolicitada_KeyPress(object sender, KeyPressEventArgs e)
        {
            control1.soloNumeros(e);
        }
    }
}
