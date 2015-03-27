using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPass card = new IPass();
            StudentIPass s_card = new StudentIPass();
            
            int distance; // 距離

            //hallo
            
            Console.WriteLine(card.CardType);
            for (distance = 1; distance < 31; distance ++ )
            {
                Console.WriteLine(distance + "km->" + card.pay(distance));
            }

            Console.WriteLine(s_card.CardType);
            for (distance = 1; distance < 31; distance = distance + 1 )
            {
                Console.WriteLine(distance + "km->" + s_card.pay(distance));
            }

            Console.ReadKey();
        }
    }
}
