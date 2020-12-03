using System;
using System.Collections.Generic;
using System.Text;

namespace AgencyModel
{
    //追求者类
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }
        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }
    }
}
