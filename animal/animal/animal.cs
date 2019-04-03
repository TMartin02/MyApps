using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
   abstract class animal
    {
        protected string Name;
        protected bool isFemale;//true : nőstény, false : hím

        abstract public void Sleep();
        abstract public void Hunt();
        abstract public void Sound();
        abstract public void Born(int i);
    }
    //Feladat: adjunk a macskához lehetőséget hogy kölyke legyen
    class Cat : animal
    {
        private List<Cat> Kids;

        public Cat(string aName,bool aGender)
        {
            Name = aName;
            isFemale = aGender;

        }
        internal override void Born(int v)
        {
            Kids = new List<Cat>();
            for (int i = 0; i < v; i++)
            {
                Kids.Add(new Cat("cica" + i.ToString(),true));
            }
        }
        internal void Child()
        {
            if (Kids != null)
            {
                
                foreach (var item in Kids)
                {
                    Console.WriteLine(Name + " s child name:" + item.Name);
                }
            }
        }
       
        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping......");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunting");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " is nyávog");
        }
              
    }
    class Dog : animal
    {
        public Dog(string aName)
        {
            Name = aName;
        }
        private List<Dog> Kids;

        
        internal void Born(int v)
        {
            Kids = new List<Dog>();
            for (int i = 0; i < v; i++)
            {
                Kids.Add(new Dog("kutyi" + i.ToString()));
            }
        }
        internal void Child()
        {
            foreach (var item in Kids)
            {
                Console.WriteLine(Name + " s child name:" + item.Name);
            }
        }
       
        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping......");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunting");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " is Sound");
        }
    }
}
