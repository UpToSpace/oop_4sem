using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    interface ICalculator
    {
        void ChangeSubstring(string text, string dop, string dop1);
        void DeleteSymbols(string text, string dop);
        void CharByIndex(string text, string dop);
        void Length(string text);
        void CountVowels(string text);
        void CountConsonants(string text);
        void CountSentences(string text);
        void CountWords(string text);
    }
}
