using IRF_Projekt.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt
{
    public partial class Form1 : Form
    {

        List<Allatok> allatoks = new List<Allatok>();
        public Form1()
        {
            InitializeComponent();
            LoadButtons();
            LoadTypes();
            typeLabel.Text = "Válaszd ki a fajtát";
        }

        private void LoadButtons()
        {
            int sor = 0;
            TypesEnum[] buttons = (TypesEnum[])Enum.GetValues(typeof(TypesEnum));
            foreach (TypesEnum b in buttons)
            {
                Button butt = new Button();
                butt.Width = 120;
                butt.Height = 50;
                butt.Top = sor * 50;
                butt.Text = b.ToString();
                butt.Font = new Font(butt.Font.FontFamily, 12, FontStyle.Bold);
                butt.Click += new EventHandler(this.button_click);
                sor++;
                Controls.Add(butt);
            }
            Button butt2 = new Button();
            butt2.Width = 120;
            butt2.Height = 50;
            butt2.Top = sor * 50;
            butt2.Text = "Összes állat";
            butt2.Font = new Font(butt2.Font.FontFamily, 12, FontStyle.Bold);
            butt2.Click += new EventHandler(this.button_click2);
            sor++;
            Controls.Add(butt2);
        }

        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var animals = (from x in allatoks
                            where x.AnimalTypes == btn.Text
                            select x.AnimalName);

            animalBox.DataSource = animals.ToList();
            typeLabel.Text = btn.Text;
        }

        void button_click2(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var animals = (from x in allatoks
                           select x.AnimalName);

            animalBox.DataSource = animals.ToList();
            typeLabel.Text = btn.Text;
        }

        private void LoadTypes()
        {
            allatoks.Clear();
            using (StreamReader sr = new StreamReader("allatok_import.csv", Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    Allatok a = new Allatok();
                    a.AnimalTypes = line[0];
                    a.AnimalName = line[1];
                    allatoks.Add(a);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTypes();
        }

        private void animalDelete_Click(object sender, EventArgs e)
        {
            dynamic akt = animalBox.SelectedValue;

            var kuka = (from x in allatoks
                         where x.AnimalName == akt
                         select x).FirstOrDefault();

            allatoks.Remove(kuka);

            if (typeLabel.Text == "Összes állat")
            {
                var animals = (from x in allatoks
                               select x.AnimalName);

                animalBox.DataSource = animals.ToList();
            }
            else
            {
                var animals = (from x in allatoks
                               where x.AnimalTypes == typeLabel.Text
                               select x.AnimalName);

                animalBox.DataSource = animals.ToList();
            }
        }
    }
}
