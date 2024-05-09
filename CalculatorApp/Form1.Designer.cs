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
            numNum1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numNum2 = new NumericUpDown();
            lblOutput = new Label();
            btnCalculate = new Button();
            cmbOperation = new ComboBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)numNum1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNum2).BeginInit();
            SuspendLayout();
            // 
            // numNum1
            // 
            numNum1.Font = new Font("Arial", 12F);
            numNum1.Location = new Point(12, 95);
            numNum1.Name = "numNum1";
            numNum1.Size = new Size(280, 26);
            numNum1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 1;
            label1.Text = "Insert Your First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(304, 37);
            label2.TabIndex = 2;
            label2.Text = "Calculator Application";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(280, 30);
            label3.TabIndex = 4;
            label3.Text = "Insert Your Second Number";
            // 
            // numNum2
            // 
            numNum2.Font = new Font("Arial", 12F);
            numNum2.Location = new Point(12, 204);
            numNum2.Name = "numNum2";
            numNum2.Size = new Size(280, 26);
            numNum2.TabIndex = 2;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblOutput.Location = new Point(163, 313);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 28);
            lblOutput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalculate.Location = new Point(12, 252);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 36);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperation.Location = new Point(103, 137);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(121, 23);
            cmbOperation.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.Location = new Point(209, 252);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 36);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 348);
            Controls.Add(btnClear);
            Controls.Add(cmbOperation);
            Controls.Add(btnCalculate);
            Controls.Add(lblOutput);
            Controls.Add(label3);
            Controls.Add(numNum2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numNum1);
            Name = "Form1";
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)numNum1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNum2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numNum1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numNum2;
        private Label lblOutput;
        private Button btnCalculate;
        private ComboBox cmbOperation;
        private Button btnClear;
    }
}
