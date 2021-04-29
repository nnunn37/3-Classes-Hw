using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    class Family
    {
        public string Name;
        public int numberofToes;
        public int numberofTeeth;

        public Family(string _name = null)
        {
            Name = _name;
            Console.WriteLine("Creating: " + _name + " at " + DateTime.Now.ToString("yyyy-MM-DD"));
        }
        public void SetAttributes(Family sentFamily)
        {
            numberofToes = sentFamily.numberofToes;
            numberofTeeth = sentFamily.numberofTeeth;
        }

    }
}
