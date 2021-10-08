using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening
{
    class Program
    {
        static void Main(string[] args)
        {
            long rekeningnummer = 1243568798;
            long eerste10;
            long laatste2;


            eerste10 = rekeningnummer / 100; //eerste 10 zijn gedeelt door 100 zonder reast
            laatste2 = rekeningnummer % 100; // laateste 2 cijfers zijn de rest bij een dijl 
            Console.WriteLine($"de rest van de 10cijfers gedeel door 97 is {eerste10%97}");
            Console.WriteLine($"de laatste é cijfers zin {laatste2}" );


        }
    }
}
