using System;
using BridgePattern.Interfaces;

namespace BridgePattern.Services
{
   public  class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "Result Method OperationImplementation in ConcreteIplementationB Service.";
        }
    }}