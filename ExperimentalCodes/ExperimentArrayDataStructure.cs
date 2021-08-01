/*TRIGGER*/
/*int[] arr = new int[] { 1, 2, 5, 1, 7, 2, 4, 2 };
int arrCount = arr.Length;

ExperimentArrayDataStructure.SetDataStructure(arr, arrCount);

Console.WriteLine();
Console.WriteLine();

string[] wordList = new string[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" };
int wordCount = wordList.Length;

ExperimentArrayDataStructure.MapDataStructure(wordList, wordCount);
*/

using System;
using System.Collections.Generic;

namespace ExperimentalCodes
{
    public static class ExperimentArrayDataStructure
    {
        public static void SetDataStructure(int[] arr, int arrCount)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arrCount; i++)
            {
                set.Add(arr[i]);
            }
            foreach (var item in set)
            {
                Console.Write(item + ", ");
            }
        }

        public static void MapDataStructure(string[] wordList, int wordCount)
        {
            Dictionary<string, Boolean> stringMap = new Dictionary<string, Boolean>();
            for (int i = 0; i < wordCount; i++)
            {
                if (!stringMap.ContainsKey(wordList[i]))
                {
                    Console.WriteLine(wordList[i] + " ");
                    stringMap[wordList[i]] = true;
                }
            }
        }
    }
}
