using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CommonLibrary._01_CSharpBasics
{
    public class ExceptionHandling
    {
        public void classA()
        {
            Console.WriteLine("In class A");
        }
        public void classB(int i = 4)
        {
            try
            {
                if (i/0==0)
                    Console.WriteLine("In classB");

                byte[] nums = Encoding.ASCII.GetBytes("My name is khan");
                int[] en = new int[nums.Length];

                for (int j = 0; j < nums.Length; j++)
                {

                    en[j] = nums[j] * 2 + 5;

                }
                string textnumbers = string.Join("", en);
                Console.WriteLine(textnumbers);

                int num = Convert.ToInt32(textnumbers);

                string hexValue = num.ToString("x");
                Console.WriteLine(hexValue);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error occured in 1");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("An error occured in 2");
            }
            catch (OverflowException)
            {
                Console.WriteLine("An error occured in 3");
            }

        }

       

    }
}
