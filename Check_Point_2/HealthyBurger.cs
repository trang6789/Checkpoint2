namespace Check_Point_2
{
    class HealthyBurger : Hamburger
    {
        private string name;
        private string breadtype;
        private int baseprice;
        public string top5;
        public double top5price;
        public string top6;
        public double top6price;



        public HealthyBurger(string name, string breadtype, int baseprice) : base()
        {
            this.name = name;
            this.breadtype = breadtype;
            this.baseprice = baseprice;
        }
        public override string Print()
        {


            return $"Name: \"{this.name}\", \nType: {this.breadtype}, \nPrice: {this.baseprice}";

        }

        public void Addtop5(string toping, double price)
        {
            this.top5 = toping;
            this.top5price = price;
        }
        public void Addtop6(string toping, double price)
        {
            this.top6 = toping;
            this.top6price = price;
        }


        public override string PrintTopping()
        {

            return $"{this.top5}  - {this.top5price}\n{this.top6} - {this.top6price}";


        }
        public override double TotalPrice()
        {
            double price = baseprice;

            if (top5 != null)
            {
                price += top5price;

            }
            if (top6 != null)
            {
                price += top6price;

            }
            return price;
        }


    }
}
