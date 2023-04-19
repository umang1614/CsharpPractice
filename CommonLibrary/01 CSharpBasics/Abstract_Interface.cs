using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._01_CSharpBasics
{
    //ABSTRACT CLASS AND ABSTRACT METHODS
    public abstract class AbstractClass
    {
        public abstract string NameST { get; set; }
        public AbstractClass()
        {
            Console.WriteLine("In abstarct class");
        }

    }

    public class childClass : AbstractClass
    {
        public override string NameST { get; set; }
        public int num { get; set; }
        public int getNum(int n)
        {
            n = this.num;
            return n;
        }
        public class newClass
        {
            public int num2 { get; }
            public newClass(int n)
            {
                num2 = n;
            }
            public void getnum2()
            {
                Console.WriteLine("The number is "+this.num2);
            }
        }
    }

    //INTERFACE
    public interface interfaceclass
    {
        void getnum3();
        int num2 { get; set; }
    }
    public class Ichild : interfaceclass
    {
        public int num2 { get; set; }
        public void getnum3()
        {
            Console.WriteLine("In interface child");
        }
    }



}
