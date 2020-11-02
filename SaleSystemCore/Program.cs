using System;
using SaleSystemCore.Extension;
using SaleSystemCore.Logic;

namespace SaleSystemCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo come back to complete this code
            var result = Cash.LoginUser("admin","admin");   
            Console.WriteLine("Press any key to Exit!");
            Console.ReadKey();
        }
    }
}
