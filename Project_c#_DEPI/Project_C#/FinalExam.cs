using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class FinalExam : Exam
    {
        public FinalExam(Subject subject, TimeSpan time) : base(subject, time) { }
        public FinalExam(Subject subject) : base(subject) { }
        public override void ShowExam()
        {
            Mode = ExamMode.Queued;
            Console.WriteLine($"=== FINAL EXAM | {Subject} | Time: {Time} ===\n");

            foreach (var q in Questions)
                Console.WriteLine(q.Represent().Replace(" ✓", ""));
            Mode = ExamMode.Finished;
        }
    }
}
