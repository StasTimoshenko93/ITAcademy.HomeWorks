using System;
using System.Linq;

namespace HW08.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
           string checkstring = "i was born in 93?";
            Console.WriteLine($"This is string: {checkstring}");
            Task1(checkstring);
            Task2(checkstring);
            Task3(checkstring);
            Task4(checkstring);
        }
        static void Task1(string word)
        {
            int maxIndex = 0;
            string[] findArray = word.ToLower().Split(' ');
            for (int i = 0; i < findArray.Length; i++)
            {
                if (findArray[maxIndex].Length < findArray[i].Length)
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Delete the largest word from string :{word.Replace(findArray[maxIndex], string.Empty)}");
        }

        static void Task2(string word)
        {
            int maxindex = 0;
            int minIndex = 0;
            string[] findArray = word.ToLower().Split(' ');
            for (int i = 0; i < findArray.Length; i++)
            {
                if (findArray[minIndex].Length > findArray[i].Length)
                {
                   minIndex = i;
                }
                if (findArray[maxindex].Length < findArray[i].Length)
                {
                    maxindex = i;
                }   
            }
            string temp = findArray[minIndex];
            findArray[minIndex] = findArray[maxindex];
            findArray[maxindex] = temp;
            Console.WriteLine($"Replace the largest and the smallest word in the string: {string.Join(" ", findArray)}");
        }
        
        static void Task3(string word)
        {
            int countispunct = 0;
            for (int i = 0; i < word.Length; i++)

            {
                if (word[i].Equals(' ') || char.IsPunctuation(word[i]))
                {
                    countispunct++;
                }
            }
            int countletter = word.Length - countispunct;
            Console.WriteLine($"String Length: {word.Length}, Count punct.: {countispunct}, Count letter: {countletter}");
        }
        static void Task4(string word)
        {
            string[] findArray = word.ToLower().Split(' ');         
            var sortedArray = from w in findArray
                                             orderby w.Length descending
                                             select w;
            Console.WriteLine($"Sorted string :{string.Join(",",sortedArray)}");
        }
    }
}
