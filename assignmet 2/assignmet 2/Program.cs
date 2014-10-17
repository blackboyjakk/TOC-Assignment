using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmet_2
{
    class Program
    {
        static uint randomNum() { 
            int max = (int)Math.Pow(2, 29);
            Random random = new Random();
            uint number = (uint)random.Next(0, max);
            uint bignum = (uint)random.Next(0, 2);

            Console.WriteLine((uint)Math.Pow(2, 30) +1);
            Console.WriteLine((uint)Math.Pow(2,32)-1);
          
            uint resuilt = bignum*(uint)Math.Pow(2, 31) + (uint)Math.Pow(2, 30) + (uint)random.Next(max) * 2 + 1;
            return resuilt;
        }

       static uint getPrime(uint min) { 
              // Console.WriteLine(rand());
//            long min = (long)Math.Pow(2, 30)+1;
            uint max = (uint)Math.Pow(2, 32)-1;
 //           Console.WriteLine(min);
   //         Console.WriteLine(max);
  //          int count = 0;
            for (uint i = min; i <= max; i += 2) {
                bool primeFound = true;
                int maxPrimeSeek = (int)Math.Sqrt(i) + 1;
                for (uint j = 3; j <= maxPrimeSeek; j += 2)
                {
                    if ((i % j)==0)
                    {
                        primeFound = false;
                        break;
                    }
                }

                if (primeFound)
                    return i;
                   // Console.WriteLine(i);
                    //count++;
            } 
            return getPrime((uint)Math.Pow(2,30)+1);//Console.WriteLine("among = "+count);
        }

        static void Main(string[] args)
        {
                uint randnum = randomNum();
                Console.WriteLine(randnum);
                Console.WriteLine(getPrime(randnum));
            
        }
    }
}
