﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IAddTaskService
    {
        Task AddTask(string task, int month, int date, TimeSpan time);
    }
}
