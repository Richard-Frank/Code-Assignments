﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RF.SurveyQuestion.QuizzerUI.QuizzerReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CQuestion", Namespace="http://schemas.datacontract.org/2004/07/RF.SurveyQuestion.BL")]
    [System.SerializableAttribute()]
    public partial class CQuestion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CAnswer> AnswersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CAnswer> Answers {
            get {
                return this.AnswersField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswersField, value) != true)) {
                    this.AnswersField = value;
                    this.RaisePropertyChanged("Answers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CAnswer", Namespace="http://schemas.datacontract.org/2004/07/RF.SurveyQuestion.BL")]
    [System.SerializableAttribute()]
    public partial class CAnswer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsCorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCorrect {
            get {
                return this.IsCorrectField;
            }
            set {
                if ((this.IsCorrectField.Equals(value) != true)) {
                    this.IsCorrectField = value;
                    this.RaisePropertyChanged("IsCorrect");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CActivation", Namespace="http://schemas.datacontract.org/2004/07/RF.SurveyQuestion.BL")]
    [System.SerializableAttribute()]
    public partial class CActivation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EnddateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid QuesIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartdateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ActCode {
            get {
                return this.ActCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ActCodeField, value) != true)) {
                    this.ActCodeField = value;
                    this.RaisePropertyChanged("ActCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Enddate {
            get {
                return this.EnddateField;
            }
            set {
                if ((this.EnddateField.Equals(value) != true)) {
                    this.EnddateField = value;
                    this.RaisePropertyChanged("Enddate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid QuesId {
            get {
                return this.QuesIdField;
            }
            set {
                if ((this.QuesIdField.Equals(value) != true)) {
                    this.QuesIdField = value;
                    this.RaisePropertyChanged("QuesId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Startdate {
            get {
                return this.StartdateField;
            }
            set {
                if ((this.StartdateField.Equals(value) != true)) {
                    this.StartdateField = value;
                    this.RaisePropertyChanged("Startdate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CQA", Namespace="http://schemas.datacontract.org/2004/07/RF.SurveyQuestion.BL")]
    [System.SerializableAttribute()]
    public partial class CQA : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnswerTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid AnwIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsCorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid QuIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionTextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AnswerText {
            get {
                return this.AnswerTextField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerTextField, value) != true)) {
                    this.AnswerTextField = value;
                    this.RaisePropertyChanged("AnswerText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid AnwId {
            get {
                return this.AnwIdField;
            }
            set {
                if ((this.AnwIdField.Equals(value) != true)) {
                    this.AnwIdField = value;
                    this.RaisePropertyChanged("AnwId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCorrect {
            get {
                return this.IsCorrectField;
            }
            set {
                if ((this.IsCorrectField.Equals(value) != true)) {
                    this.IsCorrectField = value;
                    this.RaisePropertyChanged("IsCorrect");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid QuId {
            get {
                return this.QuIdField;
            }
            set {
                if ((this.QuIdField.Equals(value) != true)) {
                    this.QuIdField = value;
                    this.RaisePropertyChanged("QuId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QuestionText {
            get {
                return this.QuestionTextField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionTextField, value) != true)) {
                    this.QuestionTextField = value;
                    this.RaisePropertyChanged("QuestionText");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuizzerReference.IQuizzer")]
    public interface IQuizzer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadQuestions", ReplyAction="http://tempuri.org/IQuizzer/LoadQuestionsResponse")]
        System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion> LoadQuestions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadQuestions", ReplyAction="http://tempuri.org/IQuizzer/LoadQuestionsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion>> LoadQuestionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/InsertActivator", ReplyAction="http://tempuri.org/IQuizzer/InsertActivatorResponse")]
        void InsertActivator(System.Guid quesid, System.DateTime startdate, System.DateTime enddate, string actcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/InsertActivator", ReplyAction="http://tempuri.org/IQuizzer/InsertActivatorResponse")]
        System.Threading.Tasks.Task InsertActivatorAsync(System.Guid quesid, System.DateTime startdate, System.DateTime enddate, string actcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/DeleteActivator", ReplyAction="http://tempuri.org/IQuizzer/DeleteActivatorResponse")]
        void DeleteActivator(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/DeleteActivator", ReplyAction="http://tempuri.org/IQuizzer/DeleteActivatorResponse")]
        System.Threading.Tasks.Task DeleteActivatorAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/UpdateActivator", ReplyAction="http://tempuri.org/IQuizzer/UpdateActivatorResponse")]
        void UpdateActivator(System.Guid id, System.DateTime start, System.DateTime end, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/UpdateActivator", ReplyAction="http://tempuri.org/IQuizzer/UpdateActivatorResponse")]
        System.Threading.Tasks.Task UpdateActivatorAsync(System.Guid id, System.DateTime start, System.DateTime end, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadQuestionById", ReplyAction="http://tempuri.org/IQuizzer/LoadQuestionByIdResponse")]
        RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion LoadQuestionById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadQuestionById", ReplyAction="http://tempuri.org/IQuizzer/LoadQuestionByIdResponse")]
        System.Threading.Tasks.Task<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion> LoadQuestionByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadActivations", ReplyAction="http://tempuri.org/IQuizzer/LoadActivationsResponse")]
        System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CActivation> LoadActivations(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadActivations", ReplyAction="http://tempuri.org/IQuizzer/LoadActivationsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CActivation>> LoadActivationsAsync(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadAnswersByQuestion", ReplyAction="http://tempuri.org/IQuizzer/LoadAnswersByQuestionResponse")]
        System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQA> LoadAnswersByQuestion(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/LoadAnswersByQuestion", ReplyAction="http://tempuri.org/IQuizzer/LoadAnswersByQuestionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQA>> LoadAnswersByQuestionAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/InsertResponse", ReplyAction="http://tempuri.org/IQuizzer/InsertResponseResponse")]
        void InsertResponse(System.Guid answerid, System.Guid questionid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizzer/InsertResponse", ReplyAction="http://tempuri.org/IQuizzer/InsertResponseResponse")]
        System.Threading.Tasks.Task InsertResponseAsync(System.Guid answerid, System.Guid questionid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuizzerChannel : RF.SurveyQuestion.QuizzerUI.QuizzerReference.IQuizzer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuizzerClient : System.ServiceModel.ClientBase<RF.SurveyQuestion.QuizzerUI.QuizzerReference.IQuizzer>, RF.SurveyQuestion.QuizzerUI.QuizzerReference.IQuizzer {
        
        public QuizzerClient() {
        }
        
        public QuizzerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuizzerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuizzerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuizzerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion> LoadQuestions() {
            return base.Channel.LoadQuestions();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion>> LoadQuestionsAsync() {
            return base.Channel.LoadQuestionsAsync();
        }
        
        public void InsertActivator(System.Guid quesid, System.DateTime startdate, System.DateTime enddate, string actcode) {
            base.Channel.InsertActivator(quesid, startdate, enddate, actcode);
        }
        
        public System.Threading.Tasks.Task InsertActivatorAsync(System.Guid quesid, System.DateTime startdate, System.DateTime enddate, string actcode) {
            return base.Channel.InsertActivatorAsync(quesid, startdate, enddate, actcode);
        }
        
        public void DeleteActivator(System.Guid id) {
            base.Channel.DeleteActivator(id);
        }
        
        public System.Threading.Tasks.Task DeleteActivatorAsync(System.Guid id) {
            return base.Channel.DeleteActivatorAsync(id);
        }
        
        public void UpdateActivator(System.Guid id, System.DateTime start, System.DateTime end, string code) {
            base.Channel.UpdateActivator(id, start, end, code);
        }
        
        public System.Threading.Tasks.Task UpdateActivatorAsync(System.Guid id, System.DateTime start, System.DateTime end, string code) {
            return base.Channel.UpdateActivatorAsync(id, start, end, code);
        }
        
        public RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion LoadQuestionById(System.Guid id) {
            return base.Channel.LoadQuestionById(id);
        }
        
        public System.Threading.Tasks.Task<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQuestion> LoadQuestionByIdAsync(System.Guid id) {
            return base.Channel.LoadQuestionByIdAsync(id);
        }
        
        public System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CActivation> LoadActivations(string code) {
            return base.Channel.LoadActivations(code);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CActivation>> LoadActivationsAsync(string code) {
            return base.Channel.LoadActivationsAsync(code);
        }
        
        public System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQA> LoadAnswersByQuestion(System.Guid id) {
            return base.Channel.LoadAnswersByQuestion(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<RF.SurveyQuestion.QuizzerUI.QuizzerReference.CQA>> LoadAnswersByQuestionAsync(System.Guid id) {
            return base.Channel.LoadAnswersByQuestionAsync(id);
        }
        
        public void InsertResponse(System.Guid answerid, System.Guid questionid) {
            base.Channel.InsertResponse(answerid, questionid);
        }
        
        public System.Threading.Tasks.Task InsertResponseAsync(System.Guid answerid, System.Guid questionid) {
            return base.Channel.InsertResponseAsync(answerid, questionid);
        }
    }
}
