using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class StudentIPass:IPass
    {
        public string CardType="學生卡";
        
        public override int pay(int distance)
        {
            return (int)(base.pay(distance)*0.75);
        }

    }
}
