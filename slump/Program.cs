using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
         {/*
            //övningn 1
            Console.WriteLine("Programmet slumpar fram 1o tal mellan 1-20 och beräknar medelvärdet");
            Random slumpare = new Random();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int tal = slumpare.Next(1, 21);
                Console.Write(tal+" ");
                sum = sum + tal;
                }
            Console.Write("medelvärdet blir " + sum / 10);
            
            */
          //övning 2
            
            Console.WriteLine("programmet slumpar fram ett tal mellan 15-30 och beräknar medianen");
            Random slump = new Random();
            int[] ost = new int[20];
            for(int i = 0; i < ost.Length; i++)                                
            {
                ost[i] = slump.Next(15, 31);
                
                   
            }
            Array.Sort(ost);
            for (int i = 0; i < ost.Length; i++)
            {
                Console.Write(ost[i] + " ");
                Console.Write((i == 9) ? " | " : " ");
            }
            Console.Write("medianen blir " + (ost[9] + ost[10])/2.0);
            
            Console.ReadKey();
        }
    }
}
