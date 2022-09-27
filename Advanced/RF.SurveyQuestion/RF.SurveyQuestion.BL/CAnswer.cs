using System;
using System.Collections.Generic;
using System.Linq;
using RF.SurveyQuestion.PL;

namespace RF.SurveyQuestion.BL
{
    public class CAnswer
    {

        public Guid Id { get; set; }
        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public CAnswer()
        {

        }

        public CAnswer(Guid id, string text, bool iscorrect)
        {
            Id = id;
            Text = text;
            IsCorrect = iscorrect;
        }


        public void LoadById()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var answer = oDc.tblAnswers.Where(p => p.Id == Id).FirstOrDefault();

                this.Id = answer.Id;
                this.Text = answer.Answertext;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var answer = oDc.tblAnswers.Where(p => p.Id == Id).FirstOrDefault();

                if (answer != null)
                {
                    answer.Answertext = this.Text;
                    oDc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Delete()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var answer = oDc.tblAnswers.Where(p => p.Id == Id).FirstOrDefault();

                if (answer != null)
                {
                    oDc.tblAnswers.DeleteOnSubmit(answer);
                    oDc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insert()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                tblAnswer answer = new tblAnswer();

                answer.Id = Guid.NewGuid();
                answer.Answertext = this.Text;

                oDc.tblAnswers.InsertOnSubmit(answer);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class CAnswerList : List<CAnswer>
    {
        public void Load()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var results = oDc.spGetAnswers().ToList();

                foreach (var answer in results)
                {

                    CAnswer oAnswer = new CAnswer(answer.Id, answer.AnswerText, false);
                    Add(oAnswer);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
