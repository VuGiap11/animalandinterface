using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalandinterfaceEdible
{

    abstract class animal
    {
        public abstract string Makesound();

    }
    class tiger : animal
    {
        public override string Makesound()
        {
            return "Tiger: roarrrrr!";
        }
    }
    class Chicken : animal, Edible
    {
        public string howtoEat()
        {
            return "could be fried";
        }

        public override string Makesound()
        {
            return "Chicken: cluck-cluck!";
        }
    }
    abstract class Fruit : Edible
    {
        public abstract string howtoEat();
    }
    class Orange : Fruit
    {
        public override string howtoEat()
        {
            return "Orange could be juiced";
        }
    }
    class Apple : Fruit
    {
        public override string howtoEat()
        {
            return "Apple could be slided";
        }
    }
}
