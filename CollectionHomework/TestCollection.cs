using System;
using System.Collections;
using System.Collections.Generic;

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
                data[i] = rnd.Next(0,100);
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
    }
}
