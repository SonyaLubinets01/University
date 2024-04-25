using System;
using System.Collections.Generic;
using System.Linq;

interface ISwimmable
{
    void Swim();
}

interface IFlyable
{
    int MaxHeight { get; }
    void Fly();
}

interface IRunnable
{
    int MaxSpeed { get; }
    void Run();
}

interface IAnimal
{
    int LifeDuration { get; }
    void Voice();
    void ShowInfo();
}

class Cat : IAnimal, IRunnable
{
    public int MaxSpeed { get; } = 50; 
    public int LifeDuration { get; } = 15; 

    public void Run()
    {
        Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
    }

    public void Voice()
    {
        Console.WriteLine("Meow!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"I am a Cat and I live approximately {LifeDuration} years.");
    }
}

class Eagle : IAnimal, IFlyable
{
    public int MaxHeight { get; } = 10000; 
    public int LifeDuration { get; } = 25; 

    public void Fly()
    {
        Console.WriteLine($"I can fly at {MaxHeight} meters height!");
    }

    public void Voice()
    {
        Console.WriteLine("No voice!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"I am an Eagle and I live approximately {LifeDuration} years.");
    }
}

class Shark : IAnimal, ISwimmable
{
    public int LifeDuration { get; } = 30; 

    public void Swim()
    {
        Console.WriteLine("I can swim!");
    }

    public void Voice()
    {
        Console.WriteLine("No voice!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"I am a Shark and I live approximately {LifeDuration} years.");
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();
        Console.WriteLine("Cat:");
        cat.ShowInfo();
        cat.Run();
        cat.Voice();
        Console.WriteLine();

        Eagle eagle = new Eagle();
        Console.WriteLine("Eagle:");
        eagle.ShowInfo();
        eagle.Fly();
        eagle.Voice();
        Console.WriteLine();

        Shark shark = new Shark();
        Console.WriteLine("Shark:");
        shark.ShowInfo();
        shark.Swim();
        shark.Voice();
        Console.WriteLine();

        Console.ReadKey();
    }
}

