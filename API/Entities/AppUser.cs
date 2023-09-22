namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }

    private string userName;

    public string GetUserName()
    {
        return userName;
    }

    public void SetUserName(string value)
    {
        userName = value;
    }
}
