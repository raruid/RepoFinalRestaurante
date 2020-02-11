namespace Hamburgueson
{
    public class Elemento
    {
        string nombre;
        double precio;

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getPrecio()
        {
            return this.precio;
        }

    }
}