namespace Hamburgueson
{
    internal class PizzaVegana : Elemento
    {
        bool champinones;
        bool tomate;
        bool brocoli;

        public PizzaVegana()
        {
        }

        public void setChampinones(bool rucula)
        {
            this.champinones = rucula;
        }

        public void setTomate(bool bacon)
        {
            this.tomate = bacon;
        }

        public void setBrocoli(bool bacon)
        {
            this.brocoli = bacon;
        }

        public bool getChampinones()
        {
            return this.champinones;
        }

        public bool getTomate()
        {
            return this.tomate;
        }

        public bool getBrocoli()
        {
            return this.brocoli;
        }

    }




}