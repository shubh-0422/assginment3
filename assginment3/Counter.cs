using System;
using System.Collections.Generic;
using System.Text;

namespace assginment3
{
    class Counter
    {

        private static int Count;
        private static Counter Instance;

        public static Counter GetInstance() {
            Instance = new Counter();
            return Instance;
        }        
        public void Increment() {
            ++Count;
        }
        public void Decrement() {
            if (Count >= 0) {
                --Count;
            }
        }
        public void printCountValue() {
            Console.WriteLine("Counter current Value: "+Count);
        }

    }
}
