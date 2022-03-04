namespace MockSequenceDemo.ConsoleApp;

internal class Dependency1 : IDependency1
{
    void IDependency1.DoWork() => Console.WriteLine("Dependency1 dowork");
}
