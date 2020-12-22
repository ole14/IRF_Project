using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt
{
    public partial class AnimalProperty : Form
    {
        Animal_dbEntities context = new Animal_dbEntities();
        public AnimalProperty(string animal)
        {
            InitializeComponent();
            animalLabel.Text = animal;
            LoadAnimal(animal);
        }

        private void LoadAnimal(string animalN)
        {
            var keszlet = (from x in context.AnimalDatas
                           where x.AnimName == animalN
                           orderby x.Date descending
                           select x.AnimQuantity).FirstOrDefault();
            
            var ar = (from x in context.AnimalDatas
                           where x.AnimName == animalN
                           orderby x.Date descending
                           select x.AnimPrice).FirstOrDefault();

            quantityBox.Text = keszlet.ToString();
            priceBox.Text = ar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var allat = (from x in context.AnimalDatas
                         where x.AnimName == animalLabel.Text.ToString()
                         orderby x.Date descending
                         select x).FirstOrDefault();

            DateTime nowdate = DateTime.UtcNow;

            AnimalData animal = new AnimalData
            {
                Date = nowdate,
                AnimType = allat.AnimType,
                AnimName = allat.AnimName,
                AnimPrice = int.Parse(priceBox.Text),
                AnimQuantity = int.Parse(quantityBox.Text)
            };
            context.AnimalDatas.Add(animal);
            context.SaveChanges();
            this.Close();
        }
    }
}
