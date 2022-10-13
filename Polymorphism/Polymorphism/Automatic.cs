using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Automatic : Car
    {
        public string GearBox { get; set; }

        public Automatic(string id, string color, string model, string make, DateTime year, string gearbox) : base(id, color, model, make, year)
        {
            GearBox = gearbox;
        }

        public override void Drive()
        {
            Console.WriteLine($"{id} I can drive with one foot. and eat my breakfast too.");
        }
    }
}
