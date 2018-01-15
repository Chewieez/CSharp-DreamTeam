using System;
public class Kimmie : Teammate, ITeammate
{
    public string Specialty { get; set; } = "ESLint";
    public string FirstName { get; set; } = "Kimmie";
    public string LastName { get; set; } = "Bird";
    public string FullName { get => FirstName + " " + LastName; }
    public override void Work()
    {
        Console.WriteLine($"{FullName} will keep all of your code spic and span with {Specialty}.");
    }

    public Kimmie()
    {
    }

    public Kimmie(string specialty)
    {
        this.Specialty = specialty;
    }
}


