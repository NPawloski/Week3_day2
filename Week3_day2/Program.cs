using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat BoatyMcBoatface = new Boat(3, "BoatyMcBoatface", 8.5);
            BoatyMcBoatface.Move();

            BoatyMcBoatface.BoatInfo();

            Boat Boat2 = new Boat(14, "Boat 2", 36.7);
            Boat2.BoatInfo();



        }
    }
}
