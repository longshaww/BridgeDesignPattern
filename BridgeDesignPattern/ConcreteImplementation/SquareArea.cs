using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.ConcreteImplementation
{
    public class SquareArea : IAreaShape
    {
        public double GetAreaShape(int edge)
        {
            return edge * edge;
        }

    }
}
