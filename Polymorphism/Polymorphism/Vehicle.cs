using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Vehicle
    {
        // private backing field
        protected string id;
        // public property
        public string ID
        {
            get 
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public virtual void Drive() 
        {
            Console.WriteLine("Who am i? And What do I do?");
        }
    }
}
