﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHomework
{
    class TestCollection : IEnumerable<int>
    {
        int[] data = new int[10];
        public TestCollection()
        {
            Random rnd = new Random();
            for (var i = 0; i<data.Length; i++)
            {
                data[i] = rnd.Next(0,10);
                if (isSimple(data[i]))
                {
                    data[i] = data[i];
                }
                else
                {
                    data[i] = 0; 
                }
             }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new TestEnumerator(data);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        private static bool isSimple(int N)
        {
            //чтобы убедиться в том простое число или нет, достаточно проверить не делится ли число на числа до его половины
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if ((N % i == 0)||(N==1))
                    return false;
            }
            return true;
        }
    }
}
