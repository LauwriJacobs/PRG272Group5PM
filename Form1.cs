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
            string animalID = txtAnimalID.Text.Trim;
            string name = txtName.Text.Trim;
            string species = txtSpecies.Text.Trim;
            string age = txtAge.Text.Trim;
            int RS = Convert.ToInt32(txtRecovery.Text.Trim);

            DataHandler handler = new DataHandler();

            string status = handler.CalculatorStatus(RS);
            string housing = handler.CalculateHousing(status);

            handler.AddAnimal(animalID, name, species, age, status,RS, housing);

        }
    }
}
