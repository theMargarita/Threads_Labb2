namespace Threads_Labb2
{
    class FlatTier
    {
        //Flat tier - 2/50 (1/25) probabilirt - stops for 10 seconds(10000)
        public static async Task TierFlat(string name, Car Car)
        {
            Random rand = new Random();
            var randomFlatTier = rand.Next(1, 26);

            if(randomFlatTier == 1)
            {
                Console.WriteLine($"{Car.Name} got a flat tier - fixes the tier");

                await Task.Delay(10000);
            }
            else
            {
                Console.WriteLine("Flat tier went wrong");
            }
        }

    }
}
