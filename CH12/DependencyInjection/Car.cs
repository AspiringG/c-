using System;

public class Car
{
    private IEngine engine; 

    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void Drive()
    {   
        engine.Start();

        Console.WriteLine("Car is driving");
    }
}