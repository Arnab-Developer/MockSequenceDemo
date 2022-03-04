using MockSequenceDemo.ConsoleApp;
using Moq;
using Xunit;

namespace MockSequenceDemo.ConsoleAppTest;

public class WorkerTest
{
    [Fact]
    public void DoWorkTest()
    {
        Mock<IDependency1> dependency1Mock = new(MockBehavior.Strict);
        Mock<IDependency2> dependency2Mock = new(MockBehavior.Strict);

        MockSequence mockSequence = new();

        dependency1Mock
            .InSequence(mockSequence)
            .Setup(s => s.DoWork());

        dependency2Mock
            .InSequence(mockSequence)
            .Setup(s => s.DoWork());

        IWorker worker = new Worker(dependency1Mock.Object, dependency2Mock.Object);
        worker.DoWork();

        dependency1Mock.Verify(v => v.DoWork(), Times.Once);
        dependency1Mock.Verify(v => v.DoWork(), Times.Once);
    }
}