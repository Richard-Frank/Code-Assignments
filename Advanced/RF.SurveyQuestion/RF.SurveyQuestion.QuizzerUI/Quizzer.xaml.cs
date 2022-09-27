using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RF.SurveyQuestion.QuizzerUI.QuizzerReference;

namespace RF.SurveyQuestion.QuizzerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        CActivation activator;
        List<CActivation> activators;
        CQuestion question;
        List<CQuestion> questions;
        List<CQA> answers;
        CQA answer;
        CQA response;
        
       

        
        // when clicked, check the length of the string and verify
        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            if(txtCode.Text.Length != 5)
            {
                MessageBox.Show("The activation code must be 5 digits.", "Invalid Code Length");
                txtCode.SelectAll();
                txtCode.Focus();
            }
            else // length is correct, so proceed to push code to DB
            {
                try
                {

                    //MessageBox.Show("Success");
                    // initialize the entities and lists
                    activator = new CActivation();
                    activators = new List<CActivation>();
                    questions = new List<CQuestion>();
                    question = new CQuestion();
                    answers = new List<CQA>();

                    // make a new quizzer client
                    QuizzerClient client = new QuizzerClient();

                    // get a list of activators
                    activators = client.LoadActivations(txtCode.Text);
                    
                    // assign the first retrieved activator in the list
                    activator = activators.FirstOrDefault();

                    // assign the new question Id by activator Id
                    question.Id = activator.QuesId;
                    
                    // get the question by id
                    question = client.LoadQuestionById(question.Id);

                    // output the question
                    txbDisplayText.Text = question.Text;

                    // get a list of answers by questionId
                    answers = client.LoadAnswersByQuestion(question.Id);

                    // bind the data to the combobox
                    cboAnswer.ItemsSource = null;
                    cboAnswer.ItemsSource = answers;

                    cboAnswer.SelectedValuePath = "AnwId";
                    cboAnswer.DisplayMemberPath = "AnswerText";
                    
                }
                catch
                {
                    MessageBox.Show("This activation code is not valid.", "Error!");
                }

            }
        }

        private void cboAnswer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                answer = answers[cboAnswer.SelectedIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (answer != null)
            {
                    if (activator.Enddate > DateTime.Now)
                    {
                        try
                        {
                            response = new CQA();
                            QuizzerClient client = new QuizzerClient();

                            response.AnwId = answer.AnwId;
                            response.IsCorrect = answer.IsCorrect;
                            response.QuId = question.Id;
                            client.InsertResponse(response.AnwId, response.QuId);

                            client.Close();
                            client = null;
                            
                            btnSubmit.IsEnabled = false;

                        //Sets the gradient depending on a correct or incorrect answer.
                        if (response.IsCorrect == true)
                        {
                            LinearGradientBrush gradient = new LinearGradientBrush();
                            gradient.StartPoint = new Point(0.5, 0);
                            gradient.EndPoint = new Point(0.5, 1);

                            gradient.GradientStops.Add(new GradientStop(Colors.DarkOliveGreen, 0));
                            gradient.GradientStops.Add(new GradientStop(Colors.ForestGreen, 1));


                            grdBackColor.Background = gradient;
                            MessageBox.Show("Correct!");
                        }
                        if (response.IsCorrect == false)
                        {
                            LinearGradientBrush gradient = new LinearGradientBrush();
                            gradient.StartPoint = new Point(0.5, 0);
                            gradient.EndPoint = new Point(0.5, 1);

                            gradient.GradientStops.Add(new GradientStop(Colors.DarkRed, 0));
                            gradient.GradientStops.Add(new GradientStop(Colors.IndianRed, 1));


                            grdBackColor.Background = gradient;
                            MessageBox.Show("Incorrect!");
                        }
                    }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have missed your endtime! Contact an admin.", "Error!");
                    }               
            }
            else
            {
                MessageBox.Show("You have not selected an answer!", "Oops!");
            }

        }
    }
}
