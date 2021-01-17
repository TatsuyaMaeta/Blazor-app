using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TodoList
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
