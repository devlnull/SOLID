namespace SOLID.DIP;

public interface IPerson
{
    string NationalCode { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string EmailAddress { get; set; }
}