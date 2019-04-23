using System;
using System.Collections.Generic;

namespace PingPong
{
    public class PingPong
    {


        public string ConvertNumber(int number)
        {
            if (number % 15 == 0) return "Ping-Pong";
            if (number % 5 == 0) return "Pong";
            if (number % 3 == 0) return "Ping";

            return number.ToString();
        }
       

        public List<string> PingPongIt(int number)
        {            
            List<string> listOfItems = new List<string>();
            for (int i = 1; i <= number; i++)
            {
				listOfItems.Add(ConvertNumber(i));
            }
            return listOfItems;
        }

    }
}
