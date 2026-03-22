using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class True_OR_False_qusetion : Question
    {
        public bool ans;
        public bool answer_your_qui
        {
            get { return ans; }
            set { ans = value; }
        }
        public True_OR_False_qusetion(string header, string body, int marks)
            : base(header, body, marks)
        {
            AnswerList.Add(new Answer("True", isCorrect: false));
            AnswerList.Add(new Answer("False", isCorrect: false));
        }
        public void SetCorrectAnswer(bool isTrue)
        {
            AnswerList[0].IsCorrect = isTrue;
            AnswerList[1].IsCorrect = !isTrue;
        }
        public override string Represent()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"[True or False] {Header}");
            sb.AppendLine($"Q: {Body}  (Marks: {Marks})");
            foreach (Answer item in AnswerList)
                sb.AppendLine(item.ToString());
            return sb.ToString();
        }
    }


}
