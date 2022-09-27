using System.Windows;
using RF.SurveyQuestion.BL;
using System.Windows.Media;

namespace RF.SurveyQuestion
{
    /// <summary>
    /// Interaction logic for MaintainQA.xaml
    /// </summary>
    public partial class MaintainQA : Window
    {
        ScreenMode mode;
        CQuestionList questions;
        CAnswerList answers;

        CQuestion question;
        CAnswer answer;



        public MaintainQA(ScreenMode _mode)
        {
            InitializeComponent();

            mode = _mode;

            RefreshScreen();

            cboAttribute.SelectedValuePath = "Id";
            cboAttribute.DisplayMemberPath = "Text";

            lblAttribute.Content = mode.ToString() + "s:";
            this.Title = "Maintain " + mode.ToString() + "s:";

            if (mode == ScreenMode.Question)
            {
                LinearGradientBrush gradient = new LinearGradientBrush();
                gradient.StartPoint = new Point(0.5, 0);
                gradient.EndPoint = new Point(0.5, 1);

                gradient.GradientStops.Add(new GradientStop(Color.FromArgb(205, 205, 59, 59), 0));
                gradient.GradientStops.Add(new GradientStop(Colors.Wheat, 1));


                grdBackground.Background = gradient;
            }

            if (mode == ScreenMode.Answer)
            {
                LinearGradientBrush gradient = new LinearGradientBrush();
                gradient.StartPoint = new Point(0.5, 0);
                gradient.EndPoint = new Point(0.5, 1);

                gradient.GradientStops.Add(new GradientStop(Colors.CornflowerBlue, 0));
                gradient.GradientStops.Add(new GradientStop(Colors.Wheat, 1));


                grdBackground.Background = gradient;
            }
        }

        private void RefreshScreen()
        {
            try
            {
                switch (mode)
                {
                    case ScreenMode.Question:
                        questions = new CQuestionList();
                        questions.Load();

                        //Null to prevent load errors.
                        cboAttribute.ItemsSource = null;
                        cboAttribute.ItemsSource = questions;

                        break;
                    case ScreenMode.Answer:
                        answers = new CAnswerList();
                        answers.Load();

                        cboAttribute.ItemsSource = null;
                        cboAttribute.ItemsSource = answers;
                        break;
                    default:
                        break;
                }

                txtAttribute.Text = "";
            
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtAttribute.Text != "")
                {
                    switch (mode)
                    {
                        case ScreenMode.Question:
                            question = new CQuestion();
                            question.Text = txtAttribute.Text;
                            question.Insert();
                            break;
                        case ScreenMode.Answer:
                            answer = new CAnswer();
                            answer.Text = txtAttribute.Text;
                            answer.Insert();
                            break;
                        default:
                            break;
                    }

                    RefreshScreen();
                    txbDisplayText.Text = mode.ToString() + " inserted!";
                }
                else
                {
                    txbDisplayText.Text = "Please enter a " + mode.ToString() + " before inserting.";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void cboAttribute_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cboAttribute.SelectedIndex > -1)
                {
                    switch (mode)
                    {
                        case ScreenMode.Question:
                            question = questions[cboAttribute.SelectedIndex];
                            txtAttribute.Text = question.Text;
                            break;
                        case ScreenMode.Answer:
                            answer = answers[cboAttribute.SelectedIndex];
                            txtAttribute.Text = answer.Text;
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtAttribute.Text != "")
                {
                    switch (mode)
                    {
                        case ScreenMode.Question:
                            question.Text = txtAttribute.Text;
                            question.Update();
                            break;
                        case ScreenMode.Answer:
                            answer.Text = txtAttribute.Text;
                            answer.Update();
                            break;
                        default:
                            break;
                    }
                    RefreshScreen();
                    txbDisplayText.Text = mode.ToString() + " updated!";
                }
                else
                {
                    txbDisplayText.Text = "Please enter a " + mode.ToString() + " before updating.";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtAttribute.Text != "")
                {
                    switch (mode)
                    {
                        case ScreenMode.Question:
                            question.Delete();
                            break;
                        case ScreenMode.Answer:
                            answer.Delete();
                            break;
                        default:
                            break;
                    }

                    RefreshScreen();
                    txbDisplayText.Text = mode.ToString() + " deleted!";
                }
                else
                {
                    txbDisplayText.Text = "Please select a " + mode.ToString() + " before deleting.";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void txtAttribute_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            txbDisplayText.Text = txtAttribute.Text;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
