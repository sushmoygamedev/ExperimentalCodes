using System;

namespace ExperimentalCodes
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            /*string[] bigram = new string[] { "oo", "mi", "ki", "la" };
            string[] words = new string[] { "milk", "chocolate", "cooks" };

            *//*string[] bigram = new string[] {"ay", "be", "ta", "cu"};
            string[] words = new string[] { "maybe", "beta", "abet", "course" };*/

            /*string[] bigram = new string[] { "at", "be", "th", "au" };
            string[] words = new string[] { "beautiful", "the", "hat" };*/

            /*string[] bigram = new string[] {"oo", "mi", "ki", "la"};
            string[] words = new string[] { "milk", "chocolate", "cooks" };*//*


            bool[] flags = new bool[bigram.Length];
            bool flag = false;

            for (int i = 0; i < bigram.Length; i++)
            {
                Console.WriteLine("----------\n" + bigram[i] + "\n----------");
                for (int j = 0; j < words.Length; j++)
                {
                    Console.Write(words[j] + ": ");

                    if (words[j].Contains(bigram[i]))
                    {
                        flags[j] = true;
                        Console.WriteLine(flags[j]);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
            }

            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i] == true)
                {
                    flag = true;
                    Console.WriteLine(flag);
                    
                }
                else
                {
                    flag = false;
                    Console.WriteLine(flag);
                    
                }
            }

            Console.WriteLine("----------\n" + flag + "\n----------");

            *//*for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                for (int j = 0; j < bigram.Length; j++)
                {
                    Console.Write(bigram[j] + ": ");
                    if (words[i].Contains(bigram[j]))
                    {
                        flags[j] = true;
                        Console.WriteLine(flags[j]);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
            }

            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i] == true)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag);*/


            /*string[] bi = new string[] { "bo", "ta", "el", "st", "ca" };
            string[] words = new string[] { "books", "table", "cap", "hostel" };
            bool[] flagTrue = new bool[bi.Length];
            bool flag = false;

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("---------------\n[" + words[i] + "]\n---------------");

                for (int j = 0; j < bi.Length; j++)
                {
                    Console.Write(bi[j] + ": ");

                    if (words[i].Contains(bi[j]))
                    {
                        flagTrue[j] = true;
                        Console.WriteLine(flagTrue[j]);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                    if (flagTrue[j] == true)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine("---------------\n[" + "Result: " + flag + "]\n---------------");*//*

            //bool flag = false;
            *//*for (int i = 0; i < flagTrue.Length; i++)
            {
                if (flagTrue[i] == true)
                {
                    flag = true;
                }
            }
            Console.WriteLine(flag);*/


            /*string[] bi = new string[] { "ay", "be", "ta", "cu" };
            string[] words = new string[] { "maybe", "beta", "abet", "course" };*/

            /*string[] bi = new string[] { "oo", "mi", "ki", "la" };
            string[] words = new string[] { "milk", "chocolate", "cooks" };

            bool[] flags = new bool[bi.Length];
            bool flag = false;

            *//*for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("--------------------\n[" + words[i] + "]\n--------------------");
                for (int j = 0; j < bi.Length; j++)
                {
                    Console.Write(bi[j] + ": ");
                    if (words[i].Contains(bi[j]))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                    Console.WriteLine(flag);
                }
            }*//*

            for (int i = 0; i < bi.Length; i++)
            {
                Console.WriteLine("--------------------\n[" + bi[i] + "]\n--------------------");
                for (int j = 0; j < words.Length; j++)
                {
                    Console.Write(words[j] + ": ");
                    if (words[j].Contains(bi[i]))
                    {
                        flags[j] = true;
                    }
                    else
                    {
                        flags[j] = false;
                    }
                    Console.WriteLine(flags[j]);

                    *//*if (flags[j] == true)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }*//*
                }
            }
            
            Console.WriteLine("--------------------\n" + flag);*/
        }
    }
}
