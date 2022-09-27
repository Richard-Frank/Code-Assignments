using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF.SurveyQuestion.PL;

namespace RF.SurveyQuestion.BL
{
    public class CActivation
    {
       public Guid Id { get; set; }
       public Guid QuesId { get; set; }
       public DateTime Startdate { get; set; }
       public DateTime Enddate { get; set; }
       public string ActCode { get; set; }

        public CActivation()
        {
        }

        public CActivation(Guid id, Guid quesid, DateTime startdate, DateTime enddate, string actcode)
        {
            Id = id;
            QuesId = quesid;
            Startdate = startdate;
            Enddate = enddate;
            ActCode = actcode;
        }
        public CActivation(Guid quesid, DateTime startdate, DateTime enddate, string actcode)
        {
            QuesId = quesid;
            Startdate = startdate;
            Enddate = enddate;
            ActCode = actcode;
        }

        public CActivation(Guid id)
        {
            Id = id;
        }

        public void LoadById()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var act = oDc.tblActivations.Where(p => p.Id == Id).FirstOrDefault();

                this.Id = act.Id;
                this.QuesId = act.QuestionId;
                this.Startdate = act.StartDate;
                this.Enddate = act.EndDate;
                this.ActCode = act.ActivationCode;
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

                tblActivation act = new tblActivation();

                act.Id = Guid.NewGuid();
                act.QuestionId = this.QuesId;
                act.StartDate = this.Startdate;
                act.EndDate = this.Enddate;
                act.ActivationCode = this.ActCode;

                oDc.tblActivations.InsertOnSubmit(act);
                oDc.SubmitChanges();
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

                var act = oDc.tblActivations.Where(p => p.Id == Id).FirstOrDefault();

                if (act != null)
                {
                    act.QuestionId = this.QuesId;
                    act.StartDate = this.Startdate;
                    act.EndDate = this.Enddate;
                    act.ActivationCode = this.ActCode;
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

                var act = oDc.tblActivations.Where(p => p.Id == Id).FirstOrDefault();

                if (act != null)
                {
                    oDc.tblActivations.DeleteOnSubmit(act);   
                    oDc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

    public class CActivationList : List<CActivation>
    {
        public void LoadAllFromActivationCode(string code)
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();
                //grab all activations by this code
                var activations = oDc.spGetActivationByCode(code).ToList();

                foreach (var activation in activations)
                {
                    //CActivation oActivation = new CActivation();
                    //oActivation.Id = activation.Id;
                    //oActivation.Startdate = activation.StartDate;
                    //oActivation.Enddate = activation.EndDate;
                    //oActivation.ActCode = activation.ActivationCode;
                    //oActivation.QuesId = activation.QuestionId;
                    CActivation oActivation = new CActivation(activation.Id, 
                                                              activation.QuestionId, 
                                                              activation.StartDate, 
                                                              activation.EndDate, 
                                                              activation.ActivationCode);

                    //check to see if the start date is here
                    if (oActivation.Startdate < DateTime.Now)
                    {
                        //check to see if the end date is not over
                        if (oActivation.Enddate > DateTime.Now)
                        {
                            this.Add(oActivation);
                        }
                        else
                        {
                            Exception ex = new Exception("Activation code is not valid at this time.");
                        }
                    }

                    else
                    {
                        Exception ex = new Exception("Activation code is not valid at this time.");
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("Error loading by Id");
            }
        }

        public void Load()
        {
            try
            {
                QuestionsDataContext oDc = new QuestionsDataContext();

                var results = (from a in oDc.tblActivations select a).ToList();

                foreach (var act in results)
                {
                    CActivation oAct = new CActivation(act.Id, act.QuestionId, act.StartDate, act.EndDate, act.ActivationCode);
                    Add(oAct);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
