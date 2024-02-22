public class User
{
    public string FirstName { get; set; }
    public string LastName {get; set;}
    public string UserName;
    public string Password;
    public bool IsLogedIn;

    public void LogIn()
    {
        if (UserName==Password)
        {
            System.Console.WriteLine($"User logged in successfully");
            IsLogedIn=true;
        }
        else{
            System.Console.WriteLine($"Your password or username is incorrect");
        }
    }
    public void Logout()
    {
        IsLogedIn = false;
    }
    public string GetFullInfo()
    {
        return $"{FirstName} {LastName} {IsLogedIn}";
    }
}