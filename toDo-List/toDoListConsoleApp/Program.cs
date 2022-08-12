using Microsoft.Extensions.DependencyInjection;
using Services.Contracts;

namespace toDoListConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var provider = Config.ConfigureServices(new ServiceCollection());


            await provider.GetRequiredService<IAddTaskService>().AddTask("test",09,20,new TimeSpan(23,40,0));

            var listOfTasks = await provider.GetRequiredService<IGetEntries>().GetAllTasks();
            Console.WriteLine(String.Join(Environment.NewLine,listOfTasks));
            Console.ReadKey();
        }

        
    }
}