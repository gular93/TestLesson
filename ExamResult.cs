using System;
using TestLesson;
using System.Collections.Generic;
using System.Text;

namespace TestLesson
{
    public class ExamResult
    {
        
        //Car bmw = new Car("bmw");
       
        int a = 6;
        
        //var,const,dynamic
        //local vs global variables
        //int metod
        //default
        //ConsoleRead;
        //const //degerleri almaga mecburdurlar readonly
        public void SeeResult()
        {
           // private readonly string string;
//const int first1 = 7;
             
            
            //Console.WriteLine(first1);
          //  Console.WriteLine(sec2);
            // var a = 's';
            //dynamic a = 's';
            // const int a = 5;
            //  int a = default;
            //int a = 5;
            char name  = 'd';
             string ad = "123";
            int num = int.Parse(ad);
            int result = num.CompareTo(123);
            
            bool result1=typeof(decimal).IsPrimitive;
            Console.WriteLine(result1);
            var data=Console.Read();

            Console.WriteLine("HI "+data);
            
            int a = 259;

            int bd = a;
            
            int num3 = 257;
           byte byt3 = (byte)num3;
            Console.WriteLine(byt3);
            decimal b = 5;
            const int numbers= 34;
     
            //var d = Console.Read();
           // var dd;
           // dynamic set;
           
      
            double ket = 256;
            byte dee = (byte)ket;
            Console.WriteLine(dee);
        }
        public void ExamCalculate()
        {
           // Car.Speed
            int a = 6;//value 
            int b = a;//values

            //object objc = a;//boxing
           

            //int c = (int)objc;//unboxing

            //List<int> aa = new List<int>();


            
        }

    }
}
