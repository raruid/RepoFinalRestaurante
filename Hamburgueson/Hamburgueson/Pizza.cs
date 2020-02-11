namespace Hamburgueson
{
    internal class Pizza : Elemento
    {
        
        bool rucula;
        bool bacon;

        public Pizza()
        {
        }

        public void setRucula(bool rucula)
        {
            this.rucula = rucula;
        }

        public void setBacon(bool bacon)
        {
            this.bacon = bacon;
        }
        
        public bool getRucula()
        {
            return this.rucula;
        }

        public bool getBacon()
        {
            return this.bacon;
        }
    }
}