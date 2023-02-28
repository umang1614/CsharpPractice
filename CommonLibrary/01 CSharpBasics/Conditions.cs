using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._01_CSharpBasics
{
    public class Conditions
    {
       public string Greet(string timestamp)
        {
            string statement = "";
            int timeNum = Int32.Parse(timestamp);
          if(timeNum >= 6 && timeNum <= 11)
            {
                statement = "Good Morning";
            }
          else if(timeNum<= 12 && timeNum <= 3)
            {
                statement = "Good After Noon";
            }
          else
            {
                statement = "Good evening";
            }
            return statement;
        }

        public string GreetToday(DateTime currentTime) {

            string statement = "";
            if(currentTime.Hour >= 6 && currentTime.Hour <= 11) {
                statement = "Good Morning";
            }
            else if(currentTime.Hour >= 12 && currentTime.Hour <= 15) {
                statement = "Good AfterNoon";
            }
            else if(currentTime.Hour >= 16 && currentTime.Hour >= 19)
            {
                statement = "Good evening";
            }

            return statement;
        }
     
        public bool CheckNumber(int num1)
        {
             switch(num1%2==0)
            {
                case true:
                    return true;
                case false:
                    return false;
            }
            return false;
        }
        public bool checkNumberTO(int num1)
        {
        return num1%2==0? true : false;
        }
    }
}
