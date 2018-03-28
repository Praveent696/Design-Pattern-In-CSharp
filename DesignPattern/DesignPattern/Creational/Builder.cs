using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Builder
{
    class Shop
    {
       public void Construct(SmartPhones phones)
        {
            phones.makeModel();
            phones.makeOs();
            phones.makeProcessor();
            phones.makeRam();
        }
    }
    abstract class SmartPhones
    {

        protected Phone phone;
        public Phone Phone
        {
            get { return phone; }
        }

        public abstract void makeModel();
        public abstract void makeOs();
        public abstract void makeProcessor();
        public abstract void makeRam();
    }
    class Google:SmartPhones
    {
        
        public Google()
        {
            phone = new Phone("Google");
        }

        public override void makeModel()
        {
            phone["Model"] = "Pixel";
        }

        public override void makeOs()
        {
            phone["OS"] = "Android";
        }

        public override void makeProcessor()
        {
            phone["Processor"] = "Snapdragon 845";
        }

        public override void makeRam()
        {
            phone["RAM"] = "6 GB";
        }
    }
    class Apple : SmartPhones
    {

        public Apple()
        {
            phone = new Phone("Apple");
        }

        public override void makeModel()
        {
            phone["Model"] = "IPhone";
        }

        public override void makeOs()
        {
            phone["OS"] = "iOS";
        }

        public override void makeProcessor()
        {
            phone["Processor"] = "Cortex A10";
        }

        public override void makeRam()
        {
            phone["RAM"] = "4 GB";
        }
    }
    class Phone
    {
        private string phonetype;
        public Dictionary<string, string> _phonepart = new Dictionary<string, string>();
        
        public Phone(string type) {
            this.phonetype = type;
        }

        //indexer
        public string this[string key]
        {
            get { return _phonepart[key]; }
            set
            {
                _phonepart[key] = value;
            }
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("========================== Start ===========================");
            Console.WriteLine("Phone Type : "+this.phonetype);
            Console.WriteLine("Phone Model : "+_phonepart["Model"]);
            Console.WriteLine("Phone OS : " + _phonepart["OS"]);
            Console.WriteLine("Phone RAM : " + _phonepart["RAM"]);
            Console.WriteLine("Phone Processor : " + _phonepart["Processor"]);
            Console.WriteLine("========================== End ===========================");
            Console.WriteLine();
        }
    }
}
