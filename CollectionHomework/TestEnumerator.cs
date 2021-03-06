﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionHomework
{
    class TestEnumerator : IEnumerator<int>
    {
        private int[] data;
        private int pos = -1;

        public TestEnumerator(int[] data)
        {
            this.data = data;
        }

        public int Current
        {
            get
            {
                if (pos == -1 || pos >=data.Length)
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
            if (pos < data.Length - 1)
            {
                pos++;
                if (!MathHelper.IsSimple(data[pos]))
                    {
                       return MoveNext();
                    }
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
