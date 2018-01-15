﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace works.ei8.Cortex.Graph.Domain.Model
{
    /// <summary>
    /// Adapter is treated as a Secondary Actor Port (http://alistair.cockburn.us/Hexagonal+architecture) 
    /// (eg. Port.Adapter.IO.Process.Events) since it is called by Application.
    /// </summary>
    public interface IEventLogClient
    {
        Task Subscribe(); 

        Task Subscribe(string position); 
    }
}
