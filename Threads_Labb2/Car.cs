namespace Threads_Labb2
{
    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        //Because every car should have their own random generator ?
        //public Random Random = new Random();

        public bool Status { get; set; } 

        //primary contructor (with lambda)
        public Car(string name)
        {
            Name = name;
            Speed = 120;
            Status = false;
        } 


    }

}