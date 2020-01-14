using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHomework
{
    class TestEnumerator : IEnumerator<int>
    {
        private List<int> data;
        private int pos = -1;

        public TestEnumerator(List<int> data)
        {
            this.data = data;
        }

        public int Current
        {
            get
            {
                if (pos == -1 || pos >=data.Count)
                {
                    throw new Exception();
                }
                else
                {
                    return data[pos];
                }
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose(){}

        public bool MoveNext()
        {
            if (pos < data.Count - 1)
            {
                pos++;
                return true;
            }
            else { return false; }
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
