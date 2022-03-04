using Microsoft.Extensions.DependencyInjection;
using MockSequenceDemo.ConsoleApp;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MockSequenceDemo.ConsoleAppTest")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

IServiceProvider serviceProvider = StartUp.ConfigureServices();

IWorker worker = serviceProvider.GetRequiredService<IWorker>();

worker.DoWork();