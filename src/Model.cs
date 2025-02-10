public class Model
{
    private string _name = ""; // Default empty name
    private int _age = 0; // Default age = 0

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public int GetAge()
    {
        return _age;
    }
}
