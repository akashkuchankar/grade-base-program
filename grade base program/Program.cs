using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_base_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the mark of subject1");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark of subject2");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark of subject3");
            int c=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark of subject4");
            int d=Convert.ToInt32(Console.ReadLine());
             int total = a+b+c+d;
            int percentage = total * 100 / 400;
            Console.WriteLine("summation of obtain mark" + total);
            Console.WriteLine("total percentage"+ percentage);
            if (percentage >= 75 && percentage < 100)
            {
                Console.WriteLine("student obtain grade is A");
            }
               if(percentage<=75 && percentage>=61)
            {
                Console.WriteLine("student obtain grade is B");
            }
               if(percentage<=60 && percentage>=40)
            {
                Console.WriteLine("student obtain grade is C");
            }
               if(percentage<40 && percentage==0)
            {
                Console.WriteLine("student is fail");
            }    
               Console.ReadLine();


                
        }
    }
}
