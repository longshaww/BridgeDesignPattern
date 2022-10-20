using System;

namespace BridgeDesignPattern
{
    class Program
    {
        // B1: Tạo interface color
        interface Color
        {
            string GetColor();
        }

        interface AreaShape{
            int GetAreaShape();
        }

        //Tạo class màu xanh implement Interface Color
        class Blue : Color
        {
            //Override phương thức của Interface Color
            public string GetColor()
            {
                return "Blue";
            }
        }
        //Tạo class màu xanh implement Interface Color
        class SquareArea : AreaShape
        {
            //Override phương thức của Interface AreaShape
            public int GetAreaShape()
            {
                return 0;
            }

        }
        class CircleArea: AreaShape
        {
            //Override phương thức của Interface AreaShape
             public int GetAreaShape()
            {
                return 0;
            }
        }
        //Tạo class màu xanh implement Interface Color
        class Red : Color
        {
            //Override phương thức của Interface Color
            public string GetColor()
            {
                return "Red";
            }
        }

        //Tạo abstract class Shape
        abstract class Shape
        {   
            //Define Color property
            public Color color { get; set; }
            public AreaShape areaShape { get; set; }
            //Define Shape Constructor

            //Define Interface Color
            //Override phương thức của Interface Color
            public int GetArea()
            {
                return areaShape.GetAreaShape();
            }
            public string GetColor()
            {
                return color.GetColor();
            }
        }

        class Square : Shape 
        {
            public int edge;
            //Override lại phương thức
            public int GetArea()
            {
                return edge * edge;
            }
        }

        class Circle : Shape
        {
            public int radius;
            
            public double GetArea()
            {
                return (radius * radius) * 3.14;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tao doi tuong");
            var blue_color = new Blue();
            var red_color = new Red();
            var circle_area = new CircleArea();
            var square_area = new SquareArea();
            Square red_square = new Square { color = red_color, areaShape=square_area,edge = 3 };
            Circle blue_circle = new Circle { color = blue_color, areaShape = circle_area, radius = 3 };
            Console.WriteLine($"Diện tích hình và màu của hình vuông đỏ: {red_square.GetColor()} {red_square.GetArea()}");
            Console.WriteLine($"Diện tích hình và màu của hình tròn xanh: {blue_circle.GetColor()} {blue_circle.GetArea()}");


            //Console.WriteLine($"Mau hinh vuong xanh: {blue_square.GetColor()}");
            //Console.WriteLine($"Mau hinh vuong do: {red_square.GetColor()}");
            //Console.WriteLine($"Mau hinh tron xanh: {blue_circle.GetColor()}");
            //Console.WriteLine($"Mau hinh tron do: {red_circle.GetColor()}");

        }

    }
}
