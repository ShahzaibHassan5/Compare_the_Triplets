using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Alec and bob array size :");
            int size = int.Parse(Console.ReadLine());
            int[] alice = new int[size];
            int[] bob = new int[size];
            int [] result=new int[2];
            Console.WriteLine("Enter Elements For Alice :");
            for(int i=0;i<alice.Length;i++)
            {
                alice[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Elements For Bob :");
            for(int i=0;i<bob.Length;i++)
            {
                bob[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<alice.Length;i++)
            {
                if (alice[i] < bob[i])
                {
                    result[1]++;
                }
                else if(alice[i]>bob[i])
                {
                    result[0]++;
                }
                else
                {
                    alice[0] = alice[0];
                    bob[1] = bob[1];
                }
            }
            for(int i=0;i<result.Length;i++)
            {
                Console.Write(result[i]+" ");
            }
            Console.Read();
        }
    }
}
