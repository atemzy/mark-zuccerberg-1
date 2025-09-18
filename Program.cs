namespace ConsoleApp1
{

    internal class Program
    {
        public static int maxDistance = 300;
        public static int distance(City a, City b)
        {
            return (int)Math.Sqrt(Math.Pow((a.getX() - b.getX()), 2) + Math.Pow((a.getY() - b.getY()), 2));
        }

        public bool canReach(City a, City b)
        {
            return distance(a,b) < 0 ? true : false;
        }
        public int calculateFuelUsage(City a, City b, )
        {
            distance(a,b);
            return 0;
        }
        static void Main(string[] args)
        {

            float currentDistance = maxDistance;
            bool isFirst = true;
            List<City> places = GetData();
            foreach (City place in places)
            {
                if (isFirst)
                {
                    isFirst = false;
                    continue;
                }
                currentDistance -= distance(places[places.IndexOf(place) - 1], place);
                

            }



        }
        static public List<City> GetData()
        {
            StreamReader sr = new StreamReader("places.txt");
            string line = sr.ReadLine();
            List<City> places = new List<City>();
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                City place = new City(line);
                places.Add(place);
            }
            sr.Close();
            return places;

        }
    }
}
