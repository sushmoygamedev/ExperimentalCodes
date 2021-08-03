using System;

namespace ExperimentalCodes
{
    public class ExperimentRemoveCategoryFromSubreddit
    {
        public static void CategorySubtract()
        {
            string str = "https://www.reddit.com/r/relationships/";
            /*string[] strSplit = str.Split('/');
            Console.WriteLine(strSplit[strSplit.Length - 2]);*/
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '/' || str[i] == '.' || str[i] == ':')
                {
                    newStr += " ";
                }
                else
                {
                    newStr += str[i];
                }
            }
            string[] strSplit = newStr.Split(' ');
            Console.WriteLine(strSplit[strSplit.Length - 2]);
        }
    }
}
