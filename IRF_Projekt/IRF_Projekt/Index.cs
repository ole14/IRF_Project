﻿using IRF_Projekt.Entities;
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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IRF_Projekt
{
    public partial class Index : Form
    {

        Animal_dbEntities context = new Animal_dbEntities();
        List<Allatok> allatoks = new List<Allatok>();
        List<SelectedAnimal> sanimal = new List<SelectedAnimal>();

        string[] headers = new string[]
        {
            "Utolsó Módosítás Dátuma"
            ,"Állat Típus"
            ,"Állat Neve"
            ,"Ár (Forint)"
            ,"Készlet (darab)"
            ,"Érték (Forint)"
        };

        bool modifyok = false;

        int LastRow = 0;

        Excel.Application x1App; // Alkalmazás változó
        Excel.Workbook x1WB; //Munkafüzet
        Excel.Worksheet x1Sheet; //Munkalap neve

        public Index()
        {
            InitializeComponent();
            LoadButtons();
            LoadTypes();
            typeLabel.Text = "Válaszd ki a fajtát";
            Modifycheck();
        }

        private void Modifycheck()
        {
            if (modifyok == false)
            {
                modifyButt.Enabled = false;
                animalDelete.Enabled = false;
                catModButt.Enabled = false;
                excelButt.Enabled = false;
            }
            else
            {
                modifyButt.Enabled = true;
                animalDelete.Enabled = true;
                catModButt.Enabled = true;
                excelButt.Enabled = true;
            }
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
            modifyok = true;
            Modifycheck();
        }

        void button_click2(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var animals = (from x in allatoks
                           select x.AnimalName);

            animalBox.DataSource = animals.ToList();
            typeLabel.Text = btn.Text;
            modifyok = true;
            Modifycheck();
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

                    HistoryCheck(a.AnimalTypes, a.AnimalName);
                }
            }
        }

        private void LoadTypes(string csv)
        {
            allatoks.Clear();
            using (StreamReader sr = new StreamReader(csv, Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    Allatok a = new Allatok();
                    a.AnimalTypes = line[0];
                    a.AnimalName = line[1];
                    allatoks.Add(a);
                    HistoryCheck(a.AnimalTypes, a.AnimalName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            csvImportBox.Text = ofd.FileName.ToString();
            LoadTypes(csvImportBox.Text);
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

        private void modifyButt_Click(object sender, EventArgs e)
        {
            AnimalProperty ap = new AnimalProperty(animalBox.SelectedValue.ToString());
            ap.ShowDialog();
            AnimalDataLoad();
        }

        private void animalBox_SelectedValueChanged(object sender, EventArgs e)
        {
            AnimalDataLoad();
        }

        private void AnimalDataLoad()
        {
            string animalN = animalBox.SelectedValue.ToString();

            var keszlet = (from x in context.AnimalDatas
                           where x.AnimName == animalN
                           orderby x.Date descending
                           select x.AnimQuantity).FirstOrDefault();

            var ar = (from x in context.AnimalDatas
                      where x.AnimName == animalN
                      orderby x.Date descending
                      select x.AnimPrice).FirstOrDefault();

            quantityBox.Text = keszlet.ToString() + " db";
            priceBox.Text = ar.ToString() + " Ft";
        }

        private void HistoryCheck(string atype, string aname)
        {
            try
            {
                var vanadat = (from x in context.AnimalDatas
                               where x.AnimName == aname && x.AnimType == atype
                               orderby x.Date descending
                               select x.AnimName).First();
            }
            catch (Exception)
            {
                AnimalError ae = new AnimalError(aname, atype);
                ae.ShowDialog();
                HistoryCheck(atype, aname);
            }
        }

        private void catModButt_Click(object sender, EventArgs e)
        {
            CategoryPriceModify cpm = new CategoryPriceModify(typeLabel.Text.ToString(), allatoks);
            cpm.ShowDialog();
            AnimalDataLoad();
        }

        private void excelButt_Click(object sender, EventArgs e)
        {
            foreach (string allat in animalBox.Items)
            {
                var allatok = (from a in context.AnimalDatas
                               where a.AnimName == allat && a.AnimType == typeLabel.Text
                               orderby a.Date descending
                               select a).FirstOrDefault();

                SelectedAnimal sa = new SelectedAnimal
                {
                    Date = allatok.Date,
                    AnimType = allatok.AnimType,
                    AnimName = allatok.AnimName,
                    AnimPrice = allatok.AnimPrice,
                    AnimQuantity = allatok.AnimQuantity
                };
                sanimal.Add(sa);
            }
            CreateExcel();
        }

        private void CreateExcel()
        {
            try
            {
                x1App = new Excel.Application(); //ez indítja az excelt és tölti be az objektumot
                x1WB = x1App.Workbooks.Add(Missing.Value); //Új munkafüzet
                x1Sheet = x1WB.ActiveSheet; //Új munkalap

                CreateTable();

                x1App.Visible = true;
                x1App.UserControl = true;

            }
            catch (Exception ex)
            {

                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                //hibára futva excel bezárása
                x1WB.Close(false, Type.Missing, Type.Missing);
                x1App.Quit();
                x1WB = null;
                x1App = null;
            }
        }

        private void CreateTable()
        {
            for (int i = 0; i < headers.Length; i++)
            {
                x1Sheet.Cells[1, i + 1] = headers[i];
            }

            object[,] values = new object[sanimal.Count, headers.Length];

            int szamlal = 0;
            foreach (SelectedAnimal a in sanimal)
            {
                values[szamlal, 0] = a.Date;
                values[szamlal, 1] = a.AnimType;
                values[szamlal, 2] = a.AnimName;
                values[szamlal, 3] = a.AnimPrice;
                values[szamlal, 4] = a.AnimQuantity;
                values[szamlal, 5] = a.AnimPrice * a.AnimQuantity;
                szamlal++;
            }

            x1Sheet.get_Range(
                        GetCell(2, 1),
                        GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            int lastRowID = x1Sheet.UsedRange.Rows.Count;
            LastRow = lastRowID;

            FormatTable();
        }

        private void FormatTable()
        {
            Excel.Range header = x1Sheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            header.Font.Bold = true;
            header.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            header.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            header.EntireColumn.AutoFit();
            header.Interior.Color = Color.LightYellow;
            header.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range datumOszlop = x1Sheet.get_Range(GetCell(2, 1), GetCell(LastRow, 1));
            datumOszlop.Font.Italic = true;
            datumOszlop.NumberFormat = "mm/dd/yyyy hh:mm:ss";
            datumOszlop.Interior.Color = Color.LightGray;
            datumOszlop.EntireColumn.AutoFit();
            datumOszlop.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
            datumOszlop.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            datumOszlop.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            Excel.Range szamtartomany = x1Sheet.get_Range(GetCell(2, 4), GetCell(LastRow, 5));
            szamtartomany.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            szamtartomany.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            szamtartomany.BorderAround2(Excel.XlLineStyle.xlDash, Excel.XlBorderWeight.xlThin);
            szamtartomany.Interior.Color = Color.FloralWhite;

            Excel.Range adattart = x1Sheet.get_Range(GetCell(2, 2), GetCell(LastRow, 3));
            adattart.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            adattart.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            adattart.BorderAround2(Excel.XlLineStyle.xlDashDot, Excel.XlBorderWeight.xlThin);
            adattart.Interior.Color = Color.AliceBlue;

            Excel.Range ertektartomany = x1Sheet.get_Range(GetCell(2, 6), GetCell(LastRow, 6));
            ertektartomany.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            ertektartomany.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            ertektartomany.Font.Bold = true;
            ertektartomany.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
            ertektartomany.Interior.Color = Color.LightGreen;
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }

            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}
