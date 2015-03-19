using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utility;
using GUI;
namespace Nihongonomondai
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI());

            //List<Lesson> a = new List<Lesson>();
            //a = LoadFromLibrary.getLessonList();
            //List<Word> w = new List<Word>();
            //w = LoadFromLibrary.getWordFromLesson(a[4]);
            //List<QuestionListening> ql = LoadFromLibrary.getQuestionListeningFromLesson(a[0]);
            //List<QuestionGrammar> qg = LoadFromLibrary.getQuestionGrammarFromLesson(a[0]);
            //foreach (var i in qg)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
