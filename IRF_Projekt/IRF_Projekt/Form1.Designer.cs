
namespace IRF_Projekt
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CSV újraolvasása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 355);
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
            this.animalDelete.Location = new System.Drawing.Point(322, 33);
            this.animalDelete.Name = "animalDelete";
            this.animalDelete.Size = new System.Drawing.Size(124, 23);
            this.animalDelete.TabIndex = 5;
            this.animalDelete.Text = "Állat törlése";
            this.animalDelete.UseVisualStyleBackColor = true;
            this.animalDelete.Click += new System.EventHandler(this.animalDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 381);
            this.Controls.Add(this.animalDelete);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.animalBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
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
    }
}

