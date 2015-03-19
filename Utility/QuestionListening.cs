using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    [Serializable]
    public class QuestionListening
    {
        public List<string> choice;
        public int flagTrue { get; set; }
        public string question { get; set; }
        public string questionAudio { get; set; }

        public QuestionListening()
        {
            this.choice = new List<string>();
            this.flagTrue = 0;
            this.question = "";
            this.questionAudio = "";
        }

        public QuestionListening(List<string> choice, int flagTrue, string question)
        {
            this.choice = choice;
            this.flagTrue = flagTrue;
            this.question = question;
            this.questionAudio = "";
        }

        public QuestionListening(List<string> choice, int flagTrue, string question, string questionAudio)
        {
            this.choice = choice;
            this.flagTrue = flagTrue;
            this.question = question;
            this.questionAudio = questionAudio;
        }

        public QuestionListening(string line, string questionAudio)
        {
            string[] words = line.Split('|');
            question= words[0];
            flagTrue = int.Parse(words[words.Length-1]);
            List<string> _choice = new List<string>();
            for (int i = 1; i < words.Length - 2; i++)
            {
                _choice.Add(words[i]);
            }
            choice = _choice;
            this.questionAudio = questionAudio;
        }

        public QuestionListening(string line)
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
