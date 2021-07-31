using System;

namespace ExperimentalCodes
{
    public static class ExperimentingPalindrom
    {
        public static void PalindromTest()
        {
            string str = "kayak";
            char[] strChar = str.ToCharArray();
            Array.Reverse(strChar);
            string strRev = new string(strChar);
            Console.WriteLine(strRev);

            if (str == strRev)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            /*for (int i = str.Length; i > 0 ; i--)
            {
                strRev += (str[i-1]);
            }
            if (str == strRev)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/
        }
    }
}
