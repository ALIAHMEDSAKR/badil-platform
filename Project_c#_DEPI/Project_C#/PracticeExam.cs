using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(Subject subject, TimeSpan time) : base(subject, time) { }
        public PracticeExam(Subject subject) : base(subject) { }

        public override void ShowExam()
        {
            Mode = ExamMode.Queued;
            Console.WriteLine($"=== PRACTICE EXAM | {Subject} | Time: {Time} ===\n");

            foreach (var q in Questions)
            {
                Console.WriteLine(q);
                if (AnswerKey.TryGetValue(q, out var correct))
                    Console.WriteLine($"  ✅ Correct Answer: {correct.Text}\n");
            }

            Mode = ExamMode.Finished;
        }
    }
}
