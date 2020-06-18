using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    public abstract class Baverages
    {
        public string desc = "unnamed beverages";

        public virtual string GetDescription()
        {
            return this.desc;
        }

        public abstract double GetPrice();
    }
    public class TurkishCoffee : Baverages
    {
        public TurkishCoffee()
        {
            this.desc = "TurkishCoffee";
        }
        public override double GetPrice()
        {
            return 5.50;
        }
    }
    public class Americano : Baverages
    {
        public Americano()
        {
            this.desc = "Americano";
        }
        public override double GetPrice()
        {
            return 8.50;
        }
    }
    public class Lemonade : Baverages
    {
        public Lemonade()
        {
            this.desc = "Lemonade";
        }
        public override double GetPrice()
        {
            return 7.50;
        }
    }
    public abstract class CondimentDecorator : Baverages
    {
    }

    public class Milk : CondimentDecorator
    {
        Baverages beverages;

        public Milk(Baverages newBeverages)
        {
            this.beverages = newBeverages;
        }
        public override string GetDescription()
        {
            return this.beverages.GetDescription() + ", ExtraMilk ";

        }
        public override double GetPrice()
        {
            return 0.20 + this.beverages.GetPrice();
        }
    }
    public class SugarFree : CondimentDecorator
    {
        Baverages beverages;

        public SugarFree(Baverages newBeverages)
        {
            this.beverages = newBeverages;
        }
        public override string GetDescription()
        {
            return this.beverages.GetDescription() + ", SugarFree ";

        }
        public override double GetPrice()
        {
            return -0.50 + this.beverages.GetPrice();
        }
    }
    public class MidSugar : CondimentDecorator
    {
        Baverages beverages;

        public MidSugar(Baverages newBeverages)
        {
            this.beverages = newBeverages;
        }
        public override string GetDescription()
        {
            return this.beverages.GetDescription() + ", MidSugar ";       
        }
        public override double GetPrice()
        {
            return this.beverages.GetPrice();
        }
    }
    public class Sugary : CondimentDecorator
    {
        Baverages beverages;

        public Sugary(Baverages newBeverages)
        {
            this.beverages = newBeverages;
        }
        public override string GetDescription()
        {
            return this.beverages.GetDescription() + ", Sugary ";

        }
        public override double GetPrice()
        {
            return 0.50 + this.beverages.GetPrice();
        }

    }
    public class Tasting : CondimentDecorator
    {
        Baverages beverages;

        public Tasting(Baverages newBeverages)
        {
            this.beverages = newBeverages;
        }
        
        public override double GetPrice()
        {
            return 12.0 + this.beverages.GetPrice();
        }

    }
    public class Filling : CondimentDecorator
    {
        Baverages beverages;

        public Filling(Baverages newBeverages)
        {
            this.beverages = newBeverages;
        }

        public override double GetPrice()
        {
            return 15.0 + this.beverages.GetPrice();
        }

    }

}
