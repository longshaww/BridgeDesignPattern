using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.ConcreteImplementation
{
    public class Red : IColor
    {
        public string GetColor()
        {
            return "Red";
        }
    }
}
