namespace ExamenIntento.Modelo
{
    internal abstract class Prenda
    { 
        private string tipo;
        private double precioBase;

        protected Prenda(string tipo, double precio)
        {         
            this.tipo = tipo;
            this.precioBase = precio;
        }
       
        
        public string Tipo { get => tipo; set => tipo = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }

        public virtual double obtenerPrecio()
        {
            return this.precioBase;
        }
        

    }
}
