using ValidationAttribute;

public class User
{
    [RequiredField]
    public String Name { get; set; }
    public String Surname { get; set; }
}