using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.SurveyQuestion.BL;
namespace RF.SurveyQuestion.SL.Test
{
    [TestClass]
    public class utQuizzer
    {
        public Guid aId = new Guid();
        public Guid qId = new Guid();

        [TestMethod]
        public void InsertResponseTest()
        {
            new CResponse(aId, qId).Insert();

        }

        [TestMethod]
        public void LoadActivationsTest()
        {
            CActivationList QuestionList = new CActivationList();
            QuestionList.LoadAllFromActivationCode("12349");

            Assert.AreEqual(1, QuestionList.Count);
        }

        [TestMethod]
        public void LoadQuestionsTest()
        {
            CQuestionList qlist = new CQuestionList();
            qlist.Load();

            Assert.AreEqual(5, qlist.Count);
        }

        [TestMethod]
        public void LoadQuestionsByIdTest()
        {
            Guid id = new Guid("8ee71225-b253-4f3d-9132-6db74a98df83");
            CQuestion question = new CQuestion(id);
            question.LoadById();
            Assert.AreEqual(id, question.Id);



        }

        [TestMethod]
        public void LoadAnswersByQuestionTest()
        {
            Guid id = new Guid("8ee71225-b253-4f3d-9132-6db74a98df83");
            CQAList answersbyquestion = new CQAList();
            answersbyquestion.LoadById(id);
            Assert.AreEqual(4, answersbyquestion.Count);
        }

    }
}
