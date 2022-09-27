using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.SurveyQuestion.BL;

namespace RF.SurveyQuestion.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdmin" in both code and config file together.
    [ServiceContract]
    public interface IAdmin
    {
        [OperationContract]
        CQuestionList GetQuestions();
        [OperationContract]
        CAnswerList GetAnswers();
        [OperationContract]
        CQAList GetQAById(Guid id);
        [OperationContract]
        CActivationList GetActs();

        [OperationContract]
        void InsertAct(Guid quesid, DateTime startdate, DateTime enddate, string actcode);
        [OperationContract]
        void UpdateAct(Guid id, Guid quesid, DateTime startdate, DateTime enddate, string actcode);
        [OperationContract]
        void DeleteAct(Guid id);
        [OperationContract]
        CActivation GetActById(Guid Id);
    }
}
