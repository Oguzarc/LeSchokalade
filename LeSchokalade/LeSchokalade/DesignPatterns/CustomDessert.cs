using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    class LeShokaladeSude : Dessert
    {
        public override string Prepare()
        {
            string x = "Dessert Sude will be prepared as soon as possible.";
            return x;
        }
        public override string Ingredients()
        {
            string x = "Crispy Wafers, Milk Chocolate\n and Delicious Strawberry.";
            return x;
        }
        public override double GetPrice()
        {
            return 0.0;
        }
    }
    class LeShokaladeNeriman : Dessert
    {
        public override string Prepare()
        {
            string x = "Dessert Neriman will be prepared as soon as possible.";
            return x;
        }
        public override string Ingredients()
        {
            string x = "meringue, marsmelov cream\nhandmade caramel\ngroundnut and belgian chocolate";
            return x;
        }
        public override double GetPrice()
        {
            return 0.0;
        }
    }
}
