using System;
public class Sean : ITeammate
{
    public string Specialty { get; set; } = "This.";
    public string FirstName { get; set; } = "Sean";
    public string LastName { get; set; } = "Williams";
    public string FullName { get => FirstName + " " + LastName; }
    public   void Work()
    {
        Console.WriteLine($"{FullName} will do {Specialty} to all of your JS objects.");
    }

    public Sean()
    {
    }

    public Sean(string specialty)
    {
        this.Specialty = specialty;
    }
}


