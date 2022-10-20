using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.ConcreteImplementation
{
    public class Blue : IColor
    {
        public string GetColor()
        {
            return "Blue";
        }
    }
}
