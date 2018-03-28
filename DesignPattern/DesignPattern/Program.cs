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

            #region Factory
            /*
            Creational.Factory.Phone[] ph = new Creational.Factory.Phone[2];
            ph[0] = new Creational.Factory.Basicphone();
            ph[1] = new Creational.Factory.Smartphone();

            foreach(Creational.Factory.Phone phone in ph)
            {
                Console.WriteLine();
                Console.WriteLine("Phone type => " + phone.GetType().Name);
                Console.WriteLine("Features:\n");
                foreach (Creational.Factory.Feature f in phone.Features) {
                    Console.WriteLine(f.GetType().Name);

                }
            }
            */

            #endregion

            #region Factory

            /*
            Creational.Singleton.Calci obj1 = Creational.Singleton.Calci.getInstance();
            Creational.Singleton.Calci obj2 = Creational.Singleton.Calci.getInstance();

            obj1.sayHello();
            obj2.sayBye();

            if (obj1 == obj2)
            {
                Console.WriteLine("Both obj are same");
                
            }
             */
            #endregion

            Console.ReadKey();
        }
    }
}
