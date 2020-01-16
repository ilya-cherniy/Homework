using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHomework
{
    class MathHelper
    {
        public static bool isSimple(int N)
        {
            if (N < 2)
                return false;
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }
}
