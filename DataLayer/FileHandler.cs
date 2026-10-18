using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272Group5PM.DataLayer
{
    internal class FileHandler
    {
        private string path = @"animal.txt";

        public List<Animals> readAnimals()
        {
            List<Animals> animal = new List<Animals>();
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string text
            while ((text = sr.ReadLine()) != null)
            {
                string[] strings = text.Split('|');
                Animals newAnimal = new Animals(int.Parse(string[0], string[1], string[2], string[3], string[4], string[5], string[6], string[7]);
                animal.Add(newAnimal);
            }
            fs.Close();
            sr.Close();

            return animal;
        }

    }
}
