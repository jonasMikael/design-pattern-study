using System;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Models
{
    public class Adapter : ITarget
    {
        public string GetRequesJson()
        {
            throw new NotImplementedException();
        }
    }
} 