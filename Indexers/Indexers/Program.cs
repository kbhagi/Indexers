using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class Values
    {
        private int[] val = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        public int Length
        {
            get
            {
                return val.Length;
            }
        }
        public int this[int index]
        {
            get
            {
                return val[index];
            }
            set
            {
                val[index] = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Values newval = new Values();
            newval[3] = 58;
            newval[5] = 61;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Element # {0} = {1}", i, newval[i]);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
        
  