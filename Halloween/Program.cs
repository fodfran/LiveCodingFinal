using System;

namespace Halloween
{
    class Program
    {
        static double HowMuchCandy(double trickOrTreaters, double candyPerKid, string weather, string temperature)
        {
            double TOTByWeather = 0;
            double TOTByTemperature = 0;
            if (weather == "Clear")
                TOTByWeather = trickOrTreaters * .1;
            else if (weather == "Cloudy")
                TOTByWeather = trickOrTreaters * 0;
            else if (weather == "Raining")
                TOTByWeather = trickOrTreaters * -.25;
            else if (weather == "Full Moon")
                TOTByWeather = trickOrTreaters * .25;

            if (temperature == "40s")
                TOTByTemperature = trickOrTreaters * -.05;
            else if (temperature == "50s")
                TOTByTemperature = trickOrTreaters * 0;
            else if (temperature == "60s")
                TOTByTemperature = trickOrTreaters * .05;
            else if (temperature == "70s")
                TOTByTemperature = trickOrTreaters * .20;

            return (trickOrTreaters + TOTByWeather + TOTByTemperature) * candyPerKid;
        }
        static void Main(string[] args)
        {
            double trickOrTreaters = 250;
            double candyPerKid = 3;
            string weather = "Raining";
            string temperature = "70s";
            Console.WriteLine(HowMuchCandy(trickOrTreaters, candyPerKid, weather, temperature));
        }
    }
}
