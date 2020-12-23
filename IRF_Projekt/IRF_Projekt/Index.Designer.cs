
namespace IRF_Projekt
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.animalBox = new System.Windows.Forms.ListBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.animalDelete = new System.Windows.Forms.Button();
            this.csvImportBox = new System.Windows.Forms.TextBox();
            this.modifyButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.catModButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CSV újraolvasása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kiírás excelbe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // animalBox
            // 
            this.animalBox.FormattingEnabled = true;
            this.animalBox.Location = new System.Drawing.Point(122, 33);
            this.animalBox.Name = "animalBox";
            this.animalBox.Size = new System.Drawing.Size(197, 316);
            this.animalBox.TabIndex = 3;
            this.animalBox.SelectedValueChanged += new System.EventHandler(this.animalBox_SelectedValueChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(125, 3);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(69, 28);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "label1";
            // 
            // animalDelete
            // 
            this.animalDelete.Location = new System.Drawing.Point(325, 326);
            this.animalDelete.Name = "animalDelete";
            this.animalDelete.Size = new System.Drawing.Size(124, 23);
            this.animalDelete.TabIndex = 5;
            this.animalDelete.Text = "Állat törlése";
            this.animalDelete.UseVisualStyleBackColor = true;
            this.animalDelete.Click += new System.EventHandler(this.animalDelete_Click);
            // 
            // csvImportBox
            // 
            this.csvImportBox.Location = new System.Drawing.Point(1, 355);
            this.csvImportBox.Name = "csvImportBox";
            this.csvImportBox.Size = new System.Drawing.Size(318, 20);
            this.csvImportBox.TabIndex = 6;
            // 
            // modifyButt
            // 
            this.modifyButt.Location = new System.Drawing.Point(325, 89);
            this.modifyButt.Name = "modifyButt";
            this.modifyButt.Size = new System.Drawing.Size(124, 40);
            this.modifyButt.TabIndex = 7;
            this.modifyButt.Text = "Nyilvántartott adatok módosítása";
            this.modifyButt.UseVisualStyleBackColor = true;
            this.modifyButt.Click += new System.EventHandler(this.modifyButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ár";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(331, 63);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceBox.Size = new System.Drawing.Size(113, 20);
            this.priceBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Készlet";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(331, 24);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.ReadOnly = true;
            this.quantityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityBox.Size = new System.Drawing.Size(113, 20);
            this.quantityBox.TabIndex = 8;
            // 
            // catModButt
            // 
            this.catModButt.Location = new System.Drawing.Point(325, 135);
            this.catModButt.Name = "catModButt";
            this.catModButt.Size = new System.Drawing.Size(124, 36);
            this.catModButt.TabIndex = 12;
            this.catModButt.Text = "Kategória alapú ármódosítás";
            this.catModButt.UseVisualStyleBackColor = true;
            this.catModButt.Click += new System.EventHandler(this.catModButt_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 421);
            this.Controls.Add(this.catModButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.modifyButt);
            this.Controls.Add(this.csvImportBox);
            this.Controls.Add(this.animalDelete);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.animalBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Index";
            this.Text = "Állatkereskedés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox animalBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button animalDelete;
        private System.Windows.Forms.TextBox csvImportBox;
        private System.Windows.Forms.Button modifyButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Button catModButt;
    }
}

