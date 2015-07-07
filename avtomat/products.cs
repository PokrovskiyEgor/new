using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomat
{
    class products
    {
        public int[] tovar(int a, int b) // а - цена, b - количество.
        {
            int[] res = new int[2];
            res[0] = a;
            res[1] = b;
            return res;
        } 
    }
}
