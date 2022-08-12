using Architecture;
using Architecture.Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GetEntries : IGetEntries
    {
        private readonly ListContext context;

        public GetEntries(ListContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<todoTask>> GetAllTasks()
        {
            var list = await Task.Run( () => context.Tasks.OrderBy(x=>x.Task).ToList());
            return list;
        }
    }
}
