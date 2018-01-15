public interface ITeammate
{
    string Specialty  { get; set; } 
    string FirstName { get; set; }
    string LastName { get; set; }
    string FullName { get; }

    void Work();
    
}