﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public static class MockQueue
    {
        public static ConcurrentQueue<string> QueueMessage { get; set; } = new ConcurrentQueue<string>();
    }
}
