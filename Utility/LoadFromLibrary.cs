using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Utility
{
    public class LoadFromLibrary
    {
        public static List<Word> getWordFromLesson(Lesson lesson)
        {
            try
            {
                List<Word> rt = new List<Word>();
                string[] lines = System.IO.File.ReadAllLines(lesson.fileWord);
                foreach (var i in lines)
                {
                    rt.Add(new Word(i));
                }
                return rt;
            }
            catch (IOException ex)
            {
                return null;
            }

        }

        public static List<QuestionListening> getQuestionListeningFromLesson(Lesson lesson)
        {

            try
            {
                List<QuestionListening> rt = new List<QuestionListening>();
                string[] lines = System.IO.File.ReadAllLines(lesson.fileQuestionListen);
                foreach (var i in lines)
                {
                    rt.Add(new QuestionListening(i));
                }
                return rt;
            }
            catch (IOException ex)
            {
                return null;
            }
            return null;
        }

        public static List<QuestionGrammar> RandomTest()
        {
            Random rand = new Random();
            List<QuestionGrammar> ar = new List<QuestionGrammar>();
            List<Lesson> listLesson = getLessonList();
            List<QuestionGrammar> alllistgrammar = new List<QuestionGrammar>();
            foreach (var ls in listLesson)
            {
                alllistgrammar.AddRange(getQuestionGrammarFromLesson(ls));
            }
            //generate 20 
            int noOfquest = alllistgrammar.Count;
            int noOfquestNeed = 20;
            int noOfquestNoNeed = noOfquest - noOfquestNeed;
            List<int> questCode = new List<int>();
            int needtoGenerate = (noOfquestNeed < noOfquestNoNeed) ? noOfquestNeed : noOfquestNoNeed;
            int count = 0;
            while (count < needtoGenerate)
            {
                int t = rand.Next(noOfquest);
                if (!questCode.Contains(t))
                {
                    questCode.Add(t);
                    count++;
                }
            }
            string s="";
            if (noOfquestNeed < noOfquestNoNeed)
            {
                foreach (int i in questCode)
                {
                    ar.Add(alllistgrammar[i]);
                }

            }
            else
            {
                for (int i = 0; i < noOfquest; i++)
                {
                    if (!questCode.Contains(i))
                    {
                        ar.Add(alllistgrammar[i]);
                    }
                }
            }

            //
            List<Word> alllistword = new List<Word>();
            foreach (var ls in listLesson)
            {
                alllistword.AddRange(getWordFromLesson(ls));
            }
            alllistword = alllistword.OrderBy(o => o.hiragana).ToList();


            noOfquest = alllistword.Count;
            noOfquestNeed = 20;
            noOfquestNoNeed = noOfquest - noOfquestNeed;
            questCode.Clear();
            needtoGenerate = (noOfquestNeed < noOfquestNoNeed) ? noOfquestNeed : noOfquestNoNeed;
            count = 0;
            while (count < needtoGenerate)
            {
                int t = rand.Next(noOfquest);
                if (!questCode.Contains(t))
                {
                    questCode.Add(t);
                    count++;
                }
            }
            if (noOfquestNeed < noOfquestNoNeed)
            {
                foreach (int i in questCode)
                {
                    ar.Add(genQuest(alllistword, i));
                }

            }
            else
            {
                for (int i = 0; i < noOfquest; i++)
                {
                    if (!questCode.Contains(i))
                    {
                        ar.Add(genQuest(alllistword, i));
                    }
                }
            }

            return ar;
        }


        static QuestionGrammar genQuest(List<Word> list,int i)
        {
            
            string question = list[i].meaning + "?";
            List<Word> choose;
            int truec;
            if (i < 2)
            {
                choose = list.GetRange(0,4);
                truec = i;
            }
            else if (i == list.Count - 1) { choose = list.GetRange(i - 3, 4); truec = 4; }
            else { choose = list.GetRange(i - 2, 4); truec = 3; }
            List<string> choosestring = new List<string>();
            foreach (var x in choose)
            {
                choosestring.Add(x.hiragana);
            }
            QuestionGrammar a = new QuestionGrammar(choosestring,truec,question);
            return a;
        }

        public static List<QuestionGrammar> getQuestionGrammarFromLesson(Lesson lesson)
        {
            
            try
            {
                List<QuestionGrammar> rt = new List<QuestionGrammar>();
                string[] lines = System.IO.File.ReadAllLines(lesson.fileQuestionGrammar);
                foreach (var i in lines)
                {
                    rt.Add(new QuestionGrammar(i));
                }
                return rt;
            }
            catch (IOException ex)
            {
                return null;
            }
            return null;
        }

        public static List<Lesson> getLessonList()
        {
            try
            {
                string filepath = System.IO.Directory.GetCurrentDirectory() + @"\library\ListLesson.txt";
                List<Lesson> rt = new List<Lesson>();
                string[] lines = System.IO.File.ReadAllLines(filepath);
                foreach (var i in lines)
                {
                    rt.Add(new Lesson(i));
                }
                return rt;
            }
            catch (IOException ex)
            {
                return null;
            }
            return null;

        }

        public static void saveWordToLesson(Lesson lesson, List<Word> lw)
        {
            string[] lines = new string[lw.Count];
            foreach (var word in lw)
            {
                lines[lw.IndexOf(word)] = word.hiragana + "|" + word.romaji + "|" + word.meaning;
            }

            System.IO.File.WriteAllLines(lesson.fileWord, lines);
        }

    }
    
}
