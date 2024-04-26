namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOutput = new TextBox();
            lblTitle = new Label();
            panel1 = new Panel();
            btnEquals = new Button();
            btnClear = new Button();
            btnDivide = new Button();
            btnTimes = new Button();
            btnNine = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnZero = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Arial Black", 20F);
            txtOutput.Location = new Point(0, 44);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(312, 45);
            txtOutput.TabIndex = 0;
            txtOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(149, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Calculator";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEquals);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDivide);
            panel1.Controls.Add(btnTimes);
            panel1.Controls.Add(btnNine);
            panel1.Controls.Add(btnSubtract);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnEight);
            panel1.Controls.Add(btnSeven);
            panel1.Controls.Add(btnSix);
            panel1.Controls.Add(btnFive);
            panel1.Controls.Add(btnFour);
            panel1.Controls.Add(btnZero);
            panel1.Controls.Add(btnThree);
            panel1.Controls.Add(btnTwo);
            panel1.Controls.Add(btnOne);
            panel1.Location = new Point(0, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 272);
            panel1.TabIndex = 2;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Arial", 12F);
            btnEquals.Location = new Point(234, 139);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(68, 59);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 12F);
            btnClear.Location = new Point(234, 9);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(68, 59);
            btnClear.TabIndex = 13;
            btnClear.Text = "<--";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Arial", 12F);
            btnDivide.Location = new Point(234, 74);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(68, 59);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("Arial", 12F);
            btnTimes.Location = new Point(160, 9);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(68, 59);
            btnTimes.TabIndex = 8;
            btnTimes.Text = "x";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += btnTimes_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Arial", 12F);
            btnNine.Location = new Point(160, 74);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(68, 59);
            btnNine.TabIndex = 12;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Arial", 12F);
            btnSubtract.Location = new Point(86, 9);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(68, 59);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F);
            btnAdd.Location = new Point(12, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 59);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Arial", 12F);
            btnEight.Location = new Point(86, 74);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(68, 59);
            btnEight.TabIndex = 11;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Arial", 12F);
            btnSeven.Location = new Point(12, 74);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(68, 59);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Arial", 12F);
            btnSix.Location = new Point(160, 139);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(68, 59);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Arial", 12F);
            btnFive.Location = new Point(86, 139);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(68, 59);
            btnFive.TabIndex = 8;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Arial", 12F);
            btnFour.Location = new Point(12, 139);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(68, 59);
            btnFour.TabIndex = 7;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Arial", 12F);
            btnZero.Location = new Point(234, 204);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(68, 59);
            btnZero.TabIndex = 6;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Arial", 12F);
            btnThree.Location = new Point(160, 204);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(68, 59);
            btnThree.TabIndex = 5;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Arial", 12F);
            btnTwo.Location = new Point(86, 204);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(68, 59);
            btnTwo.TabIndex = 4;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Arial", 12F);
            btnOne.Location = new Point(12, 204);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(68, 59);
            btnOne.TabIndex = 3;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 369);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Label lblTitle;
        private Panel panel1;
        private Button btnClear;
        private Button btnDivide;
        private Button btnTimes;
        private Button btnNine;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnEight;
        private Button btnSeven;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnZero;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnEquals;
    }
}
