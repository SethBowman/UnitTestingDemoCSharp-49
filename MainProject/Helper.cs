namespace MainProject;

public class Helper
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public string Greet(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return "Hello!";
        }

        return $"Hello, {name}!";
    }
    
}