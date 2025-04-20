namespace Threads_Labb2
{
    class BirdAttack
    {
        //Bird on the window - 5/50 (1/10) probability - stops for 5 seconds(5000)
        public static async Task BirdOnTheWindow(string name)
        {
            Random rand = new Random();
            var randomBird = rand.Next(1, 11);

            if(randomBird == 1)
            {
                Console.WriteLine($"{name} got hit by a bird - washing the windows..");

                await Task.Delay(5000);
            }
            else
            {
                Console.WriteLine("Washing of bird went wrong");
            }
        }

    }
}
