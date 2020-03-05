namespace Check_Point_2
{
    class DeluxeBurger : Hamburger
    {
        private string name;
        private int baseprice;
        public string extra1;
        public double extra1price;
        public string extra2;
        public double extra2price;

        public DeluxeBurger(string name, int baseprice) : base()
        {
            this.name = name;
            this.baseprice = baseprice;

        }
        public override string Print()
        {


            return $"Name: \"{this.name}\", \nPrice: {this.baseprice}";

        }

        public void Extra1(string extra, double price)
        {
            this.extra1 = extra;
            this.extra1price = price;
        }
        public void Extra2(string extra, double price)
        {
            this.extra2 = extra;
            this.extra2price = price;
        }

        public override string PrintTopping()
        {
            return $"{this.extra1} - {this.extra1price} \n{this.extra2} - {this.extra2price} ";

        }

        public override double TotalPrice()
        {
            double price = baseprice;

            if (extra1 != null)
            {
                price += extra1price;

            }
            if (extra2 != null)
            {
                price += extra2price;

            }
            return price;
        }
    }
}
