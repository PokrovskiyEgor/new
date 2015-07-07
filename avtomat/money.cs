using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomat
{
    class money
    {
        public int[] monety(int a1, int a2, int a3, int a4)// 1,2,5,10
        {
            //0-кошелек 1-автомат
            
               int[] mon = new int[5];
                    mon[0] = a1;
                    mon[1] = a2;
                    mon[2] = a3;
                    mon[3] = a4;
                    mon[4] = a1 * 1 + a2 * 2 + a3 * 5 + a4 * 10;
                return mon;
        } 
    }
}
