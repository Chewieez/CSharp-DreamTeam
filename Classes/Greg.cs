using System;

public class Greg : ITeammate
{
    public string Specialty { get; set; } = "angularJS";
    public string FirstName { get; set; } = "Greg";
    public string LastName { get; set; } = "Lawrence";
    public string FullName { get => FirstName + " " + LastName; }
    public   void Work()
    {
        Console.WriteLine($"{FullName} will make the most sharp and dynamic {Specialty} project.");
    }

    public Greg()
    {
    }

    public Greg(string specialty)
    {
        this.Specialty = specialty;
    }
}




