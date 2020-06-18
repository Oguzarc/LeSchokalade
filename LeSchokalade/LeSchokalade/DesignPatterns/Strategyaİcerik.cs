using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    public class DarkChocolate : ISpreading
    {
        public string Spread()
        {
            string x = "Dark Chocalate spreads on Waffle Dough.";
            return x;
        }
    }
    public class Strawberry : IFruit
    {
        public string Fruit()
        {
            string x = "Freshly cut strawberries are put on top.";
            return x;
        }
    }
    public class PebbleChocolate : IOrnaments
    {
        public string Ornament()
        {
            string x = "Pebble Chocolates are put on top.";
            return x;          
        }
    }
}
