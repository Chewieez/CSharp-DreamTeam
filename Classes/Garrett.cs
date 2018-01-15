using System;
public class Garrett : Teammate, ITeammate
{
    public string Specialty { get; set; } = "Grunt";
    public string FirstName { get; set; } = "Garrett";
    public string LastName { get; set; } = "Ward";
    public string FullName { get => FirstName + " " + LastName; }
    public override void Work()
    {
        Console.WriteLine($"{FullName} will {Specialty} a lot during your project, but don't worry, he's just helping you run tasks automatically in the background.");
    }

    public Garrett()
    {
    }

    public Garrett(string specialty)
    {
        this.Specialty = specialty;
    }
}


