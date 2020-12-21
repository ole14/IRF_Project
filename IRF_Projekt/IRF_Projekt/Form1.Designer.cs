
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
            this.teszt_data = new System.Windows.Forms.DataGridView();
            this.Kutya = new System.Windows.Forms.Button();
            this.Macska = new System.Windows.Forms.Button();
            this.Madár = new System.Windows.Forms.Button();
            this.Hüllő = new System.Windows.Forms.Button();
            this.Rágcsáló = new System.Windows.Forms.Button();
            this.Díszhal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teszt_data)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Beolvasás csv-ből";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kiírás excelbe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // teszt_data
            // 
            this.teszt_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teszt_data.Location = new System.Drawing.Point(12, 112);
            this.teszt_data.Name = "teszt_data";
            this.teszt_data.Size = new System.Drawing.Size(378, 326);
            this.teszt_data.TabIndex = 2;
            // 
            // Kutya
            // 
            this.Kutya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kutya.Location = new System.Drawing.Point(12, 12);
            this.Kutya.Name = "Kutya";
            this.Kutya.Size = new System.Drawing.Size(122, 42);
            this.Kutya.TabIndex = 3;
            this.Kutya.Text = "Kutya";
            this.Kutya.UseVisualStyleBackColor = true;
            // 
            // Macska
            // 
            this.Macska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Macska.Location = new System.Drawing.Point(140, 12);
            this.Macska.Name = "Macska";
            this.Macska.Size = new System.Drawing.Size(122, 42);
            this.Macska.TabIndex = 4;
            this.Macska.Text = "Macska";
            this.Macska.UseVisualStyleBackColor = true;
            // 
            // Madár
            // 
            this.Madár.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Madár.Location = new System.Drawing.Point(268, 12);
            this.Madár.Name = "Madár";
            this.Madár.Size = new System.Drawing.Size(122, 42);
            this.Madár.TabIndex = 5;
            this.Madár.Text = "Madár";
            this.Madár.UseVisualStyleBackColor = true;
            // 
            // Hüllő
            // 
            this.Hüllő.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hüllő.Location = new System.Drawing.Point(12, 60);
            this.Hüllő.Name = "Hüllő";
            this.Hüllő.Size = new System.Drawing.Size(122, 42);
            this.Hüllő.TabIndex = 6;
            this.Hüllő.Text = "Hüllő";
            this.Hüllő.UseVisualStyleBackColor = true;
            // 
            // Rágcsáló
            // 
            this.Rágcsáló.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rágcsáló.Location = new System.Drawing.Point(140, 60);
            this.Rágcsáló.Name = "Rágcsáló";
            this.Rágcsáló.Size = new System.Drawing.Size(122, 42);
            this.Rágcsáló.TabIndex = 7;
            this.Rágcsáló.Text = "Rágcsáló";
            this.Rágcsáló.UseVisualStyleBackColor = true;
            // 
            // Díszhal
            // 
            this.Díszhal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Díszhal.Location = new System.Drawing.Point(268, 60);
            this.Díszhal.Name = "Díszhal";
            this.Díszhal.Size = new System.Drawing.Size(122, 42);
            this.Díszhal.TabIndex = 8;
            this.Díszhal.Text = "Díszhal";
            this.Díszhal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Díszhal);
            this.Controls.Add(this.Rágcsáló);
            this.Controls.Add(this.Hüllő);
            this.Controls.Add(this.Madár);
            this.Controls.Add(this.Macska);
            this.Controls.Add(this.Kutya);
            this.Controls.Add(this.teszt_data);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Állatkereskedés";
            ((System.ComponentModel.ISupportInitialize)(this.teszt_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView teszt_data;
        private System.Windows.Forms.Button Kutya;
        private System.Windows.Forms.Button Macska;
        private System.Windows.Forms.Button Madár;
        private System.Windows.Forms.Button Hüllő;
        private System.Windows.Forms.Button Rágcsáló;
        private System.Windows.Forms.Button Díszhal;
    }
}

