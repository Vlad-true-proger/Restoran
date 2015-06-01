using System;
using System.Collections.Generic;
using System.IO;
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

namespace Restoran
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> povars = new List<string>();
        List<string> names = new List<string>();
        List<string> dishes = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            CreateDataBase();
        }

        private void CreateDataBase()
        {
            //Новые блюда
            for(int i=0; i<15; i++)
            {

            }
            //Новые повара
            //Новые заказы
            //Новая карта
            //Новый счет
        }



        public List<string> ReadFromFile(string path)
        {
            List<string> mass = new List<string>();
            Stream s = new FileStream(path, FileMode.Open);
            using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    mass.Add(line);
                }
            } return mass;
        }

        public int Random(int min, int max)
        {
            Random r = new Random(int.Parse(DateTime.Now.Millisecond.ToString()));
           int t= r.Next(min, max);
           return t;
        }
    }
}
