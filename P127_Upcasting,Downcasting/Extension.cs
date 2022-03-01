using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Upcasting_Downcasting
{
    static class Extension
    {
        public static string toCapitalized(this string word)
        {
            word = word.ToLower();
            string[] arrayWords = word.Split(" ");
            StringBuilder sb = new StringBuilder();
            foreach (string item in arrayWords)
            {
                if (item != arrayWords[0])
                {
                    sb.Append(" ");
                }
                sb.Append(char.ToUpper(item[0]));
                for (int i = 1; i < item.Length; i++)
                {
                    sb.Append(item[i]);
                }
            }
            return sb.ToString();
        }



        public static bool customContain(this string word, string search)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < word.Length - search.Length+1; i++)
            {
                for (int j = i; j < search.Length + i; j++)
                {
                    stringBuilder.Append(word[j]);
                }

                if (stringBuilder.ToString().ToLower() == search.ToLower())
                {
                    return true;
                }
                stringBuilder.Clear();
            }

            return false;
        }

    }
}
