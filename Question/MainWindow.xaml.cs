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
using Question.Data;

namespace Question
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataManager _data;
        public MainWindow()
        {
            InitializeComponent();
            _data = new DataManager(new QuestionDataBaseEntities());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_data.Users.GetUser(LoginTextBox.Text, PasswordTextBox.Text) != null)
            {
                ErrorL.Visibility = Visibility.Hidden;
                CreateBtn.Visibility = Visibility.Visible;
                AnswerBtn.Visibility = Visibility.Visible;
                UsersBtn.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorL.Visibility = Visibility.Visible;
            }
            
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            Question1 q = new Question1();
            q.Show();
        }

        private void AnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            Answer1 a = new Answer1();
            a.Show();
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            Users1 u = new Users1();
            u.Show();
        }
    }
}
