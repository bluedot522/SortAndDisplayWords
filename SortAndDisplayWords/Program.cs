using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
class SortWords
{
    static void Main()
    {
        WriteLine("Enter total number of words");
        int length = Convert.ToInt32(ReadLine());
        WriteLine("Enter words");
        string[] wordArray = new string[length];
        int i = 0;
        while (i < length)
        {
            string newInput = ReadLine();
            wordArray[i] = newInput;
            i += 1;
        }


        SortAndDisplayWords(wordArray);

    }

    static void SortAndDisplayWords(string[] words)
    {
        Array.Sort(words);

        foreach (string word in words)
        {
            Write("{0} ", word);

        }

    }
}
