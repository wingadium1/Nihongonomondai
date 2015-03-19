using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    [Serializable]
    public class QuestionGrammar
    {
        public List<string> choice { get; set; }
        public int flagTrue { get; set; }
        public String question { get; set; }

        public QuestionGrammar()
        {
            choice = new List<string>();
            question = null;
            flagTrue = 0;
        }

        public QuestionGrammar(List<string> choice, int flagTrue, String question)
        {
            this.choice = choice;
            this.flagTrue = flagTrue;
            this.question = question;
        }

        public override string ToString()
        {
            var enter = System.Environment.NewLine;
            string s = "";
            s = s + question + enter;
            char dem ='a';
            int count = 0;
            foreach (var b in choice)
            {
                count++;
                s = s + ( (count==flagTrue)? "[x]" : "   ") + dem + ")" + b.ToString() + enter;
                dem = (char)((int)dem + 1);
            }
            s = s + enter;
            return s;
        }

        public QuestionGrammar(string line)
        {
            string[] words = line.Split('|');
            question = words[0];
            flagTrue = int.Parse(words[words.Length - 1]);
            List<string> _choice = new List<string>();
            for (int i = 1; i < words.Length - 1; i++)
            {
                _choice.Add(words[i]);
            }
            choice = _choice;
            
        }
    }
}
