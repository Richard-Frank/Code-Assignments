using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.SurveyQuestion.PL;
using System.Linq;
using System.Collections.Generic;

namespace RF.SurveyQuestion.PL.Test
{
    [TestClass]
    public class utQuestionTest
    {
        [TestMethod]
        public void SelectTest()
        {
            QuestionsDataContext oDc = new QuestionsDataContext();

            List<tblQuestion> questions = (from q in oDc.tblQuestions select q).ToList();

            Assert.AreEqual(5, questions.Count);
        }
        [TestMethod]
        public void InsertTest()
        {

        }
        [TestMethod]
        public void UpdateTest()
        {

        }
        [TestMethod]
        public void DeleteTest()
        {

        }
    }
}
