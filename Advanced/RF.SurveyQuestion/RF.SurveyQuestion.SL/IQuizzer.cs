using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.SurveyQuestion.BL;

namespace RF.SurveyQuestion.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuizzer" in both code and config file together.
    [ServiceContract]
    public interface IQuizzer
    {
      

        [OperationContract]
        CQuestionList LoadQuestions();

        [OperationContract]
        CQuestion LoadQuestionById(Guid id);//

        [OperationContract]
        CActivationList LoadActivations(string code);//

        [OperationContract]
        CQAList LoadAnswersByQuestion(Guid id); //

        [OperationContract]
        void InsertResponse(Guid answerid, Guid questionid); //
        
    }
}
