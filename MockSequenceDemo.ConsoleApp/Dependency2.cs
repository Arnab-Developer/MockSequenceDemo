namespace MockSequenceDemo.ConsoleApp;

internal class Dependency2 : IDependency2
{
    void IDependency2.DoWork() => Console.WriteLine("Dependency2 dowork");
}
