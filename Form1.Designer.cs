namespace ControllerFrom
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
            this.labExit = new System.Windows.Forms.Label();
            this.labMake = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeper = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtarChees = new System.Windows.Forms.CheckBox();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.rbTakOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.labToppings = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labEat = new System.Windows.Forms.Label();
            this.labCrust = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnResert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbEat.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // labExit
            // 
            this.labExit.BackColor = System.Drawing.Color.Transparent;
            this.labExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExit.ForeColor = System.Drawing.Color.White;
            this.labExit.Location = new System.Drawing.Point(814, 0);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(29, 31);
            this.labExit.TabIndex = 0;
            this.labExit.Text = "X";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // labMake
            // 
            this.labMake.AutoSize = true;
            this.labMake.BackColor = System.Drawing.Color.Transparent;
            this.labMake.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labMake.Location = new System.Drawing.Point(260, 0);
            this.labMake.Name = "labMake";
            this.labMake.Size = new System.Drawing.Size(277, 40);
            this.labMake.TabIndex = 1;
            this.labMake.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(12, 61);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(134, 131);
            this.gbSize.TabIndex = 2;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size ";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(6, 96);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(59, 25);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.Tag = "30";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Location = new System.Drawing.Point(6, 64);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(86, 25);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "20";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(6, 32);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(67, 25);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rbThink);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.White;
            this.gbCrust.Location = new System.Drawing.Point(12, 219);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(134, 96);
            this.gbCrust.TabIndex = 3;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(6, 64);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(107, 25);
            this.rbThink.TabIndex = 1;
            this.rbThink.Tag = "10";
            this.rbThink.Text = "Think Crust";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(6, 28);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(99, 25);
            this.rbThin.TabIndex = 0;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkGreenPeper);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtarChees);
            this.gbToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(185, 61);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(285, 134);
            this.gbToppings.TabIndex = 4;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeper
            // 
            this.chkGreenPeper.AutoSize = true;
            this.chkGreenPeper.Location = new System.Drawing.Point(162, 97);
            this.chkGreenPeper.Name = "chkGreenPeper";
            this.chkGreenPeper.Size = new System.Drawing.Size(114, 25);
            this.chkGreenPeper.TabIndex = 5;
            this.chkGreenPeper.Tag = "5";
            this.chkGreenPeper.Text = "Green Peper";
            this.chkGreenPeper.UseVisualStyleBackColor = true;
            this.chkGreenPeper.CheckedChanged += new System.EventHandler(this.chkGreenPeper_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(162, 64);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(72, 25);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(162, 31);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(72, 25);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(6, 97);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(95, 25);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 64);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(113, 25);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtarChees
            // 
            this.chkExtarChees.AutoSize = true;
            this.chkExtarChees.Location = new System.Drawing.Point(6, 31);
            this.chkExtarChees.Name = "chkExtarChees";
            this.chkExtarChees.Size = new System.Drawing.Size(109, 25);
            this.chkExtarChees.TabIndex = 0;
            this.chkExtarChees.Tag = "5";
            this.chkExtarChees.Text = "Extra Chees";
            this.chkExtarChees.UseVisualStyleBackColor = true;
            this.chkExtarChees.CheckedChanged += new System.EventHandler(this.chkExtarChees_CheckedChanged);
            // 
            // gbEat
            // 
            this.gbEat.BackColor = System.Drawing.Color.Transparent;
            this.gbEat.Controls.Add(this.rbTakOut);
            this.gbEat.Controls.Add(this.rbEatIn);
            this.gbEat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEat.ForeColor = System.Drawing.Color.White;
            this.gbEat.Location = new System.Drawing.Point(203, 219);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(176, 70);
            this.gbEat.TabIndex = 4;
            this.gbEat.TabStop = false;
            this.gbEat.Text = "Where To Eat";
            // 
            // rbTakOut
            // 
            this.rbTakOut.AutoSize = true;
            this.rbTakOut.Location = new System.Drawing.Point(78, 28);
            this.rbTakOut.Name = "rbTakOut";
            this.rbTakOut.Size = new System.Drawing.Size(88, 25);
            this.rbTakOut.TabIndex = 1;
            this.rbTakOut.TabStop = true;
            this.rbTakOut.Text = "Take Out";
            this.rbTakOut.UseVisualStyleBackColor = true;
            this.rbTakOut.CheckedChanged += new System.EventHandler(this.rbTakOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(6, 28);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(66, 25);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbSummary
            // 
            this.gbSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbSummary.Controls.Add(this.labToppings);
            this.gbSummary.Controls.Add(this.label7);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Controls.Add(this.label1);
            this.gbSummary.Controls.Add(this.labTotalPrice);
            this.gbSummary.Controls.Add(this.labEat);
            this.gbSummary.Controls.Add(this.labCrust);
            this.gbSummary.Controls.Add(this.labSize);
            this.gbSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummary.ForeColor = System.Drawing.Color.White;
            this.gbSummary.Location = new System.Drawing.Point(529, 61);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(245, 302);
            this.gbSummary.TabIndex = 5;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            this.gbSummary.Enter += new System.EventHandler(this.gbSummary_Enter);
            // 
            // labToppings
            // 
            this.labToppings.Location = new System.Drawing.Point(7, 96);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(219, 78);
            this.labToppings.TabIndex = 16;
            this.labToppings.Text = "No Check Toppings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Where Eat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Crust Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toppings : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Size : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total : ";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labTotalPrice.Location = new System.Drawing.Point(73, 266);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(49, 37);
            this.labTotalPrice.TabIndex = 9;
            this.labTotalPrice.Text = "$0";
            // 
            // labEat
            // 
            this.labEat.AutoSize = true;
            this.labEat.Location = new System.Drawing.Point(97, 222);
            this.labEat.Name = "labEat";
            this.labEat.Size = new System.Drawing.Size(129, 21);
            this.labEat.TabIndex = 8;
            this.labEat.Text = "Choose Wher Eat";
            // 
            // labCrust
            // 
            this.labCrust.AutoSize = true;
            this.labCrust.Location = new System.Drawing.Point(97, 174);
            this.labCrust.Name = "labCrust";
            this.labCrust.Size = new System.Drawing.Size(142, 21);
            this.labCrust.TabIndex = 7;
            this.labCrust.Text = "Choose Crust Pizza";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(62, 32);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(133, 21);
            this.labSize.TabIndex = 5;
            this.labSize.Text = "Choose Size Pizza";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrder.Location = new System.Drawing.Point(158, 336);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(128, 36);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnResert
            // 
            this.btnResert.BackColor = System.Drawing.Color.Transparent;
            this.btnResert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResert.ForeColor = System.Drawing.Color.Transparent;
            this.btnResert.Location = new System.Drawing.Point(330, 335);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(128, 36);
            this.btnResert.TabIndex = 7;
            this.btnResert.Text = "Resert";
            this.btnResert.UseVisualStyleBackColor = false;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(786, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(840, 397);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.labMake);
            this.Controls.Add(this.labExit);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                         ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbEat.ResumeLayout(false);
            this.gbEat.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labExit;
        private System.Windows.Forms.Label labMake;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeper;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtarChees;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.RadioButton rbTakOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labCrust;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labEat;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label label3;
    }
}

