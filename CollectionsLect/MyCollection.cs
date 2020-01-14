using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsLect
{
    class MyCollection : IEnumerable

    {
        
        public MyCollection()
        {

        }

        public IEnumerator GetEnumerator()
        {
            return new Myenumerator();
        }
    }
}
