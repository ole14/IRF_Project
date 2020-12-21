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
            teszt_data.DataSource = allatoks;
            
        }

        private void LoadButtons()
        {
            int szoroz = 0;
            int sor = 0;
            TypesEnum[] buttons = (TypesEnum[])Enum.GetValues(typeof(TypesEnum));
            foreach (TypesEnum b in buttons)
            {
                Button butt = new Button();
                butt.Width = 120;
                butt.Height = 50;
                if (szoroz < 3)
                {
                    butt.Left = szoroz * 120;
                }
                else
                {
                    szoroz = 0;
                    sor = 1;
                    butt.Left = szoroz * 120;
                }
                butt.Top = sor * 50;
                butt.Text = b.ToString();
                butt.Font = new Font(butt.Font.FontFamily, 12, FontStyle.Bold);
                butt.Click += Butt_Click;
                szoroz++;
                Controls.Add(butt);
            }
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            if ()
            {

            }
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

        }
    }
}
