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
    /// Interaction logic for Question1.xaml
    /// </summary>
    public partial class Question1 : Window
    {
        DataManager _data;
        public Question1()
        {
            InitializeComponent();
            _data = new DataManager(new QuestionDataBaseEntities());
        }

        private void LogInQBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_data.Users.GetUser(LoginTextBox.Text, PasswordTextBox.Text) != null)
            {
                ErrorL.Visibility = Visibility.Hidden;
                CreatBtn.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorL.Visibility = Visibility.Visible;
            }
          

        }
        private void CreatBtn_Click(object sender, RoutedEventArgs e)
        {

           _data.Questions.SaveQuestion(titleTextB.Text, Ans1TextB.Text, Ans2TextB.Text, Ans3TextB.Text);

            MessageBox.Show("Your question was created");
        }
    }
}
