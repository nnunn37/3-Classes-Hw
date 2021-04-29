using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Species tiger = new Species("Tiger","Panthera tigris");
            Species robin = new Species("Robin","Turdus Migratorius");
            Family Panthera = new Family("Panthera");
            Family Turdus = new Family("Turdus");

            Panthera.numberofTeeth = 30;
            Panthera.numberofToes = 16;
            Turdus.numberofTeeth = 0;
            Turdus.numberofToes = 6;
            tiger.SetAttributes(Panthera);
            robin.SetAttributes(Turdus);
            Console.WriteLine("Would you like Tiger, or a Robin?:");
            string newSpeciesName = Console.ReadLine();
            Console.WriteLine("How many legs does it have?:");
            int numLegs = 0;

            try
            {
                numLegs = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't make a number out of that, please try again, error was" + ex.ToString());
            }

            Species newObj = new Species(newSpeciesName,numLegs);
            Console.ReadLine();
            while (numLegs < 0)
            {
                Console.WriteLine("How many legs does it have?:");
                try
                {
                    numLegs = int.Parse(Console.ReadLine());
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Couldn't make a number out of that, please try again, error was" + ex2.ToString());
                }
                Console.ReadLine();

            }
        }
    }
}
