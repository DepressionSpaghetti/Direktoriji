using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Klasa_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija");
            string putanja = Console.ReadLine();

            if(Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke:\n");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }

            string putanjaPD = "\\test";
            string novaPutanja = putanja + putanjaPD;

            if (!Directory.Exists(novaPutanja)) Directory.CreateDirectory(novaPutanja);
            else Console.WriteLine("Direktorij vec postoji");

            Console.WriteLine("Poddirektorij:\n");
            foreach(string podDirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(podDirektorij);
            }

            Directory.Delete(novaPutanja);

            Console.WriteLine("Nakon brisanja: ");
            foreach (string podDirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(podDirektorij);
            }

            Console.ReadKey();
        }
    }
}
