using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.SurveyQuestion.BL;

namespace RF.SurveyQuestion.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Quizzer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Quizzer.svc or Quizzer.svc.cs at the Solution Explorer and start debugging.
    public class Quizzer : IQuizzer
    {
       
       

        public CActivationList LoadActivations(string Code)
        {
            CActivationList QuestionList = new CActivationList();
            QuestionList.LoadAllFromActivationCode(Code);
            return QuestionList;
        }

        public void InsertResponse(Guid answerid, Guid questionid)
        {
            new CResponse(answerid, questionid).Insert();
        }

        public CQuestionList LoadQuestions()
        {
            CQuestionList qlist = new CQuestionList();
            qlist.Load();
            return qlist;
        }

        public CQuestion LoadQuestionById(Guid id)
        {
            CQuestion question = new CQuestion(id);
            question.LoadById();
            return question;
        }
        
        public CQAList LoadAnswersByQuestion(Guid id)
        {
            CQAList answersbyquestion = new CQAList();
            answersbyquestion.LoadById(id);
            return answersbyquestion;
        }


        
    }
}
