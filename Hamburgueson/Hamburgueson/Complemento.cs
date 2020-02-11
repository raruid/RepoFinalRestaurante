namespace Hamburgueson
{
    internal class Complemento : Elemento
    {
        bool ketchup;
        bool mayonesa;
        bool mustaza;

        public void setKetchup(bool ketchup)
        {
            this.ketchup = ketchup;
        }

        public void setMayo(bool mayonesa)
        {
            this.mayonesa = mayonesa;
        }

        public void setMustaza(bool mustaza)
        {
            this.mustaza = mustaza;
        }

        public bool getKetchup()
        {
            return this.ketchup;
        }

        public bool getMayo()
        {
            return this.mayonesa;
        }

        public bool getMustaza()
        {
            return this.mustaza;
        }

    }
}