using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class IPass
    {
        private string type = "捷運卡";
        public string CardId { get; set;}
        public string CardType{
            get { return type; }
            set { type = value;}
        }

        public virtual int pay(int distance)
        {
            int price = 20;

            if (distance > 0 && distance <= 5)
            {
                price = 20;
            }

            else if (distance > 5 && distance <= 17)
            {
                price = price + ((distance-5)/2)*5;                
            }

            else if (distance > 17 && distance <= 30)
            {
                price = 50;
                price = price + ((distance - 17) / 3) * 5;

                if (price > 60)
                {
                    price = 60;
                }
            }

            return price;
        }
    }
     
}
