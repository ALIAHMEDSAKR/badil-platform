namespace Project_C_
{
    

    enum ans_of_one_choose
    {
        frist =1,
        second =2,
        thrid = 4,
        four = 8,
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            var exam = new Question_list("Exam_Questions.txt");


            var tfQ = new True_OR_False_qusetion("Q1", "The Earth revolves around the Sun.", 2);
            tfQ.SetCorrectAnswer(isTrue: true);
            tfQ.answer_your_qui =  true ;
            exam.Add(tfQ);

            var chooseOne = new Choose_One_Question("Q2", "Which planet is closest to the Sun?", 4);
            chooseOne.AnswerList.Add(new Answer("Earth", isCorrect: false));
            chooseOne.AnswerList.Add(new Answer("Mercury", isCorrect: true));
            chooseOne.AnswerList.Add(new Answer("Venus", isCorrect: false));
            chooseOne.AnswerList.Add(new Answer("Mars", isCorrect: false));
            chooseOne.answer_your_qui = (int)ans_of_one_choose.frist;
            exam.Add(chooseOne);


            var chooseAll = new Choose_all_Qusetion("Q3", "Select all prime numbers.", 6);
            chooseAll.AnswerList.Add(new Answer("2", isCorrect: true));
            chooseAll.AnswerList.Add(new Answer("4", isCorrect: false));
            chooseAll.AnswerList.Add(new Answer("7", isCorrect: true));
            chooseAll.AnswerList.Add(new Answer("9", isCorrect: false));
            chooseAll.AnswerList.Add(new Answer("11", isCorrect: true));
            exam.Add(chooseAll);

            Console.WriteLine("===== Reading from log file =====\n");
            exam.PrintLogFile();
        }
    }
}
