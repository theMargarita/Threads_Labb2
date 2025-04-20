namespace Threads_Labb2
{
    class EngineProblem
    {
        //Error on the engine - 10/50 (1/5) probability - decrement with one km/h
        public static void EngineError(string name, Car Car)
        {

            Random rand = new Random();
            var randomEngineError = rand.Next(1, 5);

            if (randomEngineError == 1)
            {
                Console.WriteLine($"{name} got some engine problem - ");
                Car.Speed = -1;
                if(Car.Speed < 1)
                {
                    Console.WriteLine($"{name} new speed is {Car.Speed} km/h");
                }
            }
            else
            {
                Console.WriteLine("Something with the engine error went wrong");
            }
        }

    }
}
