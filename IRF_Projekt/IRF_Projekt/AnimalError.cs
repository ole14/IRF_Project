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
    public partial class AnimalError : Form
    {
        Animal_dbEntities context = new Animal_dbEntities();
        string aName;
        string aType;
        public AnimalError(string aname, string atype)
        {
            InitializeComponent();
            animalLabel.Text = aname;
            aName = aname;
            aType = atype;
        }

        private void insertButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(priceBox.Text) > 0 && int.Parse(quantityBox.Text) > 0)
                {
                    DateTime nowdate = DateTime.UtcNow;

                    AnimalData animal = new AnimalData
                    {
                        Date = nowdate,
                        AnimType = aType,
                        AnimName = aName,
                        AnimPrice = int.Parse(priceBox.Text),
                        AnimQuantity = int.Parse(quantityBox.Text)
                    };
                    context.AnimalDatas.Add(animal);
                    context.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rossz adatokat adtál meg!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Rossz adatokat adtál meg!");
                return;
            }
            
        }
    }
}
