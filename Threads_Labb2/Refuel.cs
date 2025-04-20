namespace Threads_Labb2
{
    class Refuel
    {
        //out of gas - 1/50 probability - stops for 15 seconds (15000)
        public static async Task OutOfGas(string name)
        {
            Random rand = new Random();
            var randomGas = rand.Next(1, 51);

            if (randomGas == 1)
            {
                Console.WriteLine($"{name} have run out of gas - refuel");
                await Task.Delay(15000); //15 seconds
                
            }
            else
            {
                Console.WriteLine("Refueling went wrong");
            }
        }

    }
}
