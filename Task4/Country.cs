public class Country
{
    string _name;
    string _cpaital;
    int _population;
    string _officialLanguage;
    public void SetCapital(string capital)
    {
        _cpaital=capital;
    }
    public string GetCapital()
    {
        return _cpaital;
    }
    public void SetPopulation(int population)
    {
        _population =  population;
    }
    public int GetPopulation()
    {
        return _population;
    }
    public void SetOfficialLanguage(string language)
    {
        _officialLanguage = language;
    }
    public string GetOfficialLanguage()
    {
        return _officialLanguage;
    }

    public Country(string name, string capital, int population, string officialLanguage)
    {
        _name = name;
        _cpaital = capital;
        _population = population;
        _officialLanguage = officialLanguage;
    }
}