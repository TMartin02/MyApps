using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class City
    {
        public string County;
        public string Town;
        public int Population;

        public City(string sTown, string sCounty, int sPopulation)
        {
            County = sCounty;
            Town = sTown;
            Population = sPopulation;

        }
        public City() { }


    }
}
