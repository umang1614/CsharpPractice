using System;
using CommonLibrary._01_CSharpBasics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;


namespace CsharpPractice
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            /* Conditions Code
       Conditions obj = new Conditions();
            DateTime curr= DateTime.Now;
            string greetReply = obj.GreetToday(curr);
            Console.WriteLine(greetReply); 
          string result = Console.ReadLine();
            if (result == "0")
            {
                Console.WriteLine("Number is Nuetral");
                Console.ReadLine();
                return;
            }
            if (obj.checkNumberTO(Int32.Parse(result)))
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            */


            /*  string input = Console.ReadLine();
               loops obj = new loops();
               obj.CountNum(Int32.Parse(input));
               Console.ReadLine();*/
            /*
                        student student1 = new student();
                        student1.Id = 1;
                        student1.RollNumber = "IT22059";
                        student1.FName = "Gaurav";
                        student1.LName = "Saxena";
                        student1.Address = "Palam vihar";
                        student1.gender = "Male";
                        student1.Name = student1.FName + " " + student1.LName;

                        student student2 = new student()
                        { 
                            Id = 2, 
                            Address = "Dharam Colony", 
                            FName = "Neeraj", 
                            LName = "Kapoor", 
                            gender = "Male", 
                            RollNumber = "IT22089" 
                        };

                           //ARRAY OF OBJECTS

                        student[] stuarray = new student[15];
                      for(int i = 1; i <= 10;i++)
                        {
                            stuarray[i] = new student();
                            stuarray[i].Id= i;
                            stuarray[i].FName = "test"+i;
                            stuarray[i].LName = "test"+i;
                            stuarray[i].Address = "gurgaon"+i;

                            stuarray[i].gender = i%2==0 ? "Male" : "Female";           
                        }
                        //Console.WriteLine(stuarray[0]);
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(stuarray[i].gender);  
                        }

                        */


            //REFRENCE AND OUT

            //b obj = new b();
            /*            Program obj = new Program();
                        int a = 10, b = 20;
                        obj.changeOut(out a, out b);
                        Console.WriteLine(a+ " " + b);*/

            //POLYMORPHISM

            /*classA obj = new classB();
            obj.show();*/

            /*   classA obj = new classB();
               obj.show();*/
            //obj.d=1;
            //obj.show();

            //RECURSION

            /*   Program obj = new Program();
               int result = obj.recc(10);
               Console.WriteLine(result);*/

            /*mainClass obj = new mainClass();*/
            //ExceptionHandling obj = new ExceptionHandling();
            //obj.classA();
            //obj.classB();


            ConstReadOnly obj = new ConstReadOnly();
            Console.WriteLine(obj.str2);
            Console.WriteLine(ConstReadOnly.str);
            Console.ReadLine();
        
        } 
    }
}
