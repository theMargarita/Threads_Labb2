namespace Threads_Labb2
{
    public class Race
    {
        public static List<Car> Cars = new();
        public static List<Thread> Threads = new();
    
        //om man vill jobba med threads så kanske man bör göra tre olika metoder för att bilarna ska kunna köra concurrently 
        public static void StartRace()
        {
            Car car1 = new Car("Blixten McQueen");
            Car car2 = new Car("Bettan");
            Car car3 = new Car("Den Röda Faran");
            Car car4 = new Car("Bulan");

            Random random = new Random();
            ////foreach loop for cars
            //foreach (var car in Cars)
            //{
            //    Console.WriteLine($"{car.Name} start driving");
            //    for (int km = 1; km <= 5; km++)
            //    {
            //        if (random.Next(1, 101) < 30)
            //        {
            //            Console.WriteLine($"Oh no {car.Name} got some trubble");
            //            RandomMethods(car);
            //        }
            //        Thread.Sleep(500);
            //        Console.WriteLine($"{car.Name} has driven {km} km");

            //    }
            //    Console.WriteLine($"{car.Name} has won");
            //}

            foreach (var car in Cars)
            {
                Thread t = new Thread(RandomMethods(car));
                Threads.Add(t);
                t.Start();
            }

            Thread statusThread = new Thread(() =>
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if(input == "")
                    {
                        foreach(var car in Cars)
                        {
                            Console.WriteLine($"Status: {car.Name}");
                        }
                    }
                }
            });

            foreach(var t in Threads)
            {
                t.Join(); //to wait for the reast
            }

            statusThread.Join(); //to finish the thread
            Console.WriteLine("The race is now over");
        }

     

        public static void CreateThread()
        {
            //List<Thread> threads = new();
            //List<Car> Cars = new List<Car>();

            foreach (var car in Cars)
            {
                Thread t = new Thread(() => StartRace());
                Threads.Add(t);

                t.Start(car);
                foreach (var tt in Threads)
                {
                    tt.Join();//to wait for the rest of the threads to finish 
                }
            }

        }
    }
}
