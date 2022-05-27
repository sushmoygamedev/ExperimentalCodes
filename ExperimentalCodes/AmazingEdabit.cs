namespace ExperimentalCodes
{
    public class AmazingEdabit
    {
        public string AmazingOrNot(string str)
        {
            string[] strSplit = str.Split(' ');
            string result = string.Empty;

            /*foreach (string strSplitItem in strSplit)
            {
                if (strSplitItem == "Edabit")
                {
                    result = (str);
                    break;
                }
                else
                {
                    result = (str.Replace("amazing", "not amazing"));
                }
            }
            Console.WriteLine(result);*/

            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[i] == "Edabit")
                {
                    result = (str);
                    break;
                }
                else
                {
                    if (strSplit[i] == "amazing")
                    {
                        strSplit[i] = "not amazing";
                    }
                    result += strSplit[i] + " ";
                    //result = (str.Replace("amazing", "not amazing"));
                }
            }
            return (result);
        }
    }
}
