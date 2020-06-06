using System;
using BridgePattern.Interfaces;

namespace BridgePattern.Services
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "Result Method OperationImplementation in ConcreteIplementationA Service.";
        }
    }
}