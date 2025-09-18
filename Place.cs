using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class City
    {
        private float x;
        private float y;
        private int nepesseg;
        private bool hasCharger;
        private string name;

        public City(string line)
        {

            this.nepesseg = Int32.Parse(line.Split(";")[1]);
            this.hasCharger = Boolean.Parse(line.Split(";")[2]);
            this.name = line.Split(";")[0];
            this.x = Int32.Parse(line.Split(";")[3]);
            this.y = Int32.Parse(line.Split(";")[4]);
        }
        public float getX() { return x; }
        public float getY() { return y; }
        public bool getHasCharger() { return hasCharger; }
        public int getNepesseg() { return nepesseg; }
        public string getName() { return name; }

    }
}
