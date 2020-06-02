using System;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters
{
    public class AdapterCSV : ITarget
    {
        public string GetRequest()
        {
            throw new NotImplementedException();
        }
    }
} 