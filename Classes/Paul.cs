using System;
public class Paul : Teammate, ITeammate
{
    public string Specialty { get; set; } = "Browserify";
    public string FirstName { get; set; } = "Paul";
    public string LastName { get; set; } = "Ellis";
    public string FullName { get => FirstName + " " + LastName; }
    public override void Work()
    {
        Console.WriteLine($"{FullName} will have your project split into a thousand modules all connected with {Specialty}.");
    }

    public Paul()
    {
    }

    public Paul(string specialty)
    {
        this.Specialty = specialty;
    }
}


