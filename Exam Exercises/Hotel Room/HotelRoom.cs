using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            // За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
            //  За студио, при повече от 14 нощувки през май и октомври : 30% намаление.
            //  За студио, при повече от 14 нощувки през юни и септември: 20% намаление.
            //  За апартамент, при повече от 14 нощувки, без значение от месеца : 10% намаление.
            
            string month = Console.ReadLine();
            var numberOfNights = int.Parse(Console.ReadLine());

            var studioFee = 0.0;
            var flatFee = 0.0;
            var studioDiscount = 0.0;
            var flatDiscount = 0.0;

            if (month == "May" || month == "October")
            {
                studioFee = 50;
                flatFee = 65;
                if (numberOfNights > 7 && numberOfNights <=14)
                {
                    studioDiscount = studioFee * 0.05;
                    studioFee = studioFee - studioDiscount;
                }
                else if (numberOfNights > 14)
                {
                    studioDiscount = studioFee * 0.3;
                    studioFee = studioFee - studioDiscount;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioFee = 75.20;
                flatFee = 68.70;
                
                if (numberOfNights > 14)
                {
                    studioDiscount = studioFee * 0.2;
                    studioFee = studioFee - studioDiscount;
                }                
            }
            else if (month == "July" || month == "August")
            {
                studioFee = 76;
                flatFee = 77;
            }
            
            if (numberOfNights > 14)
            {
                flatDiscount = flatFee * 0.1;
                flatFee = flatFee - flatDiscount;
            }

            var studioMoney = studioFee * numberOfNights;
            var flatMoney = flatFee * numberOfNights;

            Console.WriteLine("Apartment: {0:F2} lv.", flatMoney);
            Console.WriteLine("Studio: {0:f2} lv.", studioMoney);
        }
    }
}
