using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{

   

    public class StringcontainsanypermutationNanagram
    {

        public static bool IfAnagramPresentInString(string str, string pattern)
        {

            if (String.IsNullOrEmpty(str) || String.IsNullOrEmpty(pattern))
            {
                return false;
            }

            Dictionary<char, int> patterndict = new Dictionary<char, int>();

            foreach (char ch in pattern)
            {
                if (!patterndict.ContainsKey(ch))
                {
                    patterndict[ch] = 0;
                }
                patterndict[ch]++;  
            }

            int matchelement = 0;
            int start = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];

                if (patterndict.ContainsKey(currentChar))
                {
                    patterndict[currentChar]--;
                    if (patterndict[currentChar] == 0)
                    {
                        matchelement++;
                    }

                }

                if (matchelement == patterndict.Count)
                  return true;

                if (i >= pattern.Length-1)
                {
                    char firstchar = str[start++];
                   

                    if (patterndict.ContainsKey(firstchar))
                    {
                        if (patterndict[firstchar] == 0)
                        {
                            matchelement--;
                        }
                        patterndict[firstchar]++;
                    }
                }
            }
            return false;
        }

        public static bool withLinq(string str , string pattern)
        {
            if (String.IsNullOrEmpty(str) || String.IsNullOrEmpty(pattern))
                return false;

            var patternFreq = pattern.GroupBy(c=>c)
                                     .ToDictionary(c => c.Key, c=>c.Count());   

            for(int  i=0;i<=str.Length - pattern.Length-1;i++)
            {
                var window = str.Substring(i,pattern.Length);
                var windowFreq = window.GroupBy(c=>c)
                    .ToDictionary(c=>c.Key,c =>c.Count());

                if (windowFreq.SequenceEqual(patternFreq))
                {
                    return true;
                }
            }

            return false;

            
        }
        static void Main(string[] args)
        {
            string str = "bcdcbababd";
            string pattern = "abc";

            var res = IfAnagramPresentInString(str,pattern);
             Console.WriteLine(res);

            var res1 = IfAnagramPresentInString(str, pattern);
            Console.WriteLine("Linq :-"+res1);

            //TC: O(n+M) n element iterating  plus m for pattern
            //SC : O(m) for pattern ,map
        }
    }
}
