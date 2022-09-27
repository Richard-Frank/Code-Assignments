using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.SurveyQuestion.BL;

namespace RF.SurveyQuestion.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Admin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Admin.svc or Admin.svc.cs at the Solution Explorer and start debugging.
    public class Admin : IAdmin
    {
        public CActivation GetActById(Guid Id)
        {
            CActivation act = new CActivation(Id);
            act.LoadById();
            return act;
        }
        public CActivationList GetActs()
        {
            CActivationList acts = new CActivationList();
            acts.Load();
            return acts;
        }

        public CAnswerList GetAnswers()
        {
            CAnswerList answers = new CAnswerList();
            answers.Load();
            return answers;
        }

        public CQAList GetQAById(Guid id)
        {
            CQAList qas = new CQAList();
            qas.LoadById(id);
            return qas;
        }

        public CQuestionList GetQuestions()
        {
            CQuestionList questions = new CQuestionList();
            questions.Load();
            return questions;
        }

        public void InsertAct(Guid quesid, DateTime startdate, DateTime enddate, string actcode)
        {
            new CActivation(quesid, startdate, enddate, actcode).Insert();
        }

        public void UpdateAct(Guid id, Guid quesid, DateTime startdate, DateTime enddate, string actcode)
        {
            new CActivation(id, quesid, startdate, enddate, actcode).Update();
        }

        public void DeleteAct(Guid id)
        {
            new CActivation(id).Delete();
        }
    }
}
