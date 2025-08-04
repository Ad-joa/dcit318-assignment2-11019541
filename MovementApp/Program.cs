using System;

namespace MovementApp
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Class implementing IMovable: Car
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class implementing IMovable: Bicycle
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Main program
    class Program
    {
        static void Main()
        {
            IMovable myCar = new Car();
            IMovable myBike = new Bicycle();

            myCar.Move();
            myBike.Move();
        }
    }
}
