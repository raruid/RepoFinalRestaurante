namespace Hamburgueson
{
    internal class Hamburguesa : Elemento
    {
        bool tomate;
        bool queso;
        bool lechuga;

        public Hamburguesa()
        {
            
        }

        public Hamburguesa(bool tomate, bool queso, bool lechuga, int precio)
        {
            this.tomate = tomate;
        }

        public void setTomate(bool tomate)
        {
            this.tomate = tomate;
        }

        public void setLechuga(bool lechuga)
        {
            this.lechuga = lechuga;
        }

        public void setQueso(bool queso)
        {
            this.queso = queso;
        }

        public bool getTomate()
        {
            return this.tomate;
        }

        public bool getLechuga()
        {
            return this.lechuga;
        }

        public bool getQueso()
        {
            return this.queso;
        }
    }
}