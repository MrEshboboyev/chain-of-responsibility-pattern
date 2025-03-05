using ChainOfResponsibilityPatternInConsole.Abstracts;

namespace ChainOfResponsibilityPatternInConsole;

public class Client
{
    public static void ClientCode(AbstractHandler handler)
    {
        foreach (var food in new List<string> { "Nut", "Banana", "Cup of Coffee" })
        {
            Console.WriteLine($"Client: Who wants a {food}?");

            var result = handler.Handle(food);

            if (result != null)
            {
                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine($"{food} was left untouched");
            }
        }
    }
}
