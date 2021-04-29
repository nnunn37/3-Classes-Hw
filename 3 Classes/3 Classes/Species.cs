using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    enum EyeColor
    {
        yellow,redBrown, blue
    }
    class Species : Genus
    {
        public string binomialName;
        public int numberofLegs;
        public Species()
        {
            Name = "No name";
        }
        public Species(string _name)
        {
            if (_name is null || _name.Length < 1)
            {
                Name = "No name";
            }
            else
            {
                Name = _name.Replace(";", "");
            }
            Console.WriteLine("Creating: " + _name + " at " + DateTime.Now.ToString("yyyy-MM-DD"));
        } 
        public Species(String _name, string _binomialName)
        {
            if (_binomialName is null || _binomialName.Length < 1)
            {
                binomialName = "No name";
            }
            else
            {
                binomialName = _binomialName.Replace(";", "");
            }

        }
        public Species(string _name, int _numberofLegs) : this(_name)
        {
            numberofLegs = _numberofLegs;
        }
        


    }
}
