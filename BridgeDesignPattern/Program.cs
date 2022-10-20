
using BridgeDesignPattern.ConcreteImplementation;
using BridgeDesignPattern.RefinedAbtraction;
using System;

namespace BridgeDesignPattern
{
    class Program
    {
        //Abstraction(Shape): định nghĩa giao diện của lớp trừu tượng,quản lý việc tham chiếu đến đối tượng hiện thực cụ thể(Implementation).
        //Refined Abstraction(Circle, Square): kế thừa Abstraction.
        //Implementation(Color): định nghĩa giao diện cho các lớp hiện thực.Thông thường nó là interface định ra các tác vụ nào đó của Abstraction.
        //ConcreteImplementation(Red, Blue): kế thừa Implementation và định nghĩa chi tiết hàm thực thi.
        

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
