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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtAnimalID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecies.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtRecovery.Text))
            {
                MessageBox.Show("Please enter all details");
                return;
            }
            try
            {
                string animalID = txtAnimalID.Text.Trim();
                string name = txtName.Text.Trim();
                string species = txtSpecies.Text.Trim();
                string age = txtAge.Text.Trim();
                int RS = Convert.ToInt32(txtRecovery.Text.Trim());
                string status;
                string housing;

                bool hasWR = Text.Contains("WR-");
                int islength = animalID.Length;

                if (hasWR == true && islength == 7)
                {
                    string letters = animalID.Substring(0, 2);

                    letters.ToUpper();
                    string realAID = letters + animalID.Substring(animalID.IndexOf('-'));
                    DataHandler handler = new DataHandler();

                    status = handler.CalculatorStatus(RS);
                    housing = handler.CalculateHousing(status);
                   
                    handler.AddAnimal(animalID, name, species, age, status, RS, housing);
                }
                else
                {
                    MessageBox.Show("Incorrect ID syntax. ID must contain WR- followed by 4 numbers");
                    txtAnimalID.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            


            

            

        }
    }
}
