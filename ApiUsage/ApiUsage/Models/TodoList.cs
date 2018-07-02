﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUsage.Models
{
    public class TodoList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<TodoItem> ItemsTodo { get; set; }
    }
}
