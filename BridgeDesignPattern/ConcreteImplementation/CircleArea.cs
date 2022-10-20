using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.ConcreteImplementation
{
    public class CircleArea : IAreaShape
    {
        public double GetAreaShape(int radius)
        {
            return (radius * radius) * 3.14;
        }
    }

}
