// See https://aka.ms/new-console-template for more information
/*using System;

namespace Basicprogram
{
    public class basic {
       static void Main ()
        {

           
            Random coin = new Random();
            //Console.WriteLine("enter the number of times coin flip");
           // Convert.ToInt16(Console.ReadLine());
            //int dice = coin.Next(0, 2);
            //Console.WriteLine(dice);
            for (int i = 1; i <= 5; i++)
            {
               
                    int dice = coin.Next(0, 2);
                Console.WriteLine(dice);


                if (dice == 0)
                {
                    Console.WriteLine("head");
                    int heads=1;
                    heads++;

                    int per = ((dice/5) * 100);
                    Console.WriteLine(per);
                }
                else
                {
                    Console.WriteLine("tail");
                }
                
            }
            Console.WriteLine("total number of tails:");
            //Console.WriteLine(per);
        }
        }
}
*/
using System;
namespace demo
{
    class swap
    {
        
       public  static void Main(string[] args)
        {
            int a, b, temp;
              
            Console.WriteLine("enter the first number");
            //Convert.ToInt32(Console.ReadLine());
            a=int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            //Convert.ToInt32(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            //int a = 1, b = 6, temp = 0;
             temp = a;
            a = b;
            b = temp;
            Console.WriteLine("number of the after swapping");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();


            
        }
    }
}

 