using System;

namespace BridgeDesignPattern
{
    class Program
    {
        // Tạo interface color
        interface Color
        {
            string GetColor();
        }
        //Tạo class màu đỏ implement Interface Color
        class Red : Color
        {
            //Override phương thức của Interface Color
            public string GetColor()
            {
                return "Red";
            }
        }
        //Tạo class màu xanh dương implement Interface Color
        class Blue : Color
        {
            //Override phương thức của Interface Color
            public string GetColor()
            {
                return "Blue";
            }
        }
       
        // Tạo interface AreaShape
        interface AreaShape{
            double GetAreaShape(int param);
        }

        
        // Tạo class Square Area implement Interface AreaShape
        class SquareArea : AreaShape
        {
            //Override phương thức của Interface AreaShape
            public double GetAreaShape(int edge)
            {
                return edge * edge;
            }

        }
        // Tạo class Circle Area implement Interface AreaShape
        class CircleArea : AreaShape
        {
            //Override phương thức của Interface AreaShape
            public double GetAreaShape(int radius)
            {
                return (radius * radius) * 3.14;
            }
        }

        //Tạo abstract class Shape
        abstract class Shape
        {   
            //Define thuộc tính param cho Shape dùng để tính toán
            public int param { get; set; }
            //Define Interface GetArea
            public AreaShape areaShape { get; set; }
            //Override phương thức của Interface AreaShape
            public double GetArea()
            {
                return areaShape.GetAreaShape(param);
            }
            //Define Interface Color
            public Color color { get; set; }
            //Override phương thức của Interface Color
            public string GetColor()
            {
                return color.GetColor();
            }
        }

        class Square : Shape 
        {
        }

        class Circle : Shape
        {        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tao doi tuong");
            var blue_color = new Blue();
            var red_color = new Red();
            var circle_area = new CircleArea();
            var square_area = new SquareArea();
            Square red_square = new Square { color = red_color, areaShape=square_area,param = 3 };
            Circle blue_circle = new Circle { color = blue_color, areaShape = circle_area, param = 3 };
            Console.WriteLine($"Diện tích hình và màu của hình vuông đỏ: {red_square.GetColor()} {red_square.GetArea()}");
            Console.WriteLine($"Diện tích hình và màu của hình tròn xanh: {blue_circle.GetColor()} {blue_circle.GetArea()}");


            //Console.WriteLine($"Mau hinh vuong xanh: {blue_square.GetColor()}");
            //Console.WriteLine($"Mau hinh vuong do: {red_square.GetColor()}");
            //Console.WriteLine($"Mau hinh tron xanh: {blue_circle.GetColor()}");
            //Console.WriteLine($"Mau hinh tron do: {red_circle.GetColor()}");

        }

    }
}
