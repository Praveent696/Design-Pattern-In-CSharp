using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract factory
            /*
            //fact1
            Creational.Abtract.FoodFactory fac1 = new Creational.Abtract.Factory1();
            Creational.Abtract.Client c = new Creational.Abtract.Client(fac1);
            c.comparefood();

            //fact2
            Creational.Abtract.FoodFactory fac2 = new Creational.Abtract.Factory2();
            c = new Creational.Abtract.Client(fac2);
            c.comparefood();
            */ 

            #endregion

            #region Builder Pattern
            /*
            Creational.Builder.Shop sh = new Creational.Builder.Shop();
            Creational.Builder.SmartPhones sp;

            //Google
            sp = new Creational.Builder.Google();
            sh.Construct(sp);
            sp.Phone.Show();

            //Apple

            sp = new Creational.Builder.Apple();
            sh.Construct(sp);
            sp.Phone.Show();
            */
            #endregion

            Console.ReadKey();
        }
    }
}
