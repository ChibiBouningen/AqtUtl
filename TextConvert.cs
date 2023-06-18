using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AqT_Utl
{
    internal class TextConvert
    {
        public TextConvert() { }

        public string ConvertToKatakana(string text)
        {
            string hiraganaPattern = @"\p{IsHiragana}+";
            string katakana = string.Empty;

            foreach (char c in text)
            {
                if (Regex.IsMatch(c.ToString(), hiraganaPattern))
                {
                    katakana += (char)(c + 0x60);
                }
                else
                {
                    katakana += c;
                }
            }

            return katakana;
        }
    }
}
