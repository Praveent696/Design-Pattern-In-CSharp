using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational
{
    abstract class FoodFactory
    {
        public abstract Veg createveg();
        public abstract NonVeg createnonveg();
    }

    class Factory1 : FoodFactory
    {
        public override Veg createveg()
        {
            return new Sabzi();
        }
        public override NonVeg createnonveg()
        {
            return new Chicken();
        }
    }

    class Factory2 : FoodFactory
    {
        public override Veg createveg()
        {
            return new Roti();
        }
        public override NonVeg createnonveg()
        {
            return new Briyani();
        }
    }

    abstract class Veg
    {

    }
    abstract class NonVeg
    {
        public abstract void comparision(Veg v);
    }
    class Roti : Veg
    {

    }
    class Sabzi : Veg
    {

    }
    class Briyani : NonVeg
    {
        public override void comparision(Veg v)
        {
            Console.WriteLine(v.GetType().Name + " is better than " + this.GetType().Name + " so veg is recommended");
        }
    }
    class Chicken : NonVeg
    {
        public override void comparision(Veg v)
        {
            Console.WriteLine(v.GetType().Name + " is better than " + this.GetType().Name + " so veg is recommended");
        }
    }
    class Client
    {
        private Veg _veg;
        private NonVeg _nonveg;


        public Client(FoodFactory Ff)
        {

            _veg = Ff.createveg();
            _nonveg = Ff.createnonveg();

        }

        public void comparefood()
        {
            _nonveg.comparision(_veg);
        }
    }
}
