public class Author
{
    string _name;
    int _age;
    string _nationality;
    public string GetName()
    {
        return _name;
    }
    public int GetAge()
    {
        return _age;
    }
    public string GetNationality()
    {
        return _nationality;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"Номи ман {_name}. Ман {_age} сола ҳастам. Ман аз {_nationality} ҳастам.");
    }
    public void CelebrateBirthday()
    {
        System.Console.WriteLine($"{_age+1}");
    }
    public Author()
    {

    }
    public Author(string name, int age)
    {
        _name=name;
        _age=age;
    }
    public Author(string name, int age, string nationality)
    {
        _name=name;
        _age=age;
        _nationality=nationality;
    }
}