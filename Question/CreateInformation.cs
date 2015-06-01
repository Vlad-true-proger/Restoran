using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    class CreateInformation
    {
        List<string> povars = new List<string>();
        List<string> names = new List<string>();
        List<string> dishes = new List<string>();
        RestaurantEntities database = new RestaurantEntities();
        public void Create()
        {
            povars = ReadFromFile(@"C:\Users\Vlad\Desktop\Restoran\Restoran\Имена.txt");
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
