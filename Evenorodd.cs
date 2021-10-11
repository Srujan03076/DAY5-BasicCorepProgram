using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_EvenorOdd
{ 
    class UC_9_EvenorOdd
{
    static void Main(string[] args)
    {

        int Num = 0;
        int output = 0;

        Console.WriteLine("Enter the Number ");
        Num = int.Parse(Console.ReadLine());
        {
            output = Num % 2;
        }
        if (output == 0)
        {
            Console.WriteLine(Num + "the number is even");
        }
        else
        {
            Console.WriteLine(Num + "the number is odd ");
        }

    }
}

}



       