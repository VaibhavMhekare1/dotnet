namespace Membership;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }
    public string Location { get; set; }

    public User(string firstname, string lastname, string email, string contactnumber, string location)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Email = email;
        this.ContactNumber = contactnumber;
        this.Location = location;
    }
}