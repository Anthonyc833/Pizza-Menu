namespace MENU_01
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
            this.Piza_button = new System.Windows.Forms.Button();
            this.PizzaC = new System.Windows.Forms.CheckedListBox();
            this.Crust = new System.Windows.Forms.CheckedListBox();
            this.Size = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MAINCOURSE = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Beverage = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Desert = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Piza_button
            // 
            this.Piza_button.Location = new System.Drawing.Point(12, 12);
            this.Piza_button.Name = "Piza_button";
            this.Piza_button.Size = new System.Drawing.Size(75, 34);
            this.Piza_button.TabIndex = 0;
            this.Piza_button.Text = "Pizza";
            this.Piza_button.UseVisualStyleBackColor = true;
            this.Piza_button.Click += new System.EventHandler(this.Piza_button_Click);
            // 
            // PizzaC
            // 
            this.PizzaC.FormattingEnabled = true;
            this.PizzaC.Location = new System.Drawing.Point(111, 12);
            this.PizzaC.Name = "PizzaC";
            this.PizzaC.Size = new System.Drawing.Size(120, 34);
            this.PizzaC.TabIndex = 1;
            this.PizzaC.Click += new System.EventHandler(this.Pizza);
            // 
            // Crust
            // 
            this.Crust.FormattingEnabled = true;
            this.Crust.Location = new System.Drawing.Point(246, 12);
            this.Crust.Name = "Crust";
            this.Crust.Size = new System.Drawing.Size(120, 34);
            this.Crust.TabIndex = 2;
            this.Crust.Click += new System.EventHandler(this.PIZZA_Crust);
            // 
            // Size
            // 
            this.Size.FormattingEnabled = true;
            this.Size.Location = new System.Drawing.Point(411, 12);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(120, 34);
            this.Size.TabIndex = 3;
            this.Size.Click += new System.EventHandler(this.PIZZA_SIZE);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MAINCOURSE
            // 
            this.MAINCOURSE.FormattingEnabled = true;
            this.MAINCOURSE.Location = new System.Drawing.Point(102, 67);
            this.MAINCOURSE.Name = "MAINCOURSE";
            this.MAINCOURSE.Size = new System.Drawing.Size(120, 34);
            this.MAINCOURSE.TabIndex = 5;
            this.MAINCOURSE.Click += new System.EventHandler(this.MainCourse);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Beverage
            // 
            this.Beverage.FormattingEnabled = true;
            this.Beverage.Location = new System.Drawing.Point(102, 132);
            this.Beverage.Name = "Beverage";
            this.Beverage.Size = new System.Drawing.Size(120, 34);
            this.Beverage.TabIndex = 7;
            this.Beverage.Click += new System.EventHandler(this.COLDONES);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Desert
            // 
            this.Desert.FormattingEnabled = true;
            this.Desert.Location = new System.Drawing.Point(93, 185);
            this.Desert.Name = "Desert";
            this.Desert.Size = new System.Drawing.Size(120, 34);
            this.Desert.TabIndex = 9;
            this.Desert.Click += new System.EventHandler(this.DesertC);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Place order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlaceO);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(246, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 160);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 272);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Desert);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Beverage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MAINCOURSE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Crust);
            this.Controls.Add(this.PizzaC);
            this.Controls.Add(this.Piza_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Piza_button;
        private System.Windows.Forms.CheckedListBox PizzaC;
        private System.Windows.Forms.CheckedListBox Crust;
        private System.Windows.Forms.CheckedListBox Size;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox MAINCOURSE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox Beverage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox Desert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

