using System.Windows;
using RF.SurveyQuestion.BL;

namespace RF.SurveyQuestion
{
    /// <summary>
    /// Interaction logic for AssignQA.xaml
    /// </summary>
    public partial class AssignQA : Window
    {
        CQuestionList questions;
        CAnswerList answers;

        CQuestion question;
        CAnswer answer1;
        CAnswer answer2;
        CAnswer answer3;
        CAnswer answer4;

        int CorrectAnswer = 0;

        public AssignQA()
        {
            InitializeComponent();
            RefreshScreen();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAssign_Click(object sender, RoutedEventArgs e)
        {
            if (CorrectAnswer != 0)
            {
                try
                {
                    CAnswerList AnswerList = new CAnswerList();

                    if (cboQuestion.SelectedIndex > -1)
                    {
                        if (cboAnswerOne.SelectedIndex > -1)
                        {
                            if (CorrectAnswer == 1)
                            {
                                answer1.IsCorrect = true;
                            }
                            AnswerList.Add(answer1);
                        }
                        if (cboAnswerTwo.SelectedIndex > -1)
                        {
                            if (CorrectAnswer == 2)
                            {
                                answer2.IsCorrect = true;
                            }
                            AnswerList.Add(answer2);
                        }
                        if (cboAnswerThree.SelectedIndex > -1)
                        {
                            if (CorrectAnswer == 3)
                            {
                                answer3.IsCorrect = true;
                            }
                            AnswerList.Add(answer3);
                        }
                        if (cboAnswerFour.SelectedIndex > -1)
                        {
                            if (CorrectAnswer == 4)
                            {
                                answer4.IsCorrect = true;
                            }
                            AnswerList.Add(answer4);
                        }

                        if (AnswerList.Count > 1)
                        {
                            question.AssignQA(AnswerList);
                            MessageBox.Show("Your question and assigned answers have been uploaded.", "Transaction");
                            RefreshScreen();
                        }
                        else
                        {
                            MessageBox.Show("Please assign at least 2 answers to a question.", "Oops.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please select a question.", "Oops!");
                    }

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }
            else
            {
                MessageBox.Show("Please select a correct answer.", "Oops.");
            }

        }

        private void rdbCorrectOne_Checked(object sender, RoutedEventArgs e)
        {
            CorrectAnswer = 1;
        }

        private void rdbCorrectTwo_Checked(object sender, RoutedEventArgs e)
        {
            CorrectAnswer = 2;
        }

        private void rdbCorrectThree_Checked(object sender, RoutedEventArgs e)
        {
            CorrectAnswer = 3;
        }

        private void rdbCorrectFour_Checked(object sender, RoutedEventArgs e)
        {
            CorrectAnswer = 4;
        }

        private void RefreshScreen()
        {
            try
            {
                //Clear the radio buttons.
                rdbCorrectOne.IsChecked = false;
                rdbCorrectTwo.IsChecked = false;
                rdbCorrectThree.IsChecked = false;
                rdbCorrectFour.IsChecked = false;

                //Reset the CorrectAnswer int.
                CorrectAnswer = 0;

                //Set up the display paths of all the combo boxes.
                cboQuestion.SelectedValuePath = "Id";
                cboQuestion.DisplayMemberPath = "Text";

                cboAnswerOne.SelectedValuePath = "Id";
                cboAnswerOne.DisplayMemberPath = "Text";
                cboAnswerTwo.SelectedValuePath = "Id";
                cboAnswerTwo.DisplayMemberPath = "Text";
                cboAnswerThree.SelectedValuePath = "Id";
                cboAnswerThree.DisplayMemberPath = "Text";
                cboAnswerFour.SelectedValuePath = "Id";
                cboAnswerFour.DisplayMemberPath = "Text";

                questions = new CQuestionList();
                questions.Load();

                //Set the question combobox
                cboQuestion.ItemsSource = null;
                cboQuestion.ItemsSource = questions;

                answers = new CAnswerList();
                answers.Load();
                //Set Answer 1 combobox.
                cboAnswerOne.ItemsSource = null;
                cboAnswerOne.ItemsSource = answers;
                //Set Answer 2 combobox.
                cboAnswerTwo.ItemsSource = null;
                cboAnswerTwo.ItemsSource = answers;
                //Set Answer 3 combobox.
                cboAnswerThree.ItemsSource = null;
                cboAnswerThree.ItemsSource = answers;
                //Set Answer 4 combobox.
                cboAnswerFour.ItemsSource = null;
                cboAnswerFour.ItemsSource = answers;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void cboQuestion_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cboQuestion.SelectedIndex > -1)
                {
                    question = questions[cboQuestion.SelectedIndex];
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void cboAnswerOne_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cboAnswerOne.SelectedIndex > -1)
                {
                    answer1 = answers[cboAnswerOne.SelectedIndex];
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void cboAnswerTwo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cboAnswerTwo.SelectedIndex > -1)
                {
                    answer2 = answers[cboAnswerTwo.SelectedIndex];
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void cboAnswerThree_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cboAnswerThree.SelectedIndex > -1)
                {
                    answer3 = answers[cboAnswerThree.SelectedIndex];
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void cboAnswerFour_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cboAnswerFour.SelectedIndex > -1)
                {
                    answer4 = answers[cboAnswerFour.SelectedIndex];
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
