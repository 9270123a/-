using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派
{
    internal class student
    {
        public static List<int> wherea(Func<int,bool> func)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            List<int> list2 = new List<int> { };

            foreach (var item in list)
            {
                if (func.Invoke(item)) { 
                
                    list2.Add(item);
                };
            }
            return list2;
        }
        

    }
}
