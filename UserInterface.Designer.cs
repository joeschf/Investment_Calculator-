
namespace Investment_Calculator
{
    partial class UserInterface
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
            this.uxStartText = new System.Windows.Forms.TextBox();
            this.uxStartLabel = new System.Windows.Forms.Label();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxInvestButton = new System.Windows.Forms.Button();
            this.uxStartAgeLabel = new System.Windows.Forms.Label();
            this.uxStartAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxEndAge = new System.Windows.Forms.TextBox();
            this.uxReturnLabel = new System.Windows.Forms.Label();
            this.uxReturnRate = new System.Windows.Forms.TextBox();
            this.uxYearlyCLabel = new System.Windows.Forms.Label();
            this.uxYearlyContribution = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxTotalContributions = new System.Windows.Forms.TextBox();
            this.uxYearlyGrowthLabel = new System.Windows.Forms.Label();
            this.uxYGrowth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uxEndingMoney = new System.Windows.Forms.TextBox();
            this.uxGraphButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.uxInflationMoney = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxInflationRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxStartText
            // 
            this.uxStartText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxStartText.Location = new System.Drawing.Point(61, 123);
            this.uxStartText.Name = "uxStartText";
            this.uxStartText.Size = new System.Drawing.Size(114, 32);
            this.uxStartText.TabIndex = 1;
            // 
            // uxStartLabel
            // 
            this.uxStartLabel.AutoSize = true;
            this.uxStartLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxStartLabel.Location = new System.Drawing.Point(23, 71);
            this.uxStartLabel.Name = "uxStartLabel";
            this.uxStartLabel.Size = new System.Drawing.Size(178, 32);
            this.uxStartLabel.TabIndex = 2;
            this.uxStartLabel.Text = "Starting Money";
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxEndLabel.Location = new System.Drawing.Point(642, 275);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(170, 32);
            this.uxEndLabel.TabIndex = 3;
            this.uxEndLabel.Text = "Ending Money";
            // 
            // uxInvestButton
            // 
            this.uxInvestButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxInvestButton.Location = new System.Drawing.Point(654, 20);
            this.uxInvestButton.Name = "uxInvestButton";
            this.uxInvestButton.Size = new System.Drawing.Size(205, 99);
            this.uxInvestButton.TabIndex = 0;
            this.uxInvestButton.Text = "Invest ";
            this.uxInvestButton.UseVisualStyleBackColor = true;
            this.uxInvestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxStartAgeLabel
            // 
            this.uxStartAgeLabel.AutoSize = true;
            this.uxStartAgeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxStartAgeLabel.Location = new System.Drawing.Point(23, 169);
            this.uxStartAgeLabel.Name = "uxStartAgeLabel";
            this.uxStartAgeLabel.Size = new System.Drawing.Size(152, 32);
            this.uxStartAgeLabel.TabIndex = 5;
            this.uxStartAgeLabel.Text = "Starting Age ";
            // 
            // uxStartAge
            // 
            this.uxStartAge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxStartAge.Location = new System.Drawing.Point(32, 213);
            this.uxStartAge.Name = "uxStartAge";
            this.uxStartAge.Size = new System.Drawing.Size(114, 32);
            this.uxStartAge.TabIndex = 6;
            this.uxStartAge.TextChanged += new System.EventHandler(this.UserInterface_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ending Age";
            // 
            // uxEndAge
            // 
            this.uxEndAge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxEndAge.Location = new System.Drawing.Point(32, 309);
            this.uxEndAge.Name = "uxEndAge";
            this.uxEndAge.Size = new System.Drawing.Size(114, 32);
            this.uxEndAge.TabIndex = 8;
            this.uxEndAge.TextChanged += new System.EventHandler(this.UserInterface_Load);
            // 
            // uxReturnLabel
            // 
            this.uxReturnLabel.AutoSize = true;
            this.uxReturnLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxReturnLabel.Location = new System.Drawing.Point(23, 353);
            this.uxReturnLabel.Name = "uxReturnLabel";
            this.uxReturnLabel.Size = new System.Drawing.Size(207, 32);
            this.uxReturnLabel.TabIndex = 9;
            this.uxReturnLabel.Text = "Annual Return (%)";
            // 
            // uxReturnRate
            // 
            this.uxReturnRate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxReturnRate.Location = new System.Drawing.Point(32, 398);
            this.uxReturnRate.Name = "uxReturnRate";
            this.uxReturnRate.Size = new System.Drawing.Size(114, 32);
            this.uxReturnRate.TabIndex = 10;
            this.uxReturnRate.TextChanged += new System.EventHandler(this.UserInterface_Load);
            // 
            // uxYearlyCLabel
            // 
            this.uxYearlyCLabel.AutoSize = true;
            this.uxYearlyCLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxYearlyCLabel.Location = new System.Drawing.Point(21, 449);
            this.uxYearlyCLabel.Name = "uxYearlyCLabel";
            this.uxYearlyCLabel.Size = new System.Drawing.Size(218, 32);
            this.uxYearlyCLabel.TabIndex = 11;
            this.uxYearlyCLabel.Text = "Yearly Contribution";
            // 
            // uxYearlyContribution
            // 
            this.uxYearlyContribution.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxYearlyContribution.Location = new System.Drawing.Point(59, 490);
            this.uxYearlyContribution.Name = "uxYearlyContribution";
            this.uxYearlyContribution.Size = new System.Drawing.Size(114, 32);
            this.uxYearlyContribution.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(642, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Contributions";
            // 
            // uxTotalContributions
            // 
            this.uxTotalContributions.BackColor = System.Drawing.SystemColors.Info;
            this.uxTotalContributions.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTotalContributions.Location = new System.Drawing.Point(680, 217);
            this.uxTotalContributions.MaximumSize = new System.Drawing.Size(250, 100);
            this.uxTotalContributions.Name = "uxTotalContributions";
            this.uxTotalContributions.ReadOnly = true;
            this.uxTotalContributions.Size = new System.Drawing.Size(197, 39);
            this.uxTotalContributions.TabIndex = 16;
            // 
            // uxYearlyGrowthLabel
            // 
            this.uxYearlyGrowthLabel.AutoSize = true;
            this.uxYearlyGrowthLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxYearlyGrowthLabel.Location = new System.Drawing.Point(12, 535);
            this.uxYearlyGrowthLabel.Name = "uxYearlyGrowthLabel";
            this.uxYearlyGrowthLabel.Size = new System.Drawing.Size(274, 32);
            this.uxYearlyGrowthLabel.TabIndex = 17;
            this.uxYearlyGrowthLabel.Text = "Contribution Growth (%)";
            // 
            // uxYGrowth
            // 
            this.uxYGrowth.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxYGrowth.Location = new System.Drawing.Point(23, 575);
            this.uxYGrowth.Name = "uxYGrowth";
            this.uxYGrowth.Size = new System.Drawing.Size(114, 32);
            this.uxYGrowth.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "$:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "$:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(642, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 38);
            this.label5.TabIndex = 21;
            this.label5.Text = "$:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fill out the values below";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(642, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 38);
            this.label9.TabIndex = 25;
            this.label9.Text = "$:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // uxEndingMoney
            // 
            this.uxEndingMoney.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxEndingMoney.Location = new System.Drawing.Point(680, 320);
            this.uxEndingMoney.Name = "uxEndingMoney";
            this.uxEndingMoney.Size = new System.Drawing.Size(197, 39);
            this.uxEndingMoney.TabIndex = 4;
            this.uxEndingMoney.TextChanged += new System.EventHandler(this.UserInterface_Load);
            // 
            // uxGraphButton
            // 
            this.uxGraphButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxGraphButton.Location = new System.Drawing.Point(1053, 535);
            this.uxGraphButton.Name = "uxGraphButton";
            this.uxGraphButton.Size = new System.Drawing.Size(70, 54);
            this.uxGraphButton.TabIndex = 26;
            this.uxGraphButton.Text = "View Graph";
            this.uxGraphButton.UseVisualStyleBackColor = true;
            this.uxGraphButton.Click += new System.EventHandler(this.uxGraphButton_Click);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(642, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 32);
            this.label8.TabIndex = 27;
            this.label8.Text = "Inflation Adjusted";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // uxInflationMoney
            // 
            this.uxInflationMoney.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxInflationMoney.Location = new System.Drawing.Point(680, 441);
            this.uxInflationMoney.Name = "uxInflationMoney";
            this.uxInflationMoney.Size = new System.Drawing.Size(197, 39);
            this.uxInflationMoney.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(642, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 38);
            this.label10.TabIndex = 29;
            this.label10.Text = "$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(321, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Inflation Rate (%)";
            // 
            // uxInflationRate
            // 
            this.uxInflationRate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxInflationRate.Location = new System.Drawing.Point(321, 120);
            this.uxInflationRate.Name = "uxInflationRate";
            this.uxInflationRate.Size = new System.Drawing.Size(114, 32);
            this.uxInflationRate.TabIndex = 31;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 691);
            this.Controls.Add(this.uxInflationRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.uxInflationMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxGraphButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxYGrowth);
            this.Controls.Add(this.uxYearlyGrowthLabel);
            this.Controls.Add(this.uxTotalContributions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxYearlyContribution);
            this.Controls.Add(this.uxYearlyCLabel);
            this.Controls.Add(this.uxReturnRate);
            this.Controls.Add(this.uxReturnLabel);
            this.Controls.Add(this.uxEndAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxStartAge);
            this.Controls.Add(this.uxStartAgeLabel);
            this.Controls.Add(this.uxEndingMoney);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxStartLabel);
            this.Controls.Add(this.uxStartText);
            this.Controls.Add(this.uxInvestButton);
            this.Name = "UserInterface";
            this.Text = "Optional Values";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxStartText;
        private System.Windows.Forms.Label uxStartLabel;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.Button uxInvestButton;
        private System.Windows.Forms.Label uxStartAgeLabel;
        private System.Windows.Forms.TextBox uxStartAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxEndAge;
        private System.Windows.Forms.Label uxReturnLabel;
        private System.Windows.Forms.TextBox uxReturnRate;
        private System.Windows.Forms.Label uxYearlyCLabel;
        private System.Windows.Forms.TextBox uxYearlyContribution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxTotalContributions;
        private System.Windows.Forms.Label uxYearlyGrowthLabel;
        private System.Windows.Forms.TextBox uxYGrowth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uxEndingMoney;
        private System.Windows.Forms.Button uxGraphButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxInflationMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxInflationRate;
    }
}