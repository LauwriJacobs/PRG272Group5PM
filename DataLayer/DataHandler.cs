using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG272Group5PM.DataLayer
{
    class DataHandler
    {
     public string path = @"animal.txt";

        public void AddAnimal(string animalid, string name, string species, string age, string status, int recovscore, string HU)
        {

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string text;

                text = $"{animalid}|{name}|{species}|{age}|{recovscore}|{status}|{HU}";

                sw.WriteLine(text);
            }

            fs.Close();
            MessageBox.Show("Data has been saved");
        }

        public void ViewAnimal()
        {
            List<Animals> animal = new List<Animal>

            dgvAnimals.DataSource = animal;
        }
    }
}
