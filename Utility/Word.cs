using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Utility
{

    public class Word
    {
        public string hiragana { get; set; }
        public string romaji { get; set; }
        public string meaning { get; set; }

        public Word()
        {
            this.hiragana = "";
            this.romaji = "";
            this.meaning = "";

        }

        public Word(string hiragana, string romaji, string meaning)
        {
            this.hiragana = hiragana;
            this.romaji = romaji;
            this.meaning = meaning;
        }

        public List<string> ToStrings()
        {
            List<string> t = new List<string>();
            t.Add(hiragana);
            t.Add(romaji);
            t.Add(meaning);
            return t;
        }
        public Word(string lines)
        {
            string[] words = lines.Split('|');
            hiragana = words[0];
            romaji = words[1];
            meaning = words[2];
        }


        
    }
}
