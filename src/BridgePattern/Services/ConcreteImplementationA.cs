using System;
using BridgePattern.Interfaces;

namespace BridgePattern.Services
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            throw new NotImplementedException();
        }
    }
}