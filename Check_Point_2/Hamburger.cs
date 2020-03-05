namespace Check_Point_2
{
    class Hamburger
    {
        private string name;
        private string breadtype;
        private string meat;
        private int basePrice;
        private string top1;
        private double top1price;
        private string top2;
        private double top2price;
        private string top3;
        private double top3price;
        private string top4;
        private double top4price;

        public Hamburger()
        {

        }
        public Hamburger(string name, string breadtype, string meat, int basePrice)
        {
            this.name = name;
            this.breadtype = breadtype;
            this.meat = meat;
            this.basePrice = basePrice;
        }

        public double Baseprice()
        {
            return basePrice;
        }

        public virtual string Print()
        {


            return $"Name: \"{this.name}\", \nType: {this.breadtype}, \nMeat: {this.meat}, \nPrice: {this.basePrice}";

        }
        public void Addtop1(string toping, int price)
        {
            this.top1 = toping;
            this.top1price = price;
        }

        public void Addtop2(string toping, double price)
        {
            this.top2 = toping;
            this.top2price = price;
        }

        public void Addtop3(string toping, double price)
        {
            this.top3 = toping;
            this.top3price = price;
        }

        public void Addtop4(string toping, double price)
        {
            this.top4 = toping;
            this.top4price = price;
        }



        public virtual string PrintTopping()
        {

            return $"{this.top1} - {this.top1price} \n{this.top2} - {this.top2price}\n{this.top3}  - {this.top3price}\n{this.top4} - {this.top4price}";

        }

        public virtual double TotalPrice()
        {
            double price = basePrice;
            if (top1 != null)
            {
                price += top1price;

            }
            if (top2 != null)
            {
                price += top2price;

            }
            if (top3 != null)
            {
                price += top3price;

            }
            if (top4 != null)
            {
                price += top4price;

            }
            return price;
        }

    }
}
