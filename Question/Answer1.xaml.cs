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
using System.Windows.Shapes;
using Question.Data;

namespace Question
{
    /// <summary>
    /// Interaction logic for Answer1.xaml
    /// </summary>
    public partial class Answer1 : Window
    {
        DataManager _data;
        public Answer1()
        {
            InitializeComponent();
            _data = new DataManager(new QuestionDataBaseEntities());
            Init();
        }
        private void Init()
        {
            foreach (var quest in _data.Questions.GetQuestions().ToList())
            {
                QuestL.Items.Add(String.Format("{0}", quest.QuestionText));
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your answer was added");
        }

        private void Login2Btn_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void cLogin2Btn_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void LoginABtn_Click(object sender, RoutedEventArgs e)
           {
            if (_data.Users.GetUser(LoginTextBox.Text, PasswordTextBox.Text) != null)
            {
                ErrorL.Visibility = Visibility.Hidden;
                AnswerBtn.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorL.Visibility = Visibility.Visible;
            }
           
        }

        private void AnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            _data.Answers.AddAnswer((string)QuestL.SelectedValue, (string)AnswerL.SelectedValue, _data.Users.GetUser(LoginTextBox.Text, PasswordTextBox.Text).UserID);
            MessageBox.Show("Your answer was added to database");
        }

        private void QuestL_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            AnswerL.Items.Clear();
            foreach (var item in _data.Questions.GetAnswersByQuestionTitle((string)QuestL.SelectedValue))
            {
                AnswerL.Items.Add(item);
            }
        }
    }
}
