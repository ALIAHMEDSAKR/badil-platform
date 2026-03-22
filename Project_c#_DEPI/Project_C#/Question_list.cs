using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class Question_list : List<Question>
    {
        private readonly string _filePath;

        public Question_list(string filePath)
        {
            _filePath = filePath;
        }
        public new void Add(Question question)
        {
            base.Add(question);
            LogQuestion(question);
        }
        private void LogQuestion(Question question)
        {
            using (TextWriter writer = new StreamWriter(_filePath, append: true))
            {
                writer.WriteLine("════════════════════════════════");
                writer.WriteLine($"Logged at : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                writer.WriteLine(question.Represent());
            }
        }
        public void PrintLogFile()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("No log file found.");
                return;
            }
            using (TextReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }
        public new Question pop()
        {
            return base[base.Count - 1];
            base.RemoveAt(base.Count - 1);
        }
    }

}
