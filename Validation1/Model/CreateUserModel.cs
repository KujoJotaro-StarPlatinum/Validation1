namespace Validation1.Model;

public class CreateUserModel
{
    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string Bio { get; set; }

    public Adress? Adress { get; set; }

    public int? Age { get; set; }

    public List<Contact>? Contacts { get; set; }
}