using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class sorting_question
    {
        
        public static bool Sorting_Marks_Asc(Question question , Question question1) { return question.Marks > question1.Marks; }

        public static bool Sorting_Marks_desc(Question question, Question question1) { return question.Marks < question1.Marks; }


    }
}
