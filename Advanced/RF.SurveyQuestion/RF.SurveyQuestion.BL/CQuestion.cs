using System;
using System.Collections.Generic;
using System.Linq;
using RF.SurveyQuestion.PL;

namespace RF.SurveyQuestion.BL
{
    public class CQuestion
    {

            public Guid Id { get; set; }
            public string Text { get; set; }
            
            public CAnswerList Answers { get; set; }


        public CQuestion()
        {

        }

        public CQuestion(Guid id, string text)
        {
            Id = id;
            Text = text;
        }

        public CQuestion(Guid id)
        {
            Id = id;
            
        }

        public void LoadById()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var question = oDc.tblQuestions.Where(p => p.Id == Id).FirstOrDefault();

                this.Id = question.Id;
                this.Text = question.QuestionText;
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

                var question = oDc.tblQuestions.Where(p => p.Id == Id).FirstOrDefault();

                if (question != null)
                {
                    question.QuestionText = this.Text;
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

                var question = oDc.tblQuestions.Where(p => p.Id == Id).FirstOrDefault();

                if (question != null)
                {
                    oDc.tblQuestions.DeleteOnSubmit(question);
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

                tblQuestion question = new tblQuestion();

                question.Id = Guid.NewGuid();
                question.QuestionText = this.Text;

                oDc.tblQuestions.InsertOnSubmit(question);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AssignQA(CAnswerList answers)
        {
            {
                try
                {

                    QuestionsDataContext oDc = new QuestionsDataContext();

                    var question = oDc.tblQAJunctions.Where(p => p.QuestionId == Id).FirstOrDefault();
                    if (question != null)
                    {
                        oDc.tblQAJunctions.DeleteOnSubmit(question);
                        oDc.SubmitChanges();
                    }

                    // Loop through the answers and insert into the tblQAJunction
                    foreach (CAnswer answer in answers)
                    {
                        tblQAJunction qa = new tblQAJunction();
                        qa.Id = Guid.NewGuid();
                        qa.QuestionId = this.Id;
                        qa.AnswerId = answer.Id;
                        qa.IsCorrect = answer.IsCorrect;

                        oDc.tblQAJunctions.InsertOnSubmit(qa);

                    }

                    oDc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }

    public class CQuestionList : List<CQuestion>
    {
        public void Load()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var results = oDc.spGetQuestions().ToList();

                foreach (var question in results)
                {
                    CQuestion oQuestion = new CQuestion(question.Id, question.QuestionText);
                    Add(oQuestion);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
