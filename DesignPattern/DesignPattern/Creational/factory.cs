using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Factory
{
    abstract class Feature
    {
        //public abstract string featureName();
    }

    class Call : Feature
    {

    }

    class SMS : Feature
    {

    }
    class Music : Feature
    {

    }
    class Email : Feature
    {

    }
    class Browsing : Feature
    {

    }

    abstract class Phone
    {
        private List<Feature> _feature = new List<Feature>();
        public Phone()
        {
            this.addPhoneFeatures();
        }
        public List<Feature> Features
        {
            get { return this._feature; }
        }
        public abstract void addPhoneFeatures();
    }

    class Basicphone : Phone
    {

        public override void addPhoneFeatures()
        {
            Features.Add(new Call());
            Features.Add(new SMS());
            Features.Add(new Music());
        }
    }

    class Smartphone : Phone
    {

        public override void addPhoneFeatures()
        {
            Features.Add(new Call());
            Features.Add(new SMS());
            Features.Add(new Music());
            Features.Add(new Email());
            Features.Add(new Browsing());
        }
    }
  }
