using Threads_Labb2;

namespace Theads_Labb2_2._0
{
    public class RandomMethods
    {
        public static void Methods(Car car)
        {
            Random random = new Random();
            int randomRoll = random.Next(1, 101); //counted from hundred - like hundred precent

            if (randomRoll <= 10) //bird attack - 10%
            {
                Console.WriteLine($"Oh no {car.Name} got hit by a bird - stops for 5 seconds");
               Thread.Sleep(5000);
            }
            else if (randomRoll <= 5) //cows on the road - 20%
            {
                Console.WriteLine($"Oh no cows on the road for {car.Name}- have to wait for 15 seconds");
                Thread.Sleep(15000);
            }
            else if (randomRoll <= 20)//engine problems - 20% - should get slower with 1 km/h
            {
                Console.WriteLine($"Oh no smoke is comming out of {car.Name} - slows down a bit");
                if (car.Speed > 1)
                {
                    car.Speed -= 1;
                }
                //double secPerKm = 3600 / car.Speed;
                Thread.Sleep((1000));
            }
            else if (randomRoll <= 50) //out fo gas - 50%
            {
                Console.WriteLine($"Oh no {car.Name} have run out of gas - stops for 15 seconds");
                Thread.Sleep(15000);
            }
            else if (randomRoll <= 25) //flat tier - 25%
            {
                Console.WriteLine($"Oh no {car.Name} got hit by a bird - stops for 5 seconds");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Something went wrong with the async method");
            }
            
        }
    }
}
