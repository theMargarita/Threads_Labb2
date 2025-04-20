using System.Threading;

namespace Threads_Labb2
{
    public class Cars
    {

        public static void Race()
        {
            Thread t1 = new Thread(Interferences);
            Thread t2 = new Thread(Interferences);
            Thread t3 = new Thread(Interferences);
            Thread t4 = new Thread(Interferences);

            t1.Name = "Blixten McQueen";
            t2.Name = "Bärgan";
            t3.Name = "Doc Hudson";
            t4.Name = "Sally Carrera";

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();



        }

        //methods for the different interference a car can get 
        public static void Interferences()
        {
          
        }

        //out of gas - 1/50 probability - stops for 15 seconds (15000)
        public static async OutOfGas()
        {

        }

        //Flat tier - 2/50 (1/25) probabilirt - stops for 10 seconds (10000)
        static async FlatTier()
        {

        }

        //Bird on the window - 5/50 (1/10) probability - stops for 5 seconds (5000)
        static async BirdOnTheWindow()
        {

        }


        //Error on the engine - 10/50 (1/5) probability - decrement with one km/h
        static async EngineError()
        {

        }

        //Cows on the road - 1/5 probability - stops for 15 seconds 
        static async CowsOnTheRoad()
        {
            Random rand = new Random();
            int probability = rand.Next();
        }
    }

}