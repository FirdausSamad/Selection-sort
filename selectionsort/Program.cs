using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is program to calculate selection sort
            int [] list = new int [] {40,90,4,1,3,6,89,33};

            int max = 0 , maxLocation= 0,temp,k = list.Length - 1,n=0;
            for(int i=0;i<list.Length;i++)
            {
               
                    for (int j = 0; j <= k-n; j++)
                    {
                        if (list[j] > max)
                        {
                            max = list[j];
                            maxLocation = j;
                        }

                    }
                    max = 0;

                    temp = list[k-n];
                    list[k-n] = list[maxLocation];
                    list[maxLocation] = temp;
                    n++;
            }

            foreach(int s in list)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
