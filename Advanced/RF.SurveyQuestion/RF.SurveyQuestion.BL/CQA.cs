using RF.SurveyQuestion.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF.SurveyQuestion.BL
{
    public class CQA
    {
        public Guid Id { get; set; }
        public Guid QuId { get; set; }
        public Guid AnwId { get; set; }
        public bool IsCorrect { get; set; }

        public string QuestionText { get; set; }
        public string AnswerText { get; set; }

        public CQA()
        {

        }

        public CQA(Guid id, Guid quid, Guid anwid, bool iscorrect)
        {
            Id = id;
            QuId = quid;
            AnwId = anwid;
            IsCorrect = iscorrect;
        }

        public CQA(Guid id, Guid quid, Guid anwid, bool iscorrect, string questiontext, string answertext)
        {
            Id = id;
            QuId = quid;
            AnwId = anwid;
            IsCorrect = iscorrect;
            QuestionText = questiontext;
            AnswerText = answertext;
        }
    }

    public class CQAList : List<CQA>
    {
        public void LoadById(Guid questionid)
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var results = oDc.spGetQA(questionid).ToList();

                foreach (var qa in results)
                {
                    CQA oQA = new CQA(qa.Id, qa.QuestionId, qa.AnswerId, qa.IsCorrect);
                    var q = oDc.tblQuestions.Where(p => p.Id == oQA.QuId).FirstOrDefault();
                    var a = oDc.tblAnswers.Where(p => p.Id == oQA.AnwId).FirstOrDefault();
                    oQA.QuestionText = q.QuestionText;
                    oQA.AnswerText = a.Answertext;

                    Add(oQA);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
