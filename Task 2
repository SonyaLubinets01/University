using System;

public class Employee
{
    internal string name;
    private DateTime hiringDate;

    public Employee(string name, DateTime hiringDate)
    {
        this.name = name;
        this.hiringDate = hiringDate;
    }

    public int Experience()
    {
        TimeSpan experienceTimeSpan = DateTime.Now - hiringDate;
        int experienceYears = (int)(experienceTimeSpan.Days / 365.25);
        return experienceYears;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{name} has {Experience()} years of experience");
    }
}

public class Developer : Employee
{
    private string programmingLanguage;

    public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public string GetProgrammingLanguage()
    {
        return programmingLanguage;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"{name} is {programmingLanguage} programmer");
    }
}

public class Tester : Employee
{
    private bool isAutomation;

    public Tester(string name, DateTime hiringDate, bool isAutomation) : base(name, hiringDate)
    {
        this.isAutomation = isAutomation;
    }

    public bool IsAutomation()
    {
        return isAutomation;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        string type = isAutomation ? "automated" : "manual";
        Console.WriteLine($"{name} is {type} tester");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Developer dev = new Developer("Alex Pina", new DateTime(2020, 1, 1), "C#");
        Tester tester = new Tester("James Bond", new DateTime(2018, 6, 15), true);

        Console.WriteLine("Developer:");
        dev.ShowInfo();

        Console.WriteLine("\nTester:");
        tester.ShowInfo();
    }
}
