using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    public class WordReverser : IWordReverser
    {
        public string ReverseWords(string s)
        {
            if (s == null) return null;
            List<int> spaceIndexes = GetSpaceIndexes(s);
            StringBuilder result = new StringBuilder();
            for (int i = spaceIndexes.Count - 1; i >= 0; i--)
            {
                int length = 0;
                if (i == spaceIndexes.Count - 1)
                {
                    length = s.Length;
                }
                else
                {
                    length = spaceIndexes[i + 1];
                }
                int index = spaceIndexes[i];
                for (int j = index; j < length; j++)
                {
                    char c = s[j];
                    if (c != ' ')
                        result.Append(c);
                    if (j == length - 1 && index != 0)
                        result.Append(' ');
                }
            }
            return result.ToString();
        }

        public List<int> GetSpaceIndexes(string s)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == ' ' || i == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
