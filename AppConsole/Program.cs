using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hola, Estos son mis clases");
            Contabilidad a = new Contabilidad();
            Console.WriteLine(a.getSaldos(10));
            Console.WriteLine(a.Saludos("Roberto"));
            Console.WriteLine(a.Mes(5));
            Console.WriteLine(a.GetFecha(15, 5, 2020));
            Console.ReadLine();
        }
    }
}
