using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearcherDAOImp test = new ResearcherDAOImp();
            string k = Console.ReadLine();
            if (k == "k")
            {
                test.AddResearcher();
            }
        }
    }
}
