namespace LoanCalculatorApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_loanAmount = new System.Windows.Forms.TextBox();
            this.txt_numberOfMonths = new System.Windows.Forms.TextBox();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.finalValue = new System.Windows.Forms.Label();
            this.txt_finalValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate";
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_loanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_loanAmount.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_loanAmount.Location = new System.Drawing.Point(273, 9);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(155, 34);
            this.txt_loanAmount.TabIndex = 3;
            // 
            // txt_numberOfMonths
            // 
            this.txt_numberOfMonths.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_numberOfMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_numberOfMonths.Location = new System.Drawing.Point(273, 58);
            this.txt_numberOfMonths.Name = "txt_numberOfMonths";
            this.txt_numberOfMonths.Size = new System.Drawing.Size(155, 34);
            this.txt_numberOfMonths.TabIndex = 4;
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_interestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_interestRate.Location = new System.Drawing.Point(273, 112);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(155, 34);
            this.txt_interestRate.TabIndex = 5;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_calculate.Location = new System.Drawing.Point(76, 466);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(129, 37);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_clear.Location = new System.Drawing.Point(290, 466);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 37);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(27, 152);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(610, 204);
            this.listBox.TabIndex = 8;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_exit.Location = new System.Drawing.Point(472, 466);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 37);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // finalValue
            // 
            this.finalValue.AutoSize = true;
            this.finalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.finalValue.Location = new System.Drawing.Point(29, 386);
            this.finalValue.Name = "finalValue";
            this.finalValue.Size = new System.Drawing.Size(133, 29);
            this.finalValue.TabIndex = 10;
            this.finalValue.Text = "Final Value";
            // 
            // txt_finalValue
            // 
            this.txt_finalValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_finalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_finalValue.Location = new System.Drawing.Point(187, 386);
            this.txt_finalValue.Name = "txt_finalValue";
            this.txt_finalValue.ReadOnly = true;
            this.txt_finalValue.Size = new System.Drawing.Size(153, 34);
            this.txt_finalValue.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.txt_finalValue);
            this.Controls.Add(this.finalValue);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_interestRate);
            this.Controls.Add(this.txt_numberOfMonths);
            this.Controls.Add(this.txt_loanAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_loanAmount;
        private System.Windows.Forms.TextBox txt_numberOfMonths;
        private System.Windows.Forms.TextBox txt_interestRate;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label finalValue;
        private System.Windows.Forms.TextBox txt_finalValue;
    }
}

