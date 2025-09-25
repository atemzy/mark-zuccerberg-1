namespace ConsoleApp1
{

    internal class Program
    {
        public static int maxDistance = 300;
        public static int distance(City a, City b)
        {
            return (int)Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
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
                if(currentDistance - distance(places[places.IndexOf(place) - 1], place) < 0)
                {
                    Console.WriteLine("Nem lehet megtenni");
                    return;
                }
                currentDistance -= distance(places[places.IndexOf(place) - 1], place);
                if (place.HasCharger)
                {
                    currentDistance = maxDistance;
                }

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
