﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day_5_QuotientAndRemainder
{
    class UC_6_QuotientAndRemainder
    {
        static void Main(string[] args)
        {



            int Num = 1;
            int i = 1;
            int Div = 1;
            Console.WriteLine("Enter the Number");
            Num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the divider ");
            Div = int.Parse(Console.ReadLine());

            double Quotient = (Num / Div);
            Console.WriteLine("Your Quotient is = " + Quotient);

            double Remainder = (Num % Div);
            Console.WriteLine("Your Remainder is = " + Remainder);

        }



    }
}