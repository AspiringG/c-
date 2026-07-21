using System;

public class Program
{
    public static void Main(string[] args)
    {
        IEngine engine = new PetrolEngine();

        Car car = new Car(engine);
        car.Drive();
    }
}