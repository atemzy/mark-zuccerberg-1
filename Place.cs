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

            this.Nepesseg = Int32.Parse(line.Split(";")[1]);
            this.HasCharger = Boolean.Parse(line.Split(";")[2]);
            this.Name = line.Split(";")[0];
            this.X = Int32.Parse(line.Split(";")[3]);
            this.Y = Int32.Parse(line.Split(";")[4]);
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public int Nepesseg { get => nepesseg; set => nepesseg = value; }
        public bool HasCharger { get => hasCharger; set => hasCharger = value; }
        public string Name { get => name; set => name = value; }
    }
}
