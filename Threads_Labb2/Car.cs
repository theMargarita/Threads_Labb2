namespace Threads_Labb2
{
    public class Car
    {
        public string Name { get; set; }
        public double Speed { get; set; } = 120.0d;
        public double MinLength { get; set; }
        public double MaxLength { get; set; } 

        //Because every car should have their own random generator ?
        public Random Random = new Random();
        public bool Status { get; set; }


        //primary contructor (with lambda)
        public Car(string name) => Name = name;
    }

}