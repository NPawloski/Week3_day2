using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day2
{
    class Boat
    {
        public int numberOfPassengers;

        private string name;
        private double engineSize;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }


        public Boat()
        {

        }

        public Boat(int numberOfPassengers, String name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }

        public void Move()
        {
            //code to make the boat move
            Console.WriteLine("Sails foreward;");
        }

        private double CalculateMPG()
        {
            //code to calculate the MPG
            double MPG = engineSize * .7d;
            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine size: "+engineSize);
            Console.WriteLine("MPG: " + CalculateMPG());
            Console.WriteLine();
        }
    }
}
