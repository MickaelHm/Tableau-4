using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string> { "Carottes", "Oignons", "Pommes de terre", "Salade", "Tomate" };
            foreach (string product in shopping)
            {
                Console.WriteLine(product);
            }


        }
    }
}
