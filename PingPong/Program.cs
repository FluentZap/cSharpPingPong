using System;
using System.Collections.Generic;
namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            PingAndPongUI();
        }




        static void PingAndPongUI()
        {
            PingPong p = new PingPong();
            //p.PingPongIt(10);
            List<string> mylist = p.PingPongIt(1);
            Console.WriteLine(mylist);
        }
    }
}
