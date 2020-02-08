using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterOfRoadAndSpeedAndLengthAndTimeUnits
{
    class Program
    {
        static double TimeTotalSeconds(double hours, double minutes, double seconds)
        {
            double SecsTotal = hours * 3600 + minutes * 60 + seconds;
            return SecsTotal;
        }
        static double TimeTotalHours(double hours, double minutes, double seconds)
        {
            double HoursTotal = hours + minutes / 60 + seconds / 3600;
            return HoursTotal;
        }
        static double DistanceInMiles(double metres)
        {
            double DistanceInMiles = (metres / 1000) / 1.609;
            return DistanceInMiles;
        }
        static double DistanceInKilometres(double metres)
        {
            double KilometresTotal = metres / 1000;
            return KilometresTotal;
        }
        static void Main(string[] args)
        {          
            var DistanceMetres = double.Parse(Console.ReadLine());
            var TimeHours = double.Parse(Console.ReadLine());
            var TimeMinutes = double.Parse(Console.ReadLine());
            var TimeSeconds = double.Parse(Console.ReadLine());
            double TimeTotalInSeconds = TimeTotalSeconds(TimeHours, TimeMinutes, TimeSeconds);
            Console.WriteLine((TimeTotalInSeconds));
            double AllHours = TimeTotalHours(TimeHours, TimeMinutes, TimeSeconds);
            Console.WriteLine(AllHours);
            double AllMiles = DistanceInMiles(DistanceMetres);
            Console.WriteLine(AllMiles);
            double AllKilometres = DistanceInKilometres(DistanceMetres);
            Console.WriteLine(AllKilometres);
            double SpeedInMS = DistanceMetres / TimeTotalInSeconds;
            double SpeedInKMH = AllKilometres / AllHours;
            double SpeedInMPH = AllMiles / AllHours;
            Console.WriteLine(SpeedInMS);
            Console.WriteLine(SpeedInKMH);
            Console.WriteLine(SpeedInMPH);
        }
    }
}
