using System;
using System.Text;

namespace TestLesson
{
    public class Shape
    {
        string Name;
        int width;
        int length;

        //implementation
        public Shape()
        {

        }
        public Shape(int size)
        { 

        }
        public virtual int Calculate(int width,int length)
        {
            return width * length;                        
        }
        public string GetName()
        {
            Console.WriteLine();
            return "s";

    }
     public class Square:Shape
     {
        public int Length { get; set; }
        public override int Calculate(int width, int length)
        {
            Console.WriteLine("It is Square");
            return width * length;
        }

    }
    public class SRectangle : Rectangle
    {

    }
    public class Rectangle:Shape
    {
     
    }

        public class Program
        {
            static void Main(string[] args)
            {

               
                int a = 5;
                // string s = a.ToString();
                // object sobj = 4;//
                //  int s = (int)sobj;//

                Square s = new Square();
                Shape sh = new Square();
                sh.Calculate(4, 5);
                s.Calculate(4, 5);
                SRectangle sr = new SRectangle();

                Rectangle r = new Rectangle();
                Shape sh1 = new Shape();
                Rectangle r1 = sh1 as Rectangle;


                if (r1 == null)
                {
                    Console.WriteLine("true");

                }
                // Rectangle r1 = (Rectangle)sh1;//downcasting
                sh1.Calculate(3, 4);
                r.Calculate(4, 5);

            }
        }
    }
   
}
