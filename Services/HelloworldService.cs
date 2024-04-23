public class HelloWorldService : IHelloWorldService
{
    public string getHelloWorld()
    {
        return "Hello World";
    }
}

public interface IHelloWorldService
{
    string getHelloWorld();
}