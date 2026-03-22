using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal abstract class Question
    {
        #region Attiputes
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int? Marks { get; set; }
        public Answer_list AnswerList { get; set; }
        #endregion


        protected Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            AnswerList = new Answer_list();
        }

        public abstract string Represent();

        public override string ToString() => Represent();

        public bool CompareTo(Question other)
        {
            if (this.Marks > other.Marks)
                return true;
            else
                return false;
        }
    }

}
