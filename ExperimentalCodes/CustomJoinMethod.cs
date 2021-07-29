//TRIGGER
/*CustomJoinMethod.ManualJoin();*/

using System;

namespace ExperimentalCodes
{
    public class CustomJoinMethod
    {
        public static void ManualJoin()
        {
            //CUSTOM JOIN METHOD
            string str = "hello";
            string sym = "-";
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1])
                {
                    newStr += str[i] + sym;
                }
                else
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine(newStr);

            /*int[] numList = new int[] { 1, 0, 1, 0 };
            int[] removeDuplicate = numList.Distinct().ToArray();
            string[] strList = new string[] { "The", "cat", "big", "cat" };
            string[] strList2 = strList.Distinct().ToArray();
            string[] removeDup = new string[strList2.Length];

            for (int i = 0; i < strList2.Length; i++)
            {
                if (strList2[i] == strList2[strList2.Length - 1])
                {
                    removeDup[i] = strList2[i];
                }
                else
                {
                    removeDup[i] = (strList2[i] + ", ");
                }
            }
            foreach (var item in removeDup)
            {
                Console.Write(item);
            }*/

            /*for (int i = 0; i < removeDuplicate.Length; i++)
            {
                if (removeDuplicate[i] == removeDuplicate[removeDuplicate.Length-1])
                {
                    Console.Write(removeDuplicate[i]);
                }
                else
                {
                    Console.Write(removeDuplicate[i] + ", ");
                }
            }*/
        }
    }
}
