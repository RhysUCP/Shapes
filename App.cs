using System;

namespace Shapes
{
    class App
    {
        public App()
        {}

        public void Run()
        {
            Triangle triangleOne = new Triangle();

            Console.WriteLine("Enter the height of the triangle: ");
            triangleOne.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the base length of the triangle: ");
            triangleOne.BaseLength = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("The area of the triangle is " + triangleOne.GetArea());
        }

    }
}