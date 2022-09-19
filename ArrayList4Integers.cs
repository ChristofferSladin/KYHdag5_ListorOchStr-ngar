using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHdag5_ListorOchSträngar
{
    internal class ArrayList4Integers
    {

        public void RunList4Integers()
        {
            List<int> numList = new List<int>();
            Console.WriteLine("Ange 4 tal");

            //numList.Add(int.Parse(Console.ReadLine()));
            //numList.Add(int.Parse(Console.ReadLine()));
            //numList.Add(int.Parse(Console.ReadLine()));
            //numList.Add(int.Parse(Console.ReadLine()));


            for (int i = 0; i < 4; i++)
            {
                numList.Add(int.Parse(Console.ReadLine()));

            }
            Console.WriteLine(numList);
        }

        public void RunArray4Integers()
        {
            int[] arrayOfIntegers = new int[4];
            int maxValue = 0;
            

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ange ett tal");
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            } 

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                maxValue = arrayOfIntegers.Max();
            }

            Console.WriteLine(maxValue);

        }
    }
}
