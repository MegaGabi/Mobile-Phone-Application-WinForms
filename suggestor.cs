using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile
{
    class suggestor
    {
        string[] dictionary =
        {
            "привет",
            "пока",
            "здравствуйте",
            "досвидания",
            "как",
            "почему",
            "зачем",
            "когда",
            "нет",
            "да",
            "наверное",
            "т9"
        };

        public string[] search(string word)
        {
            string[] ans = new string[3];

            var buf = Array.FindAll(dictionary, (s) => s.StartsWith(word));

            for (int i = 0, j = 0; i < buf.Count() && j < ans.Count(); i++, j++)
                ans[j] = buf[i];

            if (buf.Count() < ans.Count())
            {
                for(int i = ans.Count() - (ans.Count() - buf.Count()); i < ans.Count(); i++)
                {
                    ans[i] = "";
                }
            }

            return ans;
        }

        public void Add(string str)
        {
            Array.Resize(ref dictionary, dictionary.Count() + 1);
            dictionary[dictionary.Count() - 1] = str.ToLower();
        }
    }
}
