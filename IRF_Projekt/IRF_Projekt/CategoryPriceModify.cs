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
    public partial class CategoryPriceModify : Form
    {
        Animal_dbEntities context = new Animal_dbEntities();
        public CategoryPriceModify(string typename, List<Allatok> lista)
        {
            InitializeComponent();
            typeLabel.Text = typename;
            typeBox.Text = "Áremelés"; 
            LoadAllatok(typename, lista);
        }

        private void LoadAllatok(string typename, List<Allatok> lista)
        {
            var allatlista = (from x in lista
                              where x.AnimalTypes == typename
                              select x.AnimalName).ToList();
            listBox1.DataSource = allatlista;
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            if (typeBox.Text == "Áremelés")
            {                
                foreach (string anim in listBox1.Items)
                {
                    MessageBox.Show(anim.ToString());
                    var allatPrice = (from x in context.AnimalDatas
                                      where x.AnimType == typeLabel.Text && x.AnimName == anim
                                      orderby x.Date descending
                                      select x).FirstOrDefault();

                    DateTime nowdate = DateTime.UtcNow;
                    decimal szazalak = 1 + decimal.Parse(percentBox.Text) / 100;
                    decimal araz = decimal.Parse(allatPrice.AnimPrice.ToString()) * szazalak;
                    araz += .5m;
                    int ar = (int)araz;

                    AnimalData animal = new AnimalData
                    {
                        Date = nowdate,
                        AnimType = allatPrice.AnimType,
                        AnimName = allatPrice.AnimName,
                        AnimPrice = ar,
                        AnimQuantity = allatPrice.AnimQuantity
                    };
                    context.AnimalDatas.Add(animal);
                    context.SaveChanges();
                    this.Close();
                }
            }
            else
            {
                foreach (string anim in listBox1.Items)
                {
                    MessageBox.Show(anim.ToString());
                    var allatPrice = (from x in context.AnimalDatas
                                      where x.AnimType == typeLabel.Text && x.AnimName == anim
                                      orderby x.Date descending
                                      select x).FirstOrDefault();

                    DateTime nowdate = DateTime.UtcNow;
                    decimal szazalak = 1 - decimal.Parse(percentBox.Text) / 100;
                    decimal araz = decimal.Parse(allatPrice.AnimPrice.ToString()) * szazalak;
                    araz += .5m;
                    int ar = (int)araz;

                    AnimalData animal = new AnimalData
                    {
                        Date = nowdate,
                        AnimType = allatPrice.AnimType,
                        AnimName = allatPrice.AnimName,
                        AnimPrice = ar,
                        AnimQuantity = allatPrice.AnimQuantity
                    };
                    context.AnimalDatas.Add(animal);
                    context.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
