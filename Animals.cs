using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272Group5PM
{
    internal class Animals
    {
        private string animalid;
        private string name;
        private string species;
        private string age;
        private int recoverystat;
        private string status;
        private string housing;

        public Animals(string animalid, string name, string species, string age, int recoverystat, string status, string housing)
        {
            this.animalid = animalid;
            this.name = name;
            this.species = species;
            this.age = age;
            this.recoverystat = recoverystat;
            this.status = status;
            this.housing = housing;
        }

        public override string ToString()
        {
            return $"{animalid}|{name}|{species}|{age}|{recovscore}|{status}|{HU}";
        }

        public string AnimalID { get => animalid; set => animalid = value }
        public string Name { get => name; set => name = value }
        public string Species { get => species; set => species = value }
        public string Age { get => age; set => age = value }
        public string Recoverystat { get => recoverystat; set => recoverystat = value }
        public string Status { get => status; set => status = value }
        public string Housing { get => housing; set => housing = value }
    }
}
