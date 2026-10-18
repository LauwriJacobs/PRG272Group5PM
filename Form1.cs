using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PRG272Group5PM.DataLayer;


namespace PRG272Group5PM
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private object btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string animalID = txtAnimalID.Text.Trim;
                string name = txtName.Text.Trim;
                string species = txtSpecies.Text.Trim;
                string age = txtAge.Text.Trim;
                int RS = Convert.ToInt32(txtRecovery.Text.Trim);

                if(string.IsNullOrEmpty(animalID,name,species,age,RS))
                {
                    MessageBox.Show("Please enter all inputs");
                }

            }
            catch(Exeption ex)
            {
                MessageBox.Show(ex);
            }

            bool hasWR = Text.Contains("WR-");
            int islength = animalID.Length;


            if (hasWR == true && islength == 7 )
            {
                string letters = animalID.Substring(0, 2);

                letters.ToUpper();
                string realAID = letters + animalID.Substring(animalID.IndexOf('-'));
                DataHandler handler = new DataHandler();

                string status = handler.CalculatorStatus(RS);
                string housing = handler.CalculateHousing(status);

                handler.AddAnimal(animalID, name, species, age, status, RS, housing);
            }
            else
            {
                MessageBox.Show("Incorrect ID syntax. ID must contain WR- followed by 4 numbers");
                txtAnimalID.Clear();
            }

            

        }
    }
}
