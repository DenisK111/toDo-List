using Architecture;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoListConsoleApp
{
    public class Config
    {

       public static IServiceProvider ConfigureServices (IServiceCollection builder)
        {
            builder.AddDbContext<ListContext>();
            builder.AddScoped<IAddTaskService, AddTaskService>();
            builder.AddScoped<IGetEntries, GetEntries>();
             var provider = builder.BuildServiceProvider();
            return provider;

        }
    }
}
