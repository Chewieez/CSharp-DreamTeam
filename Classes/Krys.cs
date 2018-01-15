using System;
public class Krys : ITeammate
{
    public string Specialty { get; set; } = "CSS Animations";
    public string FirstName { get; set; } = "Krys";
    public string LastName { get; set; } = "Mathis";
    public string FullName { get => FirstName + " " + LastName; }
    public   void Work()
    {
        Console.WriteLine($"{FullName} will make all the {Specialty} on your project bounce, flash and fade.");
    }

    public Krys()
    {
    }

    public Krys(string specialty)
    {
        this.Specialty = specialty;
    }
}
