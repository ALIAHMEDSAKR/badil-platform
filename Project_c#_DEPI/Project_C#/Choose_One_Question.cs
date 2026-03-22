using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class Choose_One_Question : Question
    {
        public int ans;
        public int answer_your_qui
        {
            get { return ans; }
            set { ans = value; }
        }
        public Choose_One_Question(string header, string body, int marks)
            : base(header, body, marks) { }
        public override string Represent()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"[Choose One] {Header}");
            sb.AppendLine($"Q: {Body}  (Marks: {Marks})");
            char letter = 'A';
            foreach (var answer in AnswerList)
                sb.AppendLine($"  {letter++}) {answer.Text}{(answer.IsCorrect ? " ✓" : "")}");
            return sb.ToString();
        }
    }
}
