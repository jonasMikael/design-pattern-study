using System;

namespace BridgePattern
{
    public class Abstraction
    {
        private readonly IImplementation _implementation;

        public Abstraction(IImplementation implementation) => this._implementation = implementation;

        public virtual string Operation(){
             return "Abstract: Base operation with:\n" + 
                _implementation.OperationImplementation();
        }
    }
}