// The other part of the client code constructs actual chain
using ChainOfResponsibilityPatternInConsole;
using ChainOfResponsibilityPatternInConsole.Handlers;

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

// The client should be able to send a request to any handler , not 
// just the first one of the chain
Console.WriteLine("Chain : Monkey > Squirrel > Dog");
Client.ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
Client.ClientCode(dog);