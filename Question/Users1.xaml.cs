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
    /// Interaction logic for Users1.xaml
    /// </summary>
    public partial class Users1 : Window
    {
        DataManager _data;
        public Users1()
        {
            InitializeComponent();
            _data = new DataManager(new QuestionDataBaseEntities());
            Init();
        }

        private void Init()
        {
            foreach (var user in _data.Users.GetUsers().ToList())
            {
                UserList.Items.Add(String.Format("Name: {0} Years: {1}", user.Login, user.Years));
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_data.Users.GetUser(LoginTextBox.Text, PasswordTextBox.Text) != null)
            {
                ErrorL.Visibility = Visibility.Hidden;
                UserList.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorL.Visibility = Visibility.Visible;
            }
        }
    }
}
