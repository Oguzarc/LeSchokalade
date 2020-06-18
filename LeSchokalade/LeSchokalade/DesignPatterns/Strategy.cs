using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeSchokalade.DesignPatterns
{
    public abstract class WaffleMain
    {
        ISpreading spreading;
        IOrnaments ornaments;
        IFruit fruit;
        
        public virtual string DoSpreading()
        {
           return this.spreading.Spread();
        }

        public virtual string SetSpreading(ISpreading newSpreading)
        {
            this.spreading = newSpreading;
            return Convert.ToString(newSpreading);
        }
        public virtual string DoOrnaments()
        {
            return this.ornaments.Ornament();
        }

        public virtual string SetOrnaments(IOrnaments newOrnaments)
        {
            this.ornaments = newOrnaments;
            return Convert.ToString(newOrnaments);
        }

        public virtual string DoFruit()
        {
            return this.fruit.Fruit();
        }

        public virtual string SetMeyve(IFruit newFruit)
        {
            this.fruit = newFruit;
            return Convert.ToString(newFruit);
        }
    }

    public class KlasikWaffle : WaffleMain
    {
        public KlasikWaffle()
        {
            SetSpreading(new DarkChocolate());
            SetMeyve(new Strawberry());
            SetOrnaments(new PebbleChocolate());
        }
    }
}
