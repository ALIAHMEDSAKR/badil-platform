using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal enum ExamMode { Starting, Queued, Finished }
    internal abstract class Exam : ICloneable, IComparable<Exam>
    {
        public TimeSpan Time { get; set; }
        public Subject Subject { get; set; }
        public ExamMode Mode { get; set; }
        public Question_list Questions { get; set; }
        public Dictionary<Question, Answer> AnswerKey { get; set; }

        protected Exam(Subject subject, TimeSpan time)
        {
            Subject = subject;
            Time = time;
            Mode = ExamMode.Starting;
            Questions = new Question_list("log.txt");
            AnswerKey = new Dictionary<Question, Answer>();
        }
        protected Exam(Subject subject) : this(subject, TimeSpan.FromMinutes(60)) { }
        public void AddQuestion(Question q, Answer correct)
        {
            Questions.Add(q);
            AnswerKey[q] = correct;
        }
        public abstract void ShowExam();
        public int CompareTo(Exam? other) =>
           Questions.Count.CompareTo(other?.Questions.Count ?? 0);
        public object Clone() => MemberwiseClone();
        public override string ToString() =>
            $"[{GetType().Name}] {Subject} | Time: {Time} | Mode: {Mode}";
        public override bool Equals(object? obj) =>
            obj is Exam e && Subject.Name == e.Subject.Name && Time == e.Time;
        public override int GetHashCode() =>
            HashCode.Combine(Subject.Name, Time);
    }
}
