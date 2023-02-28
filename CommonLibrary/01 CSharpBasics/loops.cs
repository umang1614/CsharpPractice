using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._01_CSharpBasics
{
    public class loops
    {
        public void CountNum(int num) {
        for(int i = 1; i <= 10; i++) {
            Console.WriteLine(num*i);
            }
        }
    }
}
