namespace Hamburgueson
{
    internal class HamburguesaBacon : Hamburguesa
    {

        bool bacon;

        public HamburguesaBacon()
        {
        }

        public void setBacon(bool bacon)
        {
            this.bacon = bacon;
        }

        public bool getBacon()
        {
            return this.bacon;
        }
    }
}