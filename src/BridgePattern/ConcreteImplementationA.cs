using System;

namespace BridgePattern
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "Result Method OperationImplementation in ConcreteIplementationA Service.";
        }
    }
}