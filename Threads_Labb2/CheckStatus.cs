
using System.Threading;

namespace Threads_Labb2
{
    public static class CheckStatus
    {
        //bakground thread for status - readline, while and if statements should be enough

        public static List<Car> Cars = new();
        public static  void Status()
        {
            Thread statusThread = new Thread(() =>
            {
                Console.WriteLine("Press enter to get an update");
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "")
                    {
                        foreach (var car in Cars)
                        {
                            double totalLength = DateTime.Today.Second * car.Speed; // distance = speed * time

                            Console.WriteLine($"{car.Name}: {totalLength:F1}m, " +
                                $"Speed: {car.Speed:F1} km/h, " +
                                $"Status: {(car.Status ? "Finished" : "Racing")}"); //tenary statement
                        }
                    }

                    if(Cars.All(c => c.Status))
                    {
                        Console.WriteLine("Race is now over");
                        break;
                    }
                }
            });

            statusThread.IsBackground = true;
            statusThread.Start();
        }
    }
}
