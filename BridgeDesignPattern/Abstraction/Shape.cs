using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.Abstraction
{
    public abstract class Shape
    {
        public int param { get; set; }
        public IAreaShape areaShape { get; set; }
        public double GetArea()
        {
            return areaShape.GetAreaShape(param);
        }
        public IColor color { get; set; }
        public string GetColor()
        {
            return color.GetColor();
        }
    }
}
