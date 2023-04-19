using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._01_CSharpBasics
{
    public class StudentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class calculate
    {
        public int func(int[] arr)
        {
            int n = 0;
            n = arr[0] + arr[1];
            return n;
        } 
        public int func2(int[] arr)
        {
            int n = 0;
            for(int i = 0; i<arr.Length; i++) { 
            n += arr[i];
            }
            return n;
        }
    }

    //DICTIONARY
    public class dict
    {
        public void getAll()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Umang");
            dic.Add(2, "Kushal");
            dic.Add(3, "Ritik");

            Console.WriteLine(dic.ContainsValue("umang"));
        }
    }
}
