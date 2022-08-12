using Architecture;
using Architecture.Models;
using Services.Contracts;

namespace Services
{
    public class AddTaskService : IAddTaskService
    {
        private readonly ListContext context;

        public AddTaskService(ListContext context)
        {
            this.context = context;
        }

        public async Task AddTask(string task, int month, int date, TimeSpan time)
        {
            var dateTime = new DateTime(DateTime.Now.Year, month, date, time.Hours, time.Minutes, 0);
            await context.AddAsync(new todoTask { Name = task, Task = dateTime });
            await context.SaveChangesAsync();
            
        }
    }
}