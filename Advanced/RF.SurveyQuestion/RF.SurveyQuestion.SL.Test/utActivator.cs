using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF.SurveyQuestion.BL;

namespace RF.SurveyQuestion.SL.Test
{
    [TestClass]
    public class utActivator
    {
        [TestMethod]
        public void InsertActTest()
        {
            Guid g = new Guid("00000001-0000-1111-1111-000000000000");
            
            string a = "00011";
            CActivation b = new CActivation(g, DateTime.Parse("2017-02-02"), DateTime.Parse("2017-11-10"), a);
            
            b.Insert();
            
            
        }

        [TestMethod]
        public void UpdateActTest()
        {
            Guid g = new Guid("00000001-0000-1111-1111-000000000000");
            Guid i = new Guid("535a4cc6-85f7-4ae8-b0c0-36f573f0311f");
            // Check the data grid for the Id guid in activator UI
            string a = "00012";

            CActivation  b = new CActivation(g, DateTime.Parse("2018-02-02"), DateTime.Parse("2017-11-20"), a);
            b.Id = i;
            b.Update();
        }

        [TestMethod]
        public void DeleteActTest()
        {
            Guid g = new Guid("535a4cc6-85f7-4ae8-b0c0-36f573f0311f");
            new CActivation().Delete();
        }

        [TestMethod]
        public void GetActByIdTest()
        {
            Guid id = new Guid("8c96d9e4-ca27-47c6-a6f9-26886286960e");
            CActivation act = new CActivation(id);
            act.LoadById();

            Assert.AreEqual("55669", act.ActCode);
            
        }

        [TestMethod]
        public void GetActsTest()
        {
            CActivationList acts = new CActivationList();
            acts.Load();
            Assert.AreEqual(4, acts.Count);
        }

        [TestMethod]
        public void GetAnswersTest()
        {
            CAnswerList answers = new CAnswerList();
            answers.Load();
            Assert.AreEqual(10, answers.Count);
        }

        [TestMethod]
        public void GetQAByIdTest()
        {
            Guid id = new Guid("7ef752b6-b2ee-4229-8450-3126d9ea33d4");
            CQAList qas = new CQAList();
            qas.LoadById(id);

            Assert.IsNotNull(qas);
        }

        [TestMethod]
        public void GetQuestionsTest()
        {
            CQuestionList questions = new CQuestionList();
            questions.Load();
            Assert.AreEqual(5, questions.Count);
        }
    }
}
