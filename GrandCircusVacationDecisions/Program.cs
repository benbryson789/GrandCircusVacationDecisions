using System;
using System.Text.RegularExpressions;

namespace GrandCircusVacationDecisions
{
    class Program
    {
        static int groupSize;
        static string vacationType;

        static string Adventurous = "adventurous";
        static string Musical = "musical";
        static string Tropical = "tropical";

        static void Main(string[] args)
        {            
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");

            vacationType = Console.ReadLine().ToLower();
                                    
            Console.WriteLine("How many people are in your group?");
           
            groupSize = Convert.ToInt32(Console.ReadLine());

            if (vacationType == Musical && groupSize <= 2)
            {
                MusicalAndGroupLessThanEqualTo2();
            }
            else if (vacationType == Musical && groupSize <= 5)
            {
                MusicalAndLessThanFive();
            }
            else if (vacationType == Musical && groupSize >= 6)

            {
                MusicalAndGroupGreaterThanOrEqualTo6();
            }


            if (vacationType == Tropical && groupSize <= 2)
            {
                TropicalGroupSizeUpto2();
            }

            else if (vacationType ==Tropical && groupSize <= 5)
            {
                TropicalAndGroupSizeUpTo5();

            }
            else if (vacationType == Tropical && groupSize >= 6)
            {
                TropicalGroupSizeGreaterOrEqualTo6();
            }

            if (vacationType == Adventurous && groupSize <= 2)
            {
                AdveturousAndGroupsizeUpTo2();
            }

            else if (vacationType == Adventurous && groupSize <= 5)
            {
                AdventurousAndGroupSizeUpTo5();

            }
            else if (vacationType == Adventurous && groupSize >= 6)
            {
                AdventurousAndGroupSizeGreaterThanEqualTo6();
            }
        }

        private static void AdventurousAndGroupSizeGreaterThanEqualTo6()
        {
            string result33 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
            "you should take a charter flight to Whitewater Rafting the Grand Canyon ";

            Console.WriteLine(result33);
        }

        private static void AdventurousAndGroupSizeUpTo5()
        {
            string result32 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                           "you should take a helicopter to Whitewater Rafting the Grand Canyon ";


            Console.WriteLine(result32);
        }

        private static void AdveturousAndGroupsizeUpTo2()
        {
            string result31 = "Since you’re  a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                            "you should take a First Class trip to Whitewater Rafting the Grand Canyon";

            Console.WriteLine(result31);
        }

        private static void TropicalGroupSizeGreaterOrEqualTo6()
        {
            string result23 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
            "you should take a charter flight to Grand Canyon";


            Console.WriteLine(result23);
        }

        private static void TropicalAndGroupSizeUpTo5()
        {
            string result22 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                           "you should take a helicopter to Beach Vacation";


            Console.WriteLine(result22);
        }

        private static void TropicalGroupSizeUpto2()
        {
            string result21 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                            "you should take a First Class trip to a Beach Vacation";

            Console.WriteLine(result21);
        }

        private static void MusicalAndGroupGreaterThanOrEqualTo6()
        {
            string result13 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                            "you should take a charter flight to New Orleans";

            Console.WriteLine(result13);
        }

        private static void MusicalAndGroupLessThanEqualTo2()
        {
            string result11 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                            "you should take a First Class trip to New Orleans";

            Console.WriteLine(result11);
        }

        static void MusicalAndLessThanFive()
        {
            string result12 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                                "you should take a helicopter to New Orleans";

            Console.Write(result12);
        }
    }
}
