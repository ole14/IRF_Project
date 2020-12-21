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
            LoadTypes();
            LoadButtons();     
            teszt_data.DataSource = allatoks;
        }

        private void LoadButtons()
        {
            for (int i = 0; i < 7; i++)
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
