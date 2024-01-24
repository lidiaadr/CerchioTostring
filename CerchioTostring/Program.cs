using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerchioTostring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r = float.Parse(Console.ReadLine());
            Cerchio c = new Cerchio(r);
            Console.WriteLine(c.Area());
            Console.WriteLine(c.Perimetro());
            Console.WriteLine(c.ToString());

            Console.ReadLine();
        }
    }
}
