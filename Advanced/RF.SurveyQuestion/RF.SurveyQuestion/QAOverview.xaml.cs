using System.Windows;
using RF.SurveyQuestion.BL;

namespace RF.SurveyQuestion
{
    /// <summary>
    /// Interaction logic for QAOverview.xaml
    /// </summary>

    public enum ScreenMode
    {
        Question = 1,
        Answer = 2
    }

    public partial class QAOverview : Window
    {
        CQuestion question;
        CQuestionList questions;

        public QAOverview()
        {
            InitializeComponent();

            cboQuestion.SelectedValuePath = "Id";
            cboQuestion.DisplayMemberPath = "Text";
        }



        private void btnQuestions_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MaintainQA oQA = new MaintainQA(ScreenMode.Question);
                oQA.ShowDialog();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void btnAnswers_Click(object sender, RoutedEventArgs e)
        {   
            MaintainQA oQA = new MaintainQA(ScreenMode.Answer);
            oQA.ShowDialog();
        }

        private void btnQA_Click(object sender, RoutedEventArgs e)
        {
            AssignQA oAssQa = new AssignQA();
            oAssQa.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            questions = new CQuestionList();
            questions.Load();

            //Null to prevent load errors.
            cboQuestion.ItemsSource = null;
            cboQuestion.ItemsSource = questions;

            dgQA.ItemsSource = questions;
            dgQA.Columns[0].Visibility = Visibility.Collapsed;
            dgQA.Columns[2].Visibility = Visibility.Collapsed;
        }

        private void btnViewQuestions_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CQuestionList questions = new CQuestionList();
                questions.Load();

                dgQA.ItemsSource = questions;
                dgQA.Columns[0].Visibility = Visibility.Collapsed;
                dgQA.Columns[2].Visibility = Visibility.Collapsed;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void btnViewAnswers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CAnswerList answers = new CAnswerList();
                answers.Load();

                dgQA.ItemsSource = answers;
                dgQA.Columns[0].Visibility = Visibility.Collapsed;
                dgQA.Columns[2].Visibility = Visibility.Collapsed;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnViewQA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CQAList qas = new CQAList();
                qas.LoadById(question.Id);

                dgQA.ItemsSource = qas;
                dgQA.Columns[0].Visibility = Visibility.Collapsed;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnViewID_Click(object sender, RoutedEventArgs e)
        {
            dgQA.Columns[0].Visibility = Visibility.Visible;
        }

        private void cboQuestion_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void cboQuestion_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
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
    }
}
