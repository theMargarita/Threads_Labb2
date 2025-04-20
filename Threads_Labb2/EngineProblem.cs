namespace Threads_Labb2
{
    class EngineProblem
    {
        //Error on the engine - 10/50 (1/5) probability - decrement with one km/h
        public static async Task EngineError(string name, Car Car)
        {

            Random rand = new Random();
            var randomEngineError = rand.Next(1, 5);

            if (randomEngineError == 1)
            {
                Console.WriteLine($"{Car.Name} got some engine problem");
                Car.Speed = -1;
                if (Car.Speed < 1)
                {
                    for (int km = 1; 1 <= 5; km++)
                    {
                        Console.WriteLine($"{name} new speed is {Car.Speed} km/h");
                        double secPerKm = 3600 / Car.Speed; //better with double for precision 

                        await Task.Delay((int)(1000 * secPerKm)); //use int for rounding numbers, maybe not necessary - could just use int but why not double
                    }
                }
            }
            else
            {
                Console.WriteLine("Something with the engine error went wrong");
            }
        }

    }
}
