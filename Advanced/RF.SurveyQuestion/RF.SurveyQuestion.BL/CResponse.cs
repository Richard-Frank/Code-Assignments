using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF.SurveyQuestion.PL;

namespace RF.SurveyQuestion.BL
{
    public class CResponse
    {
       
        
            public Guid Id { get; set; }
            public Guid QuestionId { get; set; }
            public Guid AnswerId { get; set; }

        public CResponse(Guid answerid, Guid questionid)
        {
            AnswerId = answerid;
            QuestionId = questionid;
        }

            public void Insert()
            {
                //create a connection to the database
                QuestionsDataContext oDc = new QuestionsDataContext();

                tblResponse otblResponse = new tblResponse();

                otblResponse.Id = Guid.NewGuid();
                otblResponse.QuestionId = this.QuestionId;
                otblResponse.AnswerId = this.AnswerId;

                //insert and commit the new row
                oDc.tblResponses.InsertOnSubmit(otblResponse);
                oDc.SubmitChanges();
                //close connections
                oDc = null;
            }
        
    }
}
