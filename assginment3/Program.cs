using System;

namespace assginment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counterOblect = Counter.GetInstance();
            counterOblect.printCountValue();

            counterOblect.Increment();
            counterOblect.Increment(); 
            counterOblect.printCountValue();

            counterOblect.Decrement(); 
            counterOblect.printCountValue();
        }
    }
}
