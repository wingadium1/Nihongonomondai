using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Utility
{
    public class Lesson
    {
        public string name { get; set; }
        public string fileWord { get; set; }
        public string fileInfoGrammar;
        public string fileQuestionGrammar;
        public string fileListen;
        public string fileQuestionListen;
        public List<Word> listWord = new List<Word>();
        public InfoGrammar[] infoGrammar;
        public List<QuestionGrammar> listQuestionGrammar = new List<QuestionGrammar>();
        public List<QuestionListening> listQuestionListening = new List<QuestionListening>();
        private string i;

        public Lesson(string _name)
        {
            this.name = _name;
            this.fileWord = System.IO.Directory.GetCurrentDirectory() + @"\library\word\" + _name + ".txt";
            this.fileInfoGrammar = System.IO.Directory.GetCurrentDirectory() + @"\library\infogr\" + _name + ".txt";
            this.fileQuestionGrammar = System.IO.Directory.GetCurrentDirectory() + @"\library\grammarQuestion\" + _name + ".txt";
            this.fileQuestionListen = System.IO.Directory.GetCurrentDirectory() + @"\library\listening\" + _name + ".txt";
            this.fileListen = System.IO.Directory.GetCurrentDirectory() + @"\library\listening\" + _name + ".mp3";
        }

        
    }
}
