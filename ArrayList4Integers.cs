using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHdag5_ListorOchSträngar
{
    internal class ArrayList4Integers
    {
        public void Labb6()
        {
            Console.WriteLine("Ange hur många mätnigar du vill göra");
            int antalOlikaTemp = int.Parse(Console.ReadLine());

            float[] temp = new float[antalOlikaTemp];

            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("Ange temperatur: ");
                temp[i] = float.Parse(Console.ReadLine());
            }

            float midTemp = 0;
            for (int i = 0; i < temp.Length; i++)
            {
               midTemp += temp[i];
            }
            midTemp /= temp.Length;

            Console.WriteLine($"Max temperaturen är: {temp.Max()}\nMedel Temperaturen är: {midTemp}");
        }

        public void Labb5()
        {
            var listWithNumbers = new List<int>();

            listWithNumbers.Add(23);
            listWithNumbers.Add(13);
            listWithNumbers.Add(223);
            listWithNumbers.Add(735);
            listWithNumbers.Add(533);

            for (int i = 0; i < listWithNumbers.Count; i++)
            {
                if (i == 4 || i == 2 || i == 0)
                {
                    Console.Write($"\nDetta index behåller sitt värde för att det ligger på ett jämt index: {listWithNumbers[i]}\n");
                }

                else if
                    (i == 1 || i == 3)
                {
                    listWithNumbers[i] = 0;
                    Console.WriteLine($"\nDetta index värde ändras till {listWithNumbers[i]}\n");
                }
            }
            Console.WriteLine($"\nDe nummer som ändrats är de som ligger på udda index");
        }

        public void Labb3()
        {
            var listWithStrings = new List<string>();

            listWithStrings.Add("Kalle");
            listWithStrings.Add("aa");
            listWithStrings.Add("ada");
            listWithStrings.Add("Nisse");

            foreach (string name in listWithStrings)
            {
                if (name.StartsWith("a") && name.EndsWith("a") && name.Length < 4)
                {
                    Console.WriteLine($"De namn som börjar och slutar med a och har minst 2 chars är: {name}");
                }
            }
        }
        public void TestLabbBarn()
        {
            var allaBarn = new List<string>();

            allaBarn.Add("Filippa");
            allaBarn.Add("Linnea");
            allaBarn.Add("Christoffer");

            allaBarn[2] = "Chrille";

            string namn11 = allaBarn[2];

            var playersInNYrangers = new List<string>();

            var allYears = new List<int>();

            allYears.Add(1999);
            allYears.Add(2000);

            foreach (int year in allYears)    // Use foreach when looping thru lists
            {
                Console.WriteLine($"{year}");
            }
        }

        public void Labb00()
        {
            var numList = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Mata in ett nr");
                numList.Add(int.Parse(Console.ReadLine()));
            }
            numList.Sort();
            Console.WriteLine(numList.Max());
        }

        public void Labb0()
        {
            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Ange ett tal");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var biggestSoFar = numbers[0];

            foreach (int num in numbers)
            {
                if (num > biggestSoFar)
                {
                    biggestSoFar = num;
                }
            }
            Console.WriteLine($"Detta är det största angivna talet {biggestSoFar}");
        }

        public void Labb2()
        {
            Console.WriteLine("Ange hur många tal du vill mata in");
            var antalTal = int.Parse(Console.ReadLine());

            int[] numberArray = new int[antalTal];
            var sum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine("Ange ett tal");
                numberArray[i] = int.Parse(Console.ReadLine());

                sum += numberArray[i];
            }
            Console.WriteLine($"Detta är totala summan av alla talen {sum}");
        }

        public void Labb4()
        {
            bool run = true;
            var listOfNumbers = new List<int>();

            while (run)
            {
                Console.WriteLine("mata in ett val (t) eller avsluta med (n)");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "t":

                        Console.WriteLine("Mata in ett tal");
                        listOfNumbers.Add(int.Parse(Console.ReadLine()));
                        break;

                    case "n":

                        run = false;
                        Console.WriteLine("Du avlsutade programmet");

                        foreach (int tal in listOfNumbers)
                        {
                            Console.WriteLine($"De tal som du matade in var: {tal}\n");
                        }
                        break;
                }
            }
        }
        public void ListWalkThrough()
        {
            var allLegendaryPlayers = new List<string>();
            bool run = true;

            while (run)
            {
                Console.WriteLine("1. Skapa spelare");
                Console.WriteLine("2. Lista spelare");
                Console.WriteLine("3. Ta bort spelare");
                Console.WriteLine("4. Ändra spelare");
                Console.WriteLine("5. Exit");
                Console.WriteLine("---------------------------");

                var menyVal = Console.ReadLine();

                switch (menyVal)
                {
                    case "1":
                        Console.WriteLine("Ange namn på nya spelare");
                        var name = Console.ReadLine();

                        allLegendaryPlayers.Add(name);
                        break;

                    case "2":
                        foreach (string names in allLegendaryPlayers)
                            Console.WriteLine(names);
                        break;

                    case "3":

                        Console.WriteLine("Ange siffra ");

                        var index = 0;
                        foreach (var names in allLegendaryPlayers)
                        {
                            index++;
                            Console.WriteLine($"{index} {names}");
                        }

                        break;

                    case "4":


                        break;

                    case "5":
                        run = false;

                        break;
                }
            }
        }
        public void Labb1()
        {
            int[] nums = new int[4];

            nums[0] = 21;
            nums[1] = 32;
            nums[2] = 22;
            nums[3] = 99;

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            string[] weekDays = { "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday" };

            while (true)
            {
                Console.WriteLine("Ange ett veckodags nummer mellan 1-7");
                int dagNummer = int.Parse(Console.ReadLine());

                string weekDayNames = weekDays[dagNummer - 1];

                Console.WriteLine($"Du angav {dagNummer} på den platsen ligger {weekDayNames}");
            }
        }

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
