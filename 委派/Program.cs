using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 委派 =>  Callback function
            // Action => call back 非同步 / 傳入參數 並且無回傳值
            // Func 

            //Delegate(ActionTest);
            //Delegate(x =>
            //{
            //    Console.WriteLine("Action Test!!" + x);
            //});

            //HttpRequest.Get<Product>("https://dummyjson.com/products/1", GetResponse);
           // funcdelegate(checkPrimenumber);

          student student = new student();
            var res = student.wherea(x=>x%2==1);

            foreach(var data in res)
            {
                Console.WriteLine(data);
            }

            Console.ReadKey();
        }
        public static bool check(int n) {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        
        
        }

        public static void GetResponse(Product response)
        {
            Console.WriteLine(response.title);
        }

        public static void Delegate(Action<int> action)
        {
            for(int i=0;i<10;i++)
            {
                if(i%2==0)
                {
                    action.Invoke(i);
                }
               
            }
           
        } 

        public static void ActionTest(int number)
        {
            Console.WriteLine("Action Test!!" + number);
        }

        public static bool checkPrimenumber(int number) { 
            bool frag = false;
            for(int i=2;i<number; i++) {
            
                if (number%i==0) {
                    return false;
                    break;
                }

            }
            return true;
        
        }
        public static void funcdelegate(Func<int ,bool> func)
        {
          for(int i  = 1; i < 100; i++)
            {
                if (func.Invoke(i))
                {
                    Console.WriteLine(i);
                }
            }  
            

        }


    }
}
