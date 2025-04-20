namespace Threads_Labb2
{
    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; } 

        //primary contructor (with lambda)
        public Car(string name)
        {
            Name = name;
            Speed = 120;
        } 


    }

}