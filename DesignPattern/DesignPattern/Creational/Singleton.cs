using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Singleton
{
    class Calci
    {
        private static Calci _calci;
        protected Calci()
        {

        }

        private static object synclock = new object(); //to ensure thread safe
        public static Calci getInstance()
        {
            if (_calci == null)
            {
                lock(synclock){
                    if (_calci == null) //for double check on lock
                    {
                        _calci = new Calci();
                    }
                }
            }
            return _calci;
            
        }

        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
        public void sayBye()
        {
            Console.WriteLine("Bye");
        }
    }

}
