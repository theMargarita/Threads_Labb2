using Theads_Labb2_2._0;

namespace Threads_Labb2
{
    public class Race
    {
        public static List<Car> Cars = new();
        public static List<Thread> Threads = new();

        //om man vill jobba med threads så kanske man bör göra tre olika metoder för att bilarna ska kunna köra concurrently 
        public static void StartRace()
        {
            //add cars for the status checker
            CheckStatus.Cars = Cars;

            //start the status checker
            CheckStatus.Status();

            Cars.Add(new Car("Blixten Mcqueen"));
            Cars.Add(new Car("Röda Faran"));
            Cars.Add(new Car("Bulan"));
            Cars.Add(new Car("Bettan"));

            

            foreach (var car in Cars)
            {
                Thread t = new Thread(() => CreateRace(car));
                Threads.Add(t);
                t.Start();
                Thread.Sleep(10000);
            }

            foreach (var t in Threads)
            {
                t.Join();//to wait for the rest of the threads to finish ?
            }
        }

        public static void CreateRace(Car car)
        {
            double time = DateTime.Today.Second;
            Console.WriteLine($"{car.Name} has start the race");

            while (car.MinLength < car.MaxLength)
            {
                var meterPerSeconds = car.Speed / 3.6; // to get m/s
                car.MinLength += meterPerSeconds;
                time += 1;

                if (time % 10 == 0) //every 10 seconds the random event wil activate 
                {
                    Console.WriteLine($"{car.Name} has traveled {car.MinLength}m");
                    RandomMethods.Methods(car);
                    CheckStatus.Status();
                }
                else
                {
                    Console.WriteLine("Something went wrong with the if statement in CreateRace");
                }
                Thread.Sleep(1000); //"time passing"
            }

            car.Status = true;
            Console.WriteLine($"{car.Name} has finished the race");
        }


    }
}
