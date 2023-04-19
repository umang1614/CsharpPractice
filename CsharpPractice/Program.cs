using System;
using CommonLibrary._01_CSharpBasics;
//using AdoNetConsoleApplication;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Threading;
using static CommonLibrary._01_CSharpBasics.ParallelProg;
//using System.Collections.Generic;


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


            /*  ConstReadOnly obj = new ConstReadOnly();
              Console.WriteLine(obj.str2);
              Console.WriteLine(ConstReadOnly.str);
              Console.ReadLine()*/
            childClass obj = new childClass();
            //obj.NameST = "Test";
            //Console.WriteLine(obj.NameST);

            //int n = Int32.Parse(Console.ReadLine());


            /*childClass.newClass obj2 = new childClass.newClass(n);
            obj2.getnum2();*/


            //COLLECTIONS(GENERIC)

            /*  List<int> listObj = new List<int>();
              for(int i = 0; i < n; i++)
              {
                  int input = Int32.Parse(Console.ReadLine());
                  listObj.Add(input);
              }
              foreach(int input in listObj)
              {
                  Console.WriteLine(input);
              }*/

            /*  List<StudentData> data_One = new List<StudentData>(){
              new StudentData() {Id = 1, Name = "Umang"},
              new StudentData() {Id = 2, Name = "Yash"},
              new StudentData() {Id = 3, Name = "Kushal"},
              new StudentData() {Id = 4, Name = "Ankit"},
              new StudentData() {Id = 5, Name = "Ritik"}
              };
              foreach (StudentData data in data_One)
              {
                  Console.WriteLine(data.Id);
                  Console.WriteLine(data.Name);
              }*/

            calculate obj2 = new calculate();
            //int[] arr = new int[8] { 1, 6, 0, 7, 2, 0, 0, 1 };
            /*  int[] arr = new int[8] {1,4,0,2,2,0,0,1};
              int n  = obj2.func(arr);
              int n2 = obj2.func2(arr);
              Console.WriteLine(n);
              int n3 = 0;
              if (n2>9)
              {
                  while(n2 > 0)
                  {
                       n3 += n2%10;
                      n2 /= 10;
                  }
              Console.WriteLine(n3);
              }
              else
              {
                  Console.WriteLine(n2);
              }*/
            //Program2.AdoCLass();
            //CommonLibrary._01_CSharpBasics.AdoCLass();
            /*dict obj5 = new dict();
            obj5.getAll();*/
            /*var arr = new int[]{ 1, 2,3};

            try
            {
                Console.WriteLine(arr[10]);
            }
            finally { Console.WriteLine("Error"); }*/

            /* Console.WriteLine("Main method started!");
             AsyncAwait.SomeFunc();
             Console.WriteLine("Main Method End!");*/

            //ParallelProg.ParallelLoop();
            int[][,] arr = new int [5][,];
            Console.ReadLine();

        }
    }
}
