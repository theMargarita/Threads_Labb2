namespace Threads_Labb2
{
    class Cows
    {
        //Cows on the road - 1/5 probability - stops for 15 seconds 
        public static async Task CowsOnTheRoad(string name, Car Car)
        {
            Random rand = new Random();
            int randomCow = rand.Next(1, 5);

            if (randomCow == 1)
            {
                Console.WriteLine($"{Car.Name} got stopped by cows - waiting for them too move");
                await Task.Delay(15000);
            }
            else
            {
                Console.WriteLine($"Might be a cow problem");
            }
        }

    }
}
