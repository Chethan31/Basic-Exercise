using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Passing
{
    internal class ParameterTest
    {
        int x;
        public void Value(int x)
        {
            this.x = x;
            
        }
        public int get()
        {
            return x;
        }
        public void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        public void MinMax(int[] a, out int min, out int max) 
        {
            min = int.MaxValue;
            max = int.MinValue;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            
        }
    }
}
