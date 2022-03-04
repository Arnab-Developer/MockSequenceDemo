namespace MockSequenceDemo.ConsoleApp;

internal class Worker : IWorker
{
    private readonly IDependency1 _dependency1;
    private readonly IDependency2 _dependency2;

    public Worker(IDependency1 dependency1, IDependency2 dependency2)
    {
        _dependency1 = dependency1;
        _dependency2 = dependency2;
    }

    void IWorker.DoWork()
    {
        _dependency1.DoWork();
        _dependency2.DoWork();
    }
}
