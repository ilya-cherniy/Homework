using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHomework
{
    class TestCollection : IEnumerable<int>
    {
        List<int> data;
        public TestCollection()
        {
            Random rnd = new Random();
            data = new List<int>(10);
            for (var i = 0; i<10; i++)
            {
                data.Add(rnd.Next(0,100));
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
