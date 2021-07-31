using System;

namespace ExperimentalCodes
{
    public static class ExperimentingRemoveDuplicates1
    {
        public static void GeeksOfGeeks()
        {
            int[] numList = new int[] { 1, 2, 2, 3, 3, 4, 4, 4, 5 };
            //int[] temp = new int[numList.Length];
            int j = 0;
            int[] newNumLIst = new int[numList.Length];

            for (int i = 0; i < numList.Length - 1; i++)
            {
                if (numList[i] != numList[i + 1])
                {
                    newNumLIst[j] = numList[i];
                    j++;
                }
            }
            newNumLIst[j] = numList[numList.Length - 1];

            for (j = 0; j < newNumLIst.Length; j++)
            {
                Console.WriteLine(newNumLIst[j]);
            }

            /*for (int i = 0; i < numList.Length-1; i++)
            {
                if (numList[i] != numList[i+1])
                {
                    temp[j] = numList[i];
                    j++;
                }
            }
            temp[j] = numList[numList.Length - 1];

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }*/

            /* for (int i = 0; i < numList.Length-1; i++)
             {
                 if (numList[i] != numList[i+1])
                 {
                     numList[j] = numList[i];
                     j++;
                 }
             }
             numList[j] = numList[numList.Length - 1];*/
        }
    }
}
