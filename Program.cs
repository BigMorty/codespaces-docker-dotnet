using System;
using System.Threading;


namespace OrderProc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order Processing Starting");
            
            // Determine starting order number
            var envOrder = Environment.GetEnvironmentVariable("StartingOrderNum");
            int orderNum = (envOrder != null) ? Convert.ToInt32(envOrder) : 12001;
            Console.WriteLine("orderNum=" + orderNum.ToString());
            
            while (true)
            {
                Console.WriteLine("Processing order " + orderNum.ToString());
                // Awesome order processing happens here!
                orderNum++;
                Thread.Sleep(3000);
            }
        }
    }
}
