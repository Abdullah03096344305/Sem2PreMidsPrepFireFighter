using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreMidsPrepFireFighter.BL
{
    class Ladder
    {
        private int length;
        private string color;
        public Ladder(int length, string color)
        {
            this.length = length;
            this.color = color;
        }

    }
    class HosePipe
    {
        private string material;
        private string shape;
        private float diameter;
        private float flowrate;

        public HosePipe(string material, string shape, float diameter, float flowrate)
        {
            this.material = material;
            this.shape = shape;
            this.diameter = diameter;
            this.flowrate = flowrate;
        }
    }

    class FireFighter
    {
        private string name;
        public FireFighter(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void Drive()
        {
            Console.WriteLine(name + "  is Driving the Truck");
        }
        public void ExtinguishFire()
        {
            Console.WriteLine(name + "  is Extinguishing the Fire");
        }
        
    }
    class FireChief : FireFighter
    {
        public FireChief(string name) : base(name)
        {           
        }
        public void DelegateResponsibility(string FireFighterName)
        {
            Console.WriteLine("Tell " + FireFighterName + " to Extinguish Fire");
        }
    }
    class FireTruck
    {
        private Ladder li;
        private HosePipe h1;
        private FireFighter driver;
        public FireTruck(HosePipe h1,FireFighter driver)
        {
            li = new Ladder(34, "Black");
            this.h1 = h1;
            this.driver = driver;
        }
    }
}
