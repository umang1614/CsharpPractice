using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._01_CSharpBasics
{
   public class student
    {
        public student() { 
        
        }
        public int Id { get; set; }
        public string RollNumber { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string gender { get; set; }
        
    }


      /*REFRENCE AND OUT*/
    public class refandout
    {
        public void change(ref int a, ref int b)
        {
            a = a+b;
            b = a-b;
            a = a-b;
        }
        public void changeOut(out int a, out int b)
        {
            a = 10;
            b = 20;
            a = a+b;
            b = a-b;
            a = a-b;
        }
    }
    /*POLYMORPHISM*/

    public class classA
    {
       public int id { get; set; }
        public classA()
        {
            Console.WriteLine("In class a const");
        }
        public virtual void show()
        {
            Console.WriteLine("Class A");
        }
    }

    public class classB:classA
    {
       public int d{ get; set; }
        public classB()
        {
            Console.WriteLine("In class b const");
        }
        public void reply()
        {
            Console.WriteLine("Helloo");
        }
        public override void show() { 
            Console.WriteLine("Class B");
        }
    }

          /*RECCURSION*/
    public class recc
    {
        public int fact(int num1)
        {
            if (num1 <= 1)
            {
                return num1;
            }

            return num1*fact(num1-1);
        }

        public int ficco(int num1)
        {
            if(num1<= 2)
            {
                return 1;
            }
           return ficco(num1-1) + ficco(num1-2);
        }
    }

    /*USE OF PRIVATE CLASS*/

 /*   1) Members of private class can not be use outside the mainClass so i can only use the members of private class inside the method of mainClass.
    2) After making private constructor of private class i cant even make an object of this private class also cant able to inherit this class.

    3) For this i make an extra public constructor with parameter so when i make an object i use this constructor and able to use the members of private class.*/

    public class mainClass
    {
        private class classOne
        {
            private classOne()
            {
                Console.WriteLine("I'm God!");
            }
            public classOne(string s)
            {

            }
            public void getClass()
            {
                classOne obj = new classOne();
            }
            public int a { get; set; }
            public int b { get; set; }
        }
        private class classTwo
        {
            public int c { get; set; }
            public int d { get; set; }
        }
       /* classTwo obj1 = new classTwo();*/
       public mainClass()
        {
            classTwo obj1 = new classTwo();
            obj1.c = 4;
            obj1.d = 5;
            classOne obj2 = new classOne("hy");
            obj2.getClass();    
        }
     

    }
    
    //OPERATOR OVERLOADING
    public class overloadFunc
    {
        public virtual int compare(int x, int y)
        { 
            if (x > y)
                return 1;
            return 0;
        }
    }
   public class child1 : overloadFunc
    {
        public override int compare(int x, int y)
        {
            if (x < y)
                return 1;
            return 0;
        }
    }

    public class AddOverload
    {
       public string func(string str, int n)
        {
            string result = "";
            for(int i = 0; i<n; i++)
                result += str;
            return result;
        }
    }


    //CONST AND READONLY
    public class ConstReadOnly
    {
        public const string str = "Umang bhatia";
        public readonly string str2 = "i'm fine";

        public ConstReadOnly()
        {
            Console.WriteLine(str2);
            str2 = "i'm not fine";
        }
        public void func()
        {
            //str = "bhatia umang";
            //str2 = "i'm fine";
        }
    }
}
