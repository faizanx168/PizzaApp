namespace PizzaApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toppings = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCrust = new System.Windows.Forms.ComboBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Soda1 = new System.Windows.Forms.Label();
            this.water1 = new System.Windows.Forms.Label();
            this.Soda = new System.Windows.Forms.TextBox();
            this.water = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::PizzaApp.Properties.Resources.RS25986_GettyImages_1022603718_scr;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.toppings);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboCrust);
            this.tabPage1.Controls.Add(this.comboSize);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(560, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pizza";
            // 
            // toppings
            // 
            this.toppings.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toppings.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppings.FormattingEnabled = true;
            this.toppings.Items.AddRange(new object[] {
            "Feta",
            "Roasted Red Peppers",
            "Jalapenos",
            "Steak",
            "Ground Beef",
            "Sun-Dried Tomatoes"});
            this.toppings.Location = new System.Drawing.Point(52, 244);
            this.toppings.Margin = new System.Windows.Forms.Padding(4);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(255, 200);
            this.toppings.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Place order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 49);
            this.label4.TabIndex = 6;
            this.label4.Text = "Topings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pizza Selections";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // comboCrust
            // 
            this.comboCrust.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCrust.FormattingEnabled = true;
            this.comboCrust.Items.AddRange(new object[] {
            "Chicken ",
            "Beef",
            "Vegetable",
            "Cheeze",
            "Thin crust",
            "Combo Pizza"});
            this.comboCrust.Location = new System.Drawing.Point(343, 123);
            this.comboCrust.Margin = new System.Windows.Forms.Padding(4);
            this.comboCrust.Name = "comboCrust";
            this.comboCrust.Size = new System.Drawing.Size(203, 30);
            this.comboCrust.TabIndex = 1;
            // 
            // comboSize
            // 
            this.comboSize.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Items.AddRange(new object[] {
            "Small (10\") - 10$",
            "Medium (12\") - 13$",
            "large(14\') - 16$"});
            this.comboSize.Location = new System.Drawing.Point(20, 123);
            this.comboSize.Margin = new System.Windows.Forms.Padding(4);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(231, 30);
            this.comboSize.TabIndex = 0;
            this.comboSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::PizzaApp.Properties.Resources.beverages_carbonated_drink_cold_drink_1571849;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.Soda1);
            this.tabPage2.Controls.Add(this.water1);
            this.tabPage2.Controls.Add(this.Soda);
            this.tabPage2.Controls.Add(this.water);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(560, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Beverages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(185, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Place order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(51, 336);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(411, 34);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Soda is 1.5$, Water is 1 Dollar each";
            // 
            // Soda1
            // 
            this.Soda1.AutoSize = true;
            this.Soda1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Soda1.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soda1.Location = new System.Drawing.Point(44, 110);
            this.Soda1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Soda1.Name = "Soda1";
            this.Soda1.Size = new System.Drawing.Size(92, 32);
            this.Soda1.TabIndex = 3;
            this.Soda1.Text = "Soda";
            // 
            // water1
            // 
            this.water1.AutoSize = true;
            this.water1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.water1.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water1.Location = new System.Drawing.Point(44, 247);
            this.water1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.water1.Name = "water1";
            this.water1.Size = new System.Drawing.Size(103, 32);
            this.water1.TabIndex = 2;
            this.water1.Text = "Water";
            // 
            // Soda
            // 
            this.Soda.BackColor = System.Drawing.SystemColors.Info;
            this.Soda.Location = new System.Drawing.Point(179, 116);
            this.Soda.Margin = new System.Windows.Forms.Padding(4);
            this.Soda.Name = "Soda";
            this.Soda.Size = new System.Drawing.Size(153, 22);
            this.Soda.TabIndex = 1;
            // 
            // water
            // 
            this.water.BackColor = System.Drawing.SystemColors.Info;
            this.water.Location = new System.Drawing.Point(179, 254);
            this.water.Margin = new System.Windows.Forms.Padding(4);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(153, 22);
            this.water.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 521);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboCrust;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Soda1;
        private System.Windows.Forms.Label water1;
        private System.Windows.Forms.TextBox Soda;
        private System.Windows.Forms.TextBox water;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox toppings;
    }
}

