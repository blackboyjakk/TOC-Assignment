using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmet_2
{
    class Program
    {
        static uint randomNum(uint min,uint max) { 
                           
            Random random = new Random(Environment.TickCount);
            uint randonNumber = (uint)(min/2+(max-min)/2*random.NextDouble())*2+1;
            return randonNumber;
        }

       static uint getPrime(uint nonPrime,uint min,uint max) { 

           
            for (uint i = nonPrime; i < max; i += 2) {
                bool primeFound = true;
                uint maxPrimeSeek = (uint)Math.Sqrt(i) + 1;
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
                if (i == max) {
                        i = (uint)Math.Pow(2, 30) + 1;
                }
            }
           
            return 0;
        }

        static void Main(string[] args)
       {
           uint max = (uint)Math.Pow(2, 32)-1;
           uint min = (uint)Math.Pow(2, 30)+1;
             //random p  
          randomNum(min, max);
           uint randomP = randomNum(min,max);
           Console.WriteLine(randomP);
           uint primeP = getPrime(randomP,min,max);
            //random q
          randomNum(min, max);
           uint randomQ = randomNum(min,max);
           Console.WriteLine(randomQ);
           uint primeQ = getPrime(randomQ,min,max);
            //n = p x q
           ulong n = (ulong)primeP *(ulong)primeQ;
           Console.Write("n = "+primeP+" x "+primeQ);
           Console.WriteLine(" = "+n);
            //phi=(p-1)x(q-1)
           ulong phi = (ulong)(primeP-1) * (ulong)(primeQ-1);
           Console.Write("phi n = (" + primeP + "-1) x (" + primeQ+"-1)");
           Console.WriteLine(" = " + phi);
            //d=1/e mod 
           int e = 65537; 
           double e_1= Math.Pow(e, -1D);
           double d = (ulong)(((e_1 * phi) + e_1) %phi);
           Console.WriteLine(d);
           Console.WriteLine(((phi+1)*e_1)%phi);
        }
    }
}
