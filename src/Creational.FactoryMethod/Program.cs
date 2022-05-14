// See https://aka.ms/new-console-template for more information

using System;

namespace Creational.FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Application Started!");

        var roadLogistic = new RoadLogistic();
        var transport = roadLogistic.CreateTransport();
        transport.Deliver();

        var seaLogistic = new SeaLogistic();
        var transport2 = seaLogistic.CreateTransport();
        transport2.Deliver();
    }
}

interface ILogistic
{
    ITransport CreateTransport();
}

class RoadLogistic : ILogistic
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}

class SeaLogistic : ILogistic
{
    public ITransport CreateTransport()
    {
        return new Ship();
    }
}

interface ITransport
{
    void Deliver();
}

class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine($"Delivering via {nameof(Truck)}");
    }
}

class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine($"Delivering via {nameof(Ship)}");
    }
}
