using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {

            var Lista = new List<City>();

            Lista.Add(new City() { Town = "Balassagyarmat", County = "Nógrád", Population = 10000 });
            Lista.Add(new City() { Town = "Budapest", County = "Pest", Population = 2000000 });
            Lista.Add(new City() { Town = "Salgótarján", County = "Nógrád", Population = 25000 });

            foreach (City city in Lista)
            {
                Console.WriteLine(city.Town + " " + city.County + " " + city.Population);
            }
            Lista.Remove(Lista.Find(x => x.Town.Contains("Budapest")));
            Console.WriteLine("***********************************************************************");

            foreach (City city in Lista)
            {
                Console.WriteLine(city.Town + " " + city.County + " " + city.Population);
            }


            Console.ReadKey();
                        
        }
    }
}
